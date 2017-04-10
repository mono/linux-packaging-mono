﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace Internal.TypeSystem
{
    public class MetadataVirtualMethodAlgorithm : VirtualMethodAlgorithm
    {
        private class MethodDescHashtable : LockFreeReaderHashtable<MethodDesc, MethodDesc>
        {
            protected override int GetKeyHashCode(MethodDesc key)
            {
                return key.GetHashCode();
            }

            protected override int GetValueHashCode(MethodDesc value)
            {
                return value.GetHashCode();
            }

            protected override bool CompareKeyToValue(MethodDesc key, MethodDesc value)
            {
                Debug.Assert(key.Context == value.Context);
                return Object.ReferenceEquals(key, value);
            }

            protected override bool CompareValueToValue(MethodDesc value1, MethodDesc value2)
            {
                Debug.Assert(value1.Context == value2.Context);
                return Object.ReferenceEquals(value1, value2);
            }

            protected override MethodDesc CreateValueFromKey(MethodDesc key)
            {
                return key;
            }
        }

        private class UnificationGroup
        {
            private MethodDesc[] _members = MethodDesc.EmptyMethods;
            private int _memberCount = 0;

            /// <summary>
            /// Custom enumerator struct for Unification group. Makes enumeration require 0 allocations.
            /// </summary>
            public struct Enumerator
            {
                private MethodDesc[] _arrayToEnumerate;
                private int _index;
                private MethodDesc _current;

                internal Enumerator(MethodDesc[] arrayToEnumerate)
                {
                    _arrayToEnumerate = arrayToEnumerate;
                    _index = 0;
                    _current = default(MethodDesc);
                }

                public bool MoveNext()
                {
                    for (; _index < _arrayToEnumerate.Length; _index++)
                    {
                        if (_arrayToEnumerate[_index] != null)
                        {
                            _current = _arrayToEnumerate[_index];
                            _index++;
                            return true;
                        }
                    }

                    _current = default(MethodDesc);
                    return false;
                }

                public MethodDesc Current
                {
                    get
                    {
                        return _current;
                    }
                }
            }

            public UnificationGroup(MethodDesc definingMethod)
            {
                DefiningMethod = definingMethod;
                // TODO! Add assertion that DefiningMethod is a slot defining method
            }

            public MethodDesc DefiningMethod;

            public Enumerator GetEnumerator()
            {
                return new Enumerator(_members);
            }

            public void SetDefiningMethod(MethodDesc newDefiningMethod)
            {
                // Do not change the defining method if its the same as
                // one of the members, or it isn't a change at all
                if (!IsInGroup(newDefiningMethod) &&
                    DefiningMethod != newDefiningMethod)
                {
                    // When we set the defining method, ensure that the old defining method isn't removed from the group
                    MethodDesc oldDefiningMethod = DefiningMethod;
                    DefiningMethod = newDefiningMethod;
                    AddToGroup(oldDefiningMethod);

                    // TODO! Add assertion that DefiningMethod is a slot defining method
                }
            }

            public void AddToGroup(MethodDesc method)
            {
                if (method == DefiningMethod)
                    return;

                if (!IsInGroup(method))
                {
                    _memberCount++;
                    if (_memberCount >= _members.Length)
                    {
                        Array.Resize(ref _members, Math.Max(_members.Length * 2, 2));
                    }
                    for (int i = 0; i < _members.Length; i++)
                    {
                        if (_members[i] == null)
                        {
                            _members[i] = method;
                            break;
                        }
                    }
                }
            }

            public void RemoveFromGroup(MethodDesc method)
            {
                if (method == DefiningMethod)
                    throw new BadImageFormatException();

                for (int i = 0; i < _members.Length; i++)
                {
                    if (_members[i] == method)
                    {
                        _memberCount--;
                        _members[i] = null;
                        return;
                    }
                }
            }

            public bool IsInGroupOrIsDefiningSlot(MethodDesc method)
            {
                if (DefiningMethod == method)
                    return true;

                return IsInGroup(method);
            }

            public bool IsInGroup(MethodDesc method)
            {
                for (int i = 0; i < _members.Length; i++)
                {
                    if (_members[i] == method)
                        return true;
                }

                return false;
            }
        }

        public override MethodDesc FindVirtualFunctionTargetMethodOnObjectType(MethodDesc targetMethod, TypeDesc objectType)
        {
            return FindVirtualFunctionTargetMethodOnObjectType(targetMethod, (MetadataType)objectType);
        }

        /// <summary>
        /// Resolve a virtual function call (to a virtual method, not an interface method)
        /// </summary>
        /// <param name="targetMethod"></param>
        /// <param name="objectType"></param>
        /// <returns>The override of the virtual method that should be called</returns>
        private static MethodDesc FindVirtualFunctionTargetMethodOnObjectType(MethodDesc targetMethod, MetadataType objectType)
        {
            // Step 1, convert objectType to uninstantiated form
            MetadataType uninstantiatedType = objectType;
            MethodDesc initialTargetMethod = targetMethod;
            InstantiatedType initialInstantiatedType = objectType as InstantiatedType;
            if (initialInstantiatedType != null)
            {
                uninstantiatedType = (MetadataType)initialInstantiatedType.GetTypeDefinition();
            }

            // Step 2, convert targetMethod to method in type hierarchy of uninstantiated form
            targetMethod = targetMethod.GetMethodDefinition();
            if (uninstantiatedType != objectType)
            {
                targetMethod = uninstantiatedType.FindMethodOnTypeWithMatchingTypicalMethod(targetMethod);
            }

            // Step 3, find unification group of target method
            UnificationGroup group = new UnificationGroup(FindSlotDefiningMethodForVirtualMethod(targetMethod));
            FindBaseUnificationGroup(uninstantiatedType, group);

            // Step 4, name/sig match virtual function resolve
            MethodDesc resolutionTarget = FindNameSigOverrideForVirtualMethod(group.DefiningMethod, uninstantiatedType);

            // Step 5, convert resolution target from uninstantiated form target to objecttype target,
            // and instantiate as appropriate
            if (uninstantiatedType != objectType)
            {
                resolutionTarget = objectType.FindMethodOnTypeWithMatchingTypicalMethod(resolutionTarget);
            }
            if (initialTargetMethod.HasInstantiation)
            {
                resolutionTarget = resolutionTarget.MakeInstantiatedMethod(initialTargetMethod.Instantiation);
            }

            return resolutionTarget;
        }

        private static bool IsInterfaceImplementedOnType(MetadataType type, MetadataType interfaceType)
        {
            foreach (TypeDesc iface in type.RuntimeInterfaces)
            {
                if (iface == interfaceType)
                    return true;
            }
            return false;
        }

        private static MethodDesc FindImplFromDeclFromMethodImpls(MetadataType type, MethodDesc decl)
        {
            MethodImplRecord[] foundMethodImpls = type.FindMethodsImplWithMatchingDeclName(decl.Name);

            if (foundMethodImpls == null)
                return null;

            bool interfaceDecl = decl.OwningType.IsInterface;

            foreach (MethodImplRecord record in foundMethodImpls)
            {
                MethodDesc recordDecl = record.Decl;

                if (interfaceDecl != recordDecl.OwningType.IsInterface)
                    continue;

                if (!interfaceDecl)
                    recordDecl = FindSlotDefiningMethodForVirtualMethod(recordDecl);

                if (recordDecl == decl)
                {
                    return FindSlotDefiningMethodForVirtualMethod(record.Body);
                }
            }

            return null;
        }

        private static bool IsInterfaceExplicitlyImplementedOnType(MetadataType type, MetadataType interfaceType)
        {
            foreach (TypeDesc iface in type.ExplicitlyImplementedInterfaces)
            {
                if (iface == interfaceType)
                    return true;
            }
            return false;
        }

        private static MethodDesc FindMatchingVirtualMethodOnTypeByNameAndSig(MethodDesc targetMethod, DefType currentType)
        {
            string name = targetMethod.Name;
            MethodSignature sig = targetMethod.Signature;

            // TODO: InstantiatedType.GetMethod can't handle this for a situation like
            // an instantiation of Foo<T>.M(T) because sig is instantiated, but it compares
            // it to the uninstantiated version
            //MethodDesc implMethod = currentType.GetMethod(name, sig);
            MethodDesc implMethod = null;
            foreach (MethodDesc candidate in currentType.GetAllMethods())
            {
                if (!candidate.IsVirtual)
                    continue;

                if (candidate.Name == name)
                {
                    if (candidate.Signature.Equals(sig))
                    {
                        if (implMethod != null)
                        {
                            throw new NotImplementedException("NYI: differentiating between overloads on instantiations when the instantiated signatures match.");
                        }
                        implMethod = candidate;
                    }
                }
            }

            return implMethod;
        }

        // This function is used to find the name/sig based override for a given method. This method ignores all 
        // method impl's as it assumes they have been resolved. The algorithm is simple. Walk to the base type looking
        // for overrides by name and signature. If one is found, return it as long as the newslot defining method
        // for the found method matches that of the target method.
        private static MethodDesc FindNameSigOverrideForVirtualMethod(MethodDesc targetMethod, MetadataType currentType)
        {
            while (currentType != null)
            {
                MethodDesc nameSigOverride = FindMatchingVirtualMethodOnTypeByNameAndSigWithSlotCheck(targetMethod, currentType);

                if (nameSigOverride != null)
                {
                    return nameSigOverride;
                }

                currentType = currentType.MetadataBaseType;
            }

            return null;
        }

        // This function looks for the base type method that defines the slot for a method
        // This is either the newslot method most derived that is in the parent hierarchy of method
        // or the least derived method that isn't newslot that matches by name and sig.
        public static MethodDesc FindSlotDefiningMethodForVirtualMethod(MethodDesc method)
        {
            if (method == null)
                return method;

            DefType currentType = method.OwningType.BaseType;

            // Loop until a newslot method is found
            while ((currentType != null) && !method.IsNewSlot)
            {
                MethodDesc foundMethod = FindMatchingVirtualMethodOnTypeByNameAndSig(method, currentType);
                if (foundMethod != null)
                {
                    method = foundMethod;
                }

                currentType = currentType.BaseType;
            }

            // Newslot method found, or if not the least derived method that matches by name and
            // sig is to be returned.
            return method;
        }

        private static MethodDesc FindMatchingVirtualMethodOnTypeByNameAndSigWithSlotCheck(MethodDesc method, DefType currentType)
        {
            MethodDesc foundMethod = FindMatchingVirtualMethodOnTypeByNameAndSig(method, currentType);
            if (foundMethod != null)
            {
                if (VerifyMethodsHaveTheSameVirtualSlot(foundMethod, method))
                {
                    return foundMethod;
                }
            }

            return null;
        }

        // Return true if the slot that defines methodToVerify matches slotDefiningMethod
        private static bool VerifyMethodsHaveTheSameVirtualSlot(MethodDesc methodToVerify, MethodDesc slotDefiningMethod)
        {
            MethodDesc slotDefiningMethodOfMethodToVerify = FindSlotDefiningMethodForVirtualMethod(methodToVerify);
            return slotDefiningMethodOfMethodToVerify == slotDefiningMethod;
        }

        private static void FindBaseUnificationGroup(MetadataType currentType, UnificationGroup unificationGroup)
        {
            MethodDesc originalDefiningMethod = unificationGroup.DefiningMethod;

            MethodDesc methodImpl = FindImplFromDeclFromMethodImpls(currentType, unificationGroup.DefiningMethod);
            if (methodImpl != null)
            {
                unificationGroup.SetDefiningMethod(methodImpl);
            }

            MethodDesc nameSigMatchMethod = FindMatchingVirtualMethodOnTypeByNameAndSigWithSlotCheck(unificationGroup.DefiningMethod, currentType);
            MetadataType baseType = currentType.MetadataBaseType;

            // Unless the current type has a name/sig match for the group, look to the base type to define the unification group further
            if ((nameSigMatchMethod == null) && (baseType != null))
            {
                FindBaseUnificationGroup(baseType, unificationGroup);
            }

            Debug.Assert(unificationGroup.IsInGroupOrIsDefiningSlot(originalDefiningMethod));

            // Now, we have the unification group from the type, or have discovered its defined on the current type.
            // Adjust the group to contain all of the elements that are added to it on this type, remove the components that
            // have seperated themselves from the group

            // Start with removing methods that seperated themselves from the group via name/sig matches
            MethodDescHashtable separatedMethods = null;

            foreach (MethodDesc memberMethod in unificationGroup)
            {
                MethodDesc nameSigMatchMemberMethod = FindMatchingVirtualMethodOnTypeByNameAndSigWithSlotCheck(memberMethod, currentType);
                if (nameSigMatchMemberMethod != null)
                {
                    if (separatedMethods == null)
                        separatedMethods = new MethodDescHashtable();
                    separatedMethods.AddOrGetExisting(memberMethod);
                }
            }

            if (separatedMethods != null)
            {
                foreach (MethodDesc seperatedMethod in MethodDescHashtable.Enumerator.Get(separatedMethods))
                {
                    unificationGroup.RemoveFromGroup(seperatedMethod);
                }
            }

            // Next find members which have seperated or added themselves to the group via MethodImpls
            foreach (MethodImplRecord methodImplRecord in currentType.VirtualMethodImplsForType)
            {
                MethodDesc declSlot = FindSlotDefiningMethodForVirtualMethod(methodImplRecord.Decl);
                MethodDesc implSlot = FindSlotDefiningMethodForVirtualMethod(methodImplRecord.Body);

                if (unificationGroup.IsInGroup(declSlot) && !unificationGroup.IsInGroupOrIsDefiningSlot(implSlot))
                {
                    unificationGroup.RemoveFromGroup(declSlot);

                    if (separatedMethods == null)
                        separatedMethods = new MethodDescHashtable();
                    separatedMethods.AddOrGetExisting(declSlot);
                    continue;
                }
                if (!unificationGroup.IsInGroupOrIsDefiningSlot(declSlot) && unificationGroup.IsInGroupOrIsDefiningSlot(implSlot))
                {
                    // Add decl to group.

                    // To do so, we need to have the Unification Group of the decl slot, as it may have multiple members itself
                    UnificationGroup addDeclGroup = new UnificationGroup(declSlot);
                    FindBaseUnificationGroup(baseType, addDeclGroup);
                    Debug.Assert(addDeclGroup.IsInGroupOrIsDefiningSlot(declSlot));

                    // Add all members from the decl's unification group except for ones that have been seperated by name/sig matches
                    // or previously processed methodimpls. NOTE: This implies that method impls are order dependent.
                    if (separatedMethods == null || !separatedMethods.Contains(addDeclGroup.DefiningMethod))
                    {
                        unificationGroup.AddToGroup(addDeclGroup.DefiningMethod);
                    }

                    foreach (MethodDesc addDeclGroupMemberMethod in addDeclGroup)
                    {
                        if (separatedMethods == null || !separatedMethods.Contains(addDeclGroupMemberMethod))
                        {
                            unificationGroup.AddToGroup(addDeclGroupMemberMethod);
                        }
                    }
                }
            }
        }

        public override MethodDesc ResolveInterfaceMethodToVirtualMethodOnType(MethodDesc interfaceMethod, TypeDesc currentType)
        {
            return ResolveInterfaceMethodToVirtualMethodOnType(interfaceMethod, (MetadataType)currentType);
        }

        //////////////////////// INTERFACE RESOLUTION
        //Interface function resolution
        //    Interface function resolution follows the following rules
        //    1.    Apply any method impl that may exist, if once of these exists, resolve to target immediately.
        //    2.    If an interface is explicitly defined on a type, then attempt to perform a namesig match on the 
        //          current type to resolve.If the interface isn’t resolved, if it isn’t implemented on a base type, 
        //          scan all base types for name / sig matches.
        //    3.    If implicitly defined, attempt to perform a namesig match if the interface method implementation 
        //          has not been found on some base type.
        //    The above will resolve an interface to a virtual method slot. From there perform virtual resolution 
        //    to find out the actual target.Note, to preserve correct behavior in the presence of variance, this 
        //    function returns null if the interface method implementation is not defined by the current type in 
        //    the hierarchy.For variance to work correctly, this requires that interfaces be queried in correct order.
        //    See current interface call resolution for details on how that happens.
        private static MethodDesc ResolveInterfaceMethodToVirtualMethodOnType(MethodDesc interfaceMethod, MetadataType currentType)
        {
            if (currentType.IsInterface)
                return null;

            MethodDesc methodImpl = FindImplFromDeclFromMethodImpls(currentType, interfaceMethod);
            if (methodImpl != null)
                return methodImpl;

            MetadataType interfaceType = (MetadataType)interfaceMethod.OwningType;

            // If interface is explicitly defined on a type, search for a name/sig match.
            bool foundExplicitInterface = IsInterfaceExplicitlyImplementedOnType(currentType, interfaceType);
            MetadataType baseType = currentType.MetadataBaseType;

            if (foundExplicitInterface)
            {
                MethodDesc foundOnCurrentType = FindMatchingVirtualMethodOnTypeByNameAndSig(interfaceMethod, currentType);
                foundOnCurrentType = FindSlotDefiningMethodForVirtualMethod(foundOnCurrentType);

                if (baseType == null)
                    return foundOnCurrentType;

                if (foundOnCurrentType == null && (ResolveInterfaceMethodToVirtualMethodOnType(interfaceMethod, baseType) == null))
                {
                    // TODO! Does this handle the case where the base type explicitly implements the interface, but is abstract
                    // and doesn't actually have an implementation?
                    if (!IsInterfaceImplementedOnType(baseType, interfaceType))
                    {
                        return FindNameSigOverrideForInterfaceMethodRecursive(interfaceMethod, baseType);
                    }
                }
                return foundOnCurrentType;
            }
            else
            {
                // Implicit interface case
                if (!IsInterfaceImplementedOnType(currentType, interfaceType))
                {
                    // If the interface isn't implemented on this type at all, don't go searching
                    return null;
                }

                // This is an implicitly implemented interface method. Only return a vlaue if this is the first type in the class
                // hierarchy that implements the interface. NOTE: If we pay attention to whether or not the parent type is 
                // abstract or not, we may be able to be more efficient here, but let's skip that for now
                MethodDesc baseClassImplementationOfInterfaceMethod = ResolveInterfaceMethodToVirtualMethodOnTypeRecursive(interfaceMethod, baseType);
                if (baseClassImplementationOfInterfaceMethod != null)
                {
                    return null;
                }
                else
                {
                    return FindNameSigOverrideForInterfaceMethodRecursive(interfaceMethod, currentType);
                }
            }
        }

        // Helper routine used during implicit interface implementation discovery
        private static MethodDesc ResolveInterfaceMethodToVirtualMethodOnTypeRecursive(MethodDesc interfaceMethod, MetadataType currentType)
        {
            while (true)
            {
                if (currentType == null)
                    return null;

                MetadataType interfaceType = (MetadataType)interfaceMethod.OwningType;

                if (!IsInterfaceImplementedOnType(currentType, interfaceType))
                {
                    // If the interface isn't implemented on this type at all, don't go searching
                    return null;
                }

                MethodDesc currentTypeInterfaceResolution = ResolveInterfaceMethodToVirtualMethodOnType(interfaceMethod, currentType);
                if (currentTypeInterfaceResolution != null)
                    return currentTypeInterfaceResolution;

                currentType = currentType.MetadataBaseType;
            }
        }

        // Perform a name/sig match for a virtual method across the specified types and all of the types parents.
        private static MethodDesc FindNameSigOverrideForInterfaceMethodRecursive(MethodDesc interfaceMethod, MetadataType currentType)
        {
            while (true)
            {
                if (currentType == null)
                    return null;

                MethodDesc nameSigOverride = FindMatchingVirtualMethodOnTypeByNameAndSig(interfaceMethod, currentType);
                if (nameSigOverride != null)
                {
                    return FindSlotDefiningMethodForVirtualMethod(nameSigOverride);
                }

                currentType = currentType.MetadataBaseType;
            }
        }

        public override IEnumerable<MethodDesc> ComputeAllVirtualSlots(TypeDesc type)
        {
            return EnumAllVirtualSlots((MetadataType)type);
        }

        // Enumerate all possible virtual slots of a type
        public static IEnumerable<MethodDesc> EnumAllVirtualSlots(MetadataType type)
        {
            MethodDescHashtable alreadyEnumerated = new MethodDescHashtable();
            if (!type.IsInterface)
            {
                do
                {
                    foreach (MethodDesc m in type.GetAllMethods())
                    {
                        if (!m.IsVirtual)
                            continue;

                        MethodDesc possibleVirtual = FindSlotDefiningMethodForVirtualMethod(m);
                        if (!alreadyEnumerated.Contains(possibleVirtual))
                        {
                            alreadyEnumerated.AddOrGetExisting(possibleVirtual);
                            yield return possibleVirtual;
                        }
                    }

                    type = type.MetadataBaseType;
                } while (type != null);
            }
        }
    }
}
