// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

[assembly:System.Reflection.AssemblyVersionAttribute("4.1.1.0")]
[assembly:System.Diagnostics.DebuggableAttribute((System.Diagnostics.DebuggableAttribute.DebuggingModes)(2))]
[assembly:System.Reflection.AssemblyCompanyAttribute("Mono development team")]
[assembly:System.Reflection.AssemblyCopyrightAttribute("(c) Various Mono authors")]
[assembly:System.Reflection.AssemblyDefaultAliasAttribute("System.Diagnostics.StackTrace")]
[assembly:System.Reflection.AssemblyDescriptionAttribute("System.Diagnostics.StackTrace")]
[assembly:System.Reflection.AssemblyFileVersionAttribute("4.0.0.0")]
[assembly:System.Reflection.AssemblyInformationalVersionAttribute("4.0.0.0")]
[assembly:System.Reflection.AssemblyProductAttribute("Mono Common Language Infrastructure")]
[assembly:System.Reflection.AssemblyTitleAttribute("System.Diagnostics.StackTrace")]
[assembly:System.Runtime.CompilerServices.CompilationRelaxationsAttribute(8)]
[assembly:System.Runtime.CompilerServices.RuntimeCompatibilityAttribute(WrapNonExceptionThrows=true)]
[assembly:System.Runtime.CompilerServices.TypeForwardedToAttribute(typeof(System.Diagnostics.StackFrame))]
[assembly:System.Runtime.CompilerServices.TypeForwardedToAttribute(typeof(System.Diagnostics.StackTrace))]
[assembly:System.Runtime.CompilerServices.TypeForwardedToAttribute(typeof(System.Diagnostics.SymbolStore.ISymbolBinder))]
[assembly:System.Runtime.CompilerServices.TypeForwardedToAttribute(typeof(System.Diagnostics.SymbolStore.ISymbolBinder1))]
[assembly:System.Runtime.CompilerServices.TypeForwardedToAttribute(typeof(System.Diagnostics.SymbolStore.ISymbolDocument))]
[assembly:System.Runtime.CompilerServices.TypeForwardedToAttribute(typeof(System.Diagnostics.SymbolStore.ISymbolDocumentWriter))]
[assembly:System.Runtime.CompilerServices.TypeForwardedToAttribute(typeof(System.Diagnostics.SymbolStore.ISymbolMethod))]
[assembly:System.Runtime.CompilerServices.TypeForwardedToAttribute(typeof(System.Diagnostics.SymbolStore.ISymbolNamespace))]
[assembly:System.Runtime.CompilerServices.TypeForwardedToAttribute(typeof(System.Diagnostics.SymbolStore.ISymbolReader))]
[assembly:System.Runtime.CompilerServices.TypeForwardedToAttribute(typeof(System.Diagnostics.SymbolStore.ISymbolScope))]
[assembly:System.Runtime.CompilerServices.TypeForwardedToAttribute(typeof(System.Diagnostics.SymbolStore.ISymbolVariable))]
[assembly:System.Runtime.CompilerServices.TypeForwardedToAttribute(typeof(System.Diagnostics.SymbolStore.ISymbolWriter))]
[assembly:System.Runtime.CompilerServices.TypeForwardedToAttribute(typeof(System.Diagnostics.SymbolStore.SymAddressKind))]
[assembly:System.Runtime.CompilerServices.TypeForwardedToAttribute(typeof(System.Diagnostics.SymbolStore.SymbolToken))]
[assembly:System.Runtime.CompilerServices.TypeForwardedToAttribute(typeof(System.Diagnostics.SymbolStore.SymDocumentType))]
[assembly:System.Runtime.CompilerServices.TypeForwardedToAttribute(typeof(System.Diagnostics.SymbolStore.SymLanguageType))]
[assembly:System.Runtime.CompilerServices.TypeForwardedToAttribute(typeof(System.Diagnostics.SymbolStore.SymLanguageVendor))]
namespace System
{
    [System.AttributeUsageAttribute((System.AttributeTargets)(32767), AllowMultiple=true)]
    internal partial class MonoDocumentationNoteAttribute : System.MonoTODOAttribute
    {
        public MonoDocumentationNoteAttribute(string comment) { }
    }
    [System.AttributeUsageAttribute((System.AttributeTargets)(32767), AllowMultiple=true)]
    internal partial class MonoExtensionAttribute : System.MonoTODOAttribute
    {
        public MonoExtensionAttribute(string comment) { }
    }
    [System.AttributeUsageAttribute((System.AttributeTargets)(32767), AllowMultiple=true)]
    internal partial class MonoInternalNoteAttribute : System.MonoTODOAttribute
    {
        public MonoInternalNoteAttribute(string comment) { }
    }
    [System.AttributeUsageAttribute((System.AttributeTargets)(32767), AllowMultiple=true)]
    internal partial class MonoLimitationAttribute : System.MonoTODOAttribute
    {
        public MonoLimitationAttribute(string comment) { }
    }
    [System.AttributeUsageAttribute((System.AttributeTargets)(32767), AllowMultiple=true)]
    internal partial class MonoNotSupportedAttribute : System.MonoTODOAttribute
    {
        public MonoNotSupportedAttribute(string comment) { }
    }
    [System.AttributeUsageAttribute((System.AttributeTargets)(32767), AllowMultiple=true)]
    internal partial class MonoTODOAttribute : System.Attribute
    {
        public MonoTODOAttribute() { }
        public MonoTODOAttribute(string comment) { }
        public string Comment { get { throw null; } }
    }
}
namespace System.Diagnostics
{
    public static partial class StackFrameExtensions
    {
        [System.MonoTODOAttribute]
        public static System.IntPtr GetNativeImageBase(this System.Diagnostics.StackFrame stackFrame) { throw null; }
        [System.MonoTODOAttribute]
        public static System.IntPtr GetNativeIP(this System.Diagnostics.StackFrame stackFrame) { throw null; }
        [System.MonoTODOAttribute]
        public static bool HasILOffset(this System.Diagnostics.StackFrame stackFrame) { throw null; }
        [System.MonoTODOAttribute]
        public static bool HasMethod(this System.Diagnostics.StackFrame stackFrame) { throw null; }
        [System.MonoTODOAttribute]
        public static bool HasNativeImage(this System.Diagnostics.StackFrame stackFrame) { throw null; }
        [System.MonoTODOAttribute]
        public static bool HasSource(this System.Diagnostics.StackFrame stackFrame) { throw null; }
    }
}
