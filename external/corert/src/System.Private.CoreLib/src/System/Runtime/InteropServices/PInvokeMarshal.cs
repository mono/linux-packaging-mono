// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Runtime.CompilerServices;

namespace System.Runtime.InteropServices
{
    /// <summary>
    /// This PInvokeMarshal class should provide full public Marshal 
    /// implementation for all things related to P/Invoke marshalling
    /// </summary>
    public partial class PInvokeMarshal
    {
        [ThreadStatic]
        internal static int s_lastWin32Error;

        public static int GetLastWin32Error()
        {
            return s_lastWin32Error;
        }

        public static void SetLastWin32Error(int errorCode)
        {
            s_lastWin32Error = errorCode;
        }
    }
}
