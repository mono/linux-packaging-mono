// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Diagnostics;
using Internal.Runtime.Augments;

namespace Internal.Runtime.CompilerServices
{
    public struct RuntimeSignature
    {
        private IntPtr _moduleHandle;
        private int _tokenOrOffset;
        private bool _isNativeLayoutSignature;

        [CLSCompliant(false)]
        public static RuntimeSignature CreateFromNativeLayoutSignature(IntPtr moduleHandle, uint nativeLayoutOffset)
        {
            return new RuntimeSignature
            {
                _moduleHandle = moduleHandle,
                _tokenOrOffset = (int)nativeLayoutOffset,
                _isNativeLayoutSignature = true,
            };
        }

        public static RuntimeSignature CreateFromMethodHandle(IntPtr moduleHandle, int token)
        {
            return new RuntimeSignature
            {
                _moduleHandle = moduleHandle,
                _tokenOrOffset = token,
                _isNativeLayoutSignature = false,
            };
        }

        public bool IsNativeLayoutSignature
        {
            get
            {
                return _isNativeLayoutSignature;
            }
        }

        public int Token
        {
            get
            {
                if (_isNativeLayoutSignature)
                {
                    Debug.Assert(false);
                    return -1;
                }
                return _tokenOrOffset;
            }
        }

        [CLSCompliant(false)]
        public uint NativeLayoutOffset
        {
            get
            {
                if (!_isNativeLayoutSignature)
                {
                    Debug.Assert(false);
                    return unchecked((uint)-1);
                }
                return (uint)_tokenOrOffset;
            }
        }

        public IntPtr ModuleHandle
        {
            get
            {
                return _moduleHandle;
            }
        }

        public bool Equals(RuntimeSignature other)
        {
            if (IsNativeLayoutSignature && other.IsNativeLayoutSignature)
            {
                if ((ModuleHandle == other.ModuleHandle) && (NativeLayoutOffset == other.NativeLayoutOffset))
                    return true;
            }
            else if (!IsNativeLayoutSignature && !other.IsNativeLayoutSignature)
            {
                if ((ModuleHandle == other.ModuleHandle) && (Token == other.Token))
                    return true;
            }

            // Walk both signatures to check for equality the slow way
            return RuntimeAugments.TypeLoaderCallbacks.CompareMethodSignatures(this, other);
        }

        /// <summary>
        /// Fast equality check
        /// </summary>
        public bool StructuralEquals(RuntimeSignature other)
        {
            if (_moduleHandle != other._moduleHandle)
                return false;

            if (_tokenOrOffset != other._tokenOrOffset)
                return false;

            if (_isNativeLayoutSignature != other._isNativeLayoutSignature)
                return false;

            return true;
        }
    }
}
