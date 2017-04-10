// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.


using System;
using Internal.NativeFormat;
using Internal.Runtime.CompilerServices;
using Internal.Runtime.TypeLoader;
using Debug = System.Diagnostics.Debug;

namespace Internal.TypeSystem
{
    public sealed partial class InstantiatedMethod : MethodDesc
    {
        public override MethodNameAndSignature NameAndSignature
        {
            get
            {
                return _methodDef.NameAndSignature;
            }
        }


        protected override bool ComputeIsNonSharableMethod()
        {
            return !IsCanonicalMethod(CanonicalFormKind.Any) &&
                        this == GetCanonMethodTarget(CanonicalFormKind.Specific);
        }


        /// <summary>
        /// Does this method need a dictionary?
        /// </summary>
        public bool NeedsDictionary { get; set; }

        /// <summary>
        /// IntPtr pointing at allocated method generic dictionary.
        /// </summary>
        public IntPtr RuntimeMethodDictionary { get; private set; }
        internal GenericDictionary Dictionary { get; private set; }

        // Set the Dictionary property. This is a helper function so that setting is easy to search for
        internal void SetGenericDictionary(GenericDictionary dictionary)
        {
            Dictionary = dictionary;
        }

        /// <summary>
        /// Attach a generic dictionary to this method
        /// </summary>
        /// <param name="rmd"></param>
        public void AssociateWithRuntimeMethodDictionary(IntPtr rmd)
        {
            Debug.Assert(rmd != IntPtr.Zero);
            RuntimeMethodDictionary = rmd;
        }

        public override System.Boolean UnboxingStub
        {
            get
            {
                return _methodDef.UnboxingStub;
            }
        }
    }
}
