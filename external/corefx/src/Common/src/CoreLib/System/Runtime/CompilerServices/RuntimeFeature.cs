// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

namespace System.Runtime.CompilerServices
{
    public static partial class RuntimeFeature
    {
        /// <summary>
        /// Name of the Portable PDB feature.
        /// </summary>
        public const string PortablePdb = nameof(PortablePdb);

#if FEATURE_DEFAULT_INTERFACES
        /// <summary>
        /// Indicates that this version of runtime supports default interface method implementations.
        /// </summary>
        public const string DefaultImplementationsOfInterfaces = nameof(DefaultImplementationsOfInterfaces);
#endif

        /// <summary>
        /// Checks whether a certain feature is supported by the Runtime.
        /// </summary>
        public static bool IsSupported(string feature)
        {
            switch (feature)
            {
                case PortablePdb:
#if FEATURE_DEFAULT_INTERFACES
                case DefaultImplementationsOfInterfaces:
#endif
                    return true;
#if MONO
                case nameof(IsDynamicCodeSupported):
                    return IsDynamicCodeSupported;
                case nameof(IsDynamicCodeCompiled):
                    return IsDynamicCodeCompiled;
#endif
            }

            return false;
        }
        
#if MONO
        // https://github.com/dotnet/coreclr/blob/397aaccb5104844998c3bcf6e9245cc81127e1e2/src/System.Private.CoreLib/src/System/Runtime/CompilerServices/RuntimeFeature.CoreCLR.cs#L9-L10
        public static bool IsDynamicCodeSupported => true;
        public static bool IsDynamicCodeCompiled => true;
#endif
    }
}
