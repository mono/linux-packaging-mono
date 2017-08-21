// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Generic;
using System.Dynamic;
using Microsoft.CSharp.RuntimeBinder.Semantics;

namespace Microsoft.CSharp.RuntimeBinder
{
    /// <summary>
    /// Represents a dynamic method call in C#, providing the binding semantics and the details about the operation. 
    /// Instances of this class are generated by the C# compiler.
    /// </summary>
    internal sealed class CSharpInvokeMemberBinder : InvokeMemberBinder, ICSharpInvokeOrInvokeMemberBinder
    {
        public BindingFlag BindingFlags => 0;

        public Expr DispatchPayload(RuntimeBinder runtimeBinder, ArgumentObject[] arguments, LocalVariableSymbol[] locals)
            => runtimeBinder.DispatchPayload(this, arguments, locals);

        public void PopulateSymbolTableWithName(SymbolTable symbolTable, Type callingType, ArgumentObject[] arguments)
            => RuntimeBinder.PopulateSymbolTableWithPayloadInformation(symbolTable, this, callingType, arguments);

        public bool IsBinderThatCanHaveRefReceiver => true;

        bool ICSharpInvokeOrInvokeMemberBinder.StaticCall => _argumentInfo[0]?.IsStaticType == true;

        public CSharpCallFlags Flags { get; }

        public Type CallingContext { get; }

        public bool IsChecked => false;

        public IList<Type> TypeArguments => _typeArguments.AsReadOnly();

        private readonly List<Type> _typeArguments;

        private readonly List<CSharpArgumentInfo> _argumentInfo;

        public CSharpArgumentInfo GetArgumentInfo(int index) => _argumentInfo[index];

        public CSharpArgumentInfo[] ArgumentInfoArray() => _argumentInfo.ToArray();

        bool ICSharpInvokeOrInvokeMemberBinder.ResultDiscarded => (Flags & CSharpCallFlags.ResultDiscarded) != 0;

        private readonly RuntimeBinder _binder;

        /// <summary>
        /// Initializes a new instance of the <see cref="CSharpInvokeMemberBinder" />.
        /// </summary>
        /// <param name="flags">Extra information about this operation that is not specific to any particular argument.</param>
        /// <param name="name">The name of the member to invoke.</param>
        /// <param name="callingContext">The <see cref="System.Type"/> that indicates where this operation is defined.</param>
        /// <param name="typeArguments">The list of user-specified type arguments to this call.</param>
        /// <param name="argumentInfo">The sequence of <see cref="CSharpArgumentInfo"/> instances for the arguments to this operation.</param>
        public CSharpInvokeMemberBinder(
                CSharpCallFlags flags,
                string name,
                Type callingContext,
                IEnumerable<Type> typeArguments,
                IEnumerable<CSharpArgumentInfo> argumentInfo) :
            base(name, false, BinderHelper.CreateCallInfo(argumentInfo, 1)) // discard 1 argument: the target object (even if static, arg is type)
        {
            Flags = flags;
            CallingContext = callingContext;
            _typeArguments = BinderHelper.ToList(typeArguments);
            _argumentInfo = BinderHelper.ToList(argumentInfo);
            _binder = RuntimeBinder.GetInstance();
        }

        /// <summary>
        /// Performs the binding of the dynamic invoke member operation if the target dynamic object cannot bind.
        /// </summary>
        /// <param name="target">The target of the dynamic invoke member operation.</param>
        /// <param name="args">The arguments of the dynamic invoke member operation.</param>
        /// <param name="errorSuggestion">The binding result to use if binding fails, or null.</param>
        /// <returns>The <see cref="DynamicMetaObject"/> representing the result of the binding.</returns>
        public override DynamicMetaObject FallbackInvokeMember(DynamicMetaObject target, DynamicMetaObject[] args, DynamicMetaObject errorSuggestion)
        {
#if ENABLECOMBINDER
            DynamicMetaObject com;
            if (!BinderHelper.IsWindowsRuntimeObject(target) && ComBinder.TryBindInvokeMember(this, target, args, out com))
            {
                return com;
            }
#endif
            return BinderHelper.Bind(this, _binder, BinderHelper.Cons(target, args), _argumentInfo, errorSuggestion);
        }

        /// <summary>
        /// Performs the binding of the dynamic invoke operation if the target dynamic object cannot bind.
        /// </summary>
        /// <param name="target">The target of the dynamic invoke operation.</param>
        /// <param name="args">The arguments of the dynamic invoke operation.</param>
        /// <param name="errorSuggestion">The binding result to use if binding fails, or null.</param>
        /// <returns>The <see cref="DynamicMetaObject"/> representing the result of the binding.</returns>
        public override DynamicMetaObject FallbackInvoke(DynamicMetaObject target, DynamicMetaObject[] args, DynamicMetaObject errorSuggestion)
        {
            CSharpInvokeBinder c = new CSharpInvokeBinder(Flags, CallingContext, _argumentInfo);
            return c.Defer(target, args);
        }
    }
}
