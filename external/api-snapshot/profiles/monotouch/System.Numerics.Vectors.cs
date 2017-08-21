// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

[assembly:System.Reflection.AssemblyVersionAttribute("2.0.5.0")]
[assembly:System.CLSCompliantAttribute(true)]
[assembly:System.Diagnostics.DebuggableAttribute((System.Diagnostics.DebuggableAttribute.DebuggingModes)(2))]
[assembly:System.Reflection.AssemblyCompanyAttribute("Mono development team")]
[assembly:System.Reflection.AssemblyCopyrightAttribute("(c) Various Mono authors")]
[assembly:System.Reflection.AssemblyDefaultAliasAttribute("System.Numerics.Vectors.dll")]
[assembly:System.Reflection.AssemblyDescriptionAttribute("System.Numerics.Vectors.dll")]
[assembly:System.Reflection.AssemblyFileVersionAttribute("4.0.50524.0")]
[assembly:System.Reflection.AssemblyInformationalVersionAttribute("4.0.50524.0")]
[assembly:System.Reflection.AssemblyProductAttribute("Mono Common Language Infrastructure")]
[assembly:System.Reflection.AssemblyTitleAttribute("System.Numerics.Vectors.dll")]
[assembly:System.Resources.NeutralResourcesLanguageAttribute("en-US")]
[assembly:System.Resources.SatelliteContractVersionAttribute("2.0.5.0")]
[assembly:System.Runtime.CompilerServices.CompilationRelaxationsAttribute(8)]
[assembly:System.Runtime.CompilerServices.RuntimeCompatibilityAttribute(WrapNonExceptionThrows=true)]
[assembly:System.Runtime.InteropServices.ComVisibleAttribute(false)]
[assembly:System.Security.SecurityCriticalAttribute]
[assembly:System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.RequestMinimum, SkipVerification=true)]
[assembly:System.Runtime.CompilerServices.TypeForwardedToAttribute(typeof(System.Numerics.Matrix3x2))]
[assembly:System.Runtime.CompilerServices.TypeForwardedToAttribute(typeof(System.Numerics.Matrix4x4))]
[assembly:System.Runtime.CompilerServices.TypeForwardedToAttribute(typeof(System.Numerics.Plane))]
[assembly:System.Runtime.CompilerServices.TypeForwardedToAttribute(typeof(System.Numerics.Quaternion))]
[assembly:System.Runtime.CompilerServices.TypeForwardedToAttribute(typeof(System.Numerics.Vector2))]
[assembly:System.Runtime.CompilerServices.TypeForwardedToAttribute(typeof(System.Numerics.Vector3))]
[assembly:System.Runtime.CompilerServices.TypeForwardedToAttribute(typeof(System.Numerics.Vector4))]
namespace System.Numerics
{
    public static partial class Vector
    {
        public static bool IsHardwareAccelerated { get { throw null; } }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]public static System.Numerics.Vector<T> Abs<T>(System.Numerics.Vector<T> value) where T : struct { throw null; }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]public static System.Numerics.Vector<T> Add<T>(System.Numerics.Vector<T> left, System.Numerics.Vector<T> right) where T : struct { throw null; }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]public static System.Numerics.Vector<T> AndNot<T>(System.Numerics.Vector<T> left, System.Numerics.Vector<T> right) where T : struct { throw null; }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]public static System.Numerics.Vector<System.Byte> AsVectorByte<T>(System.Numerics.Vector<T> value) where T : struct { throw null; }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]public static System.Numerics.Vector<System.Double> AsVectorDouble<T>(System.Numerics.Vector<T> value) where T : struct { throw null; }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]public static System.Numerics.Vector<System.Int16> AsVectorInt16<T>(System.Numerics.Vector<T> value) where T : struct { throw null; }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]public static System.Numerics.Vector<System.Int32> AsVectorInt32<T>(System.Numerics.Vector<T> value) where T : struct { throw null; }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]public static System.Numerics.Vector<System.Int64> AsVectorInt64<T>(System.Numerics.Vector<T> value) where T : struct { throw null; }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)][System.CLSCompliantAttribute(false)]
        public static System.Numerics.Vector<System.SByte> AsVectorSByte<T>(System.Numerics.Vector<T> value) where T : struct { throw null; }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]public static System.Numerics.Vector<System.Single> AsVectorSingle<T>(System.Numerics.Vector<T> value) where T : struct { throw null; }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)][System.CLSCompliantAttribute(false)]
        public static System.Numerics.Vector<System.UInt16> AsVectorUInt16<T>(System.Numerics.Vector<T> value) where T : struct { throw null; }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)][System.CLSCompliantAttribute(false)]
        public static System.Numerics.Vector<System.UInt32> AsVectorUInt32<T>(System.Numerics.Vector<T> value) where T : struct { throw null; }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)][System.CLSCompliantAttribute(false)]
        public static System.Numerics.Vector<System.UInt64> AsVectorUInt64<T>(System.Numerics.Vector<T> value) where T : struct { throw null; }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]public static System.Numerics.Vector<T> BitwiseAnd<T>(System.Numerics.Vector<T> left, System.Numerics.Vector<T> right) where T : struct { throw null; }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]public static System.Numerics.Vector<T> BitwiseOr<T>(System.Numerics.Vector<T> left, System.Numerics.Vector<T> right) where T : struct { throw null; }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]public static System.Numerics.Vector<System.Single> ConditionalSelect(System.Numerics.Vector<System.Int32> condition, System.Numerics.Vector<System.Single> left, System.Numerics.Vector<System.Single> right) { throw null; }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]public static System.Numerics.Vector<System.Double> ConditionalSelect(System.Numerics.Vector<System.Int64> condition, System.Numerics.Vector<System.Double> left, System.Numerics.Vector<System.Double> right) { throw null; }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]public static System.Numerics.Vector<T> ConditionalSelect<T>(System.Numerics.Vector<T> condition, System.Numerics.Vector<T> left, System.Numerics.Vector<T> right) where T : struct { throw null; }
        public static System.Numerics.Vector<System.Double> ConvertToDouble(System.Numerics.Vector<System.Int64> value) { throw null; }
        [System.CLSCompliantAttribute(false)]
        public static System.Numerics.Vector<System.Double> ConvertToDouble(System.Numerics.Vector<System.UInt64> value) { throw null; }
        public static System.Numerics.Vector<System.Int32> ConvertToInt32(System.Numerics.Vector<System.Single> value) { throw null; }
        public static System.Numerics.Vector<System.Int64> ConvertToInt64(System.Numerics.Vector<System.Double> value) { throw null; }
        public static System.Numerics.Vector<System.Single> ConvertToSingle(System.Numerics.Vector<System.Int32> value) { throw null; }
        [System.CLSCompliantAttribute(false)]
        public static System.Numerics.Vector<System.Single> ConvertToSingle(System.Numerics.Vector<System.UInt32> value) { throw null; }
        [System.CLSCompliantAttribute(false)]
        public static System.Numerics.Vector<System.UInt32> ConvertToUInt32(System.Numerics.Vector<System.Single> value) { throw null; }
        [System.CLSCompliantAttribute(false)]
        public static System.Numerics.Vector<System.UInt64> ConvertToUInt64(System.Numerics.Vector<System.Double> value) { throw null; }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]public static System.Numerics.Vector<T> Divide<T>(System.Numerics.Vector<T> left, System.Numerics.Vector<T> right) where T : struct { throw null; }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]public static T Dot<T>(System.Numerics.Vector<T> left, System.Numerics.Vector<T> right) where T : struct { throw null; }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]public static System.Numerics.Vector<System.Int64> Equals(System.Numerics.Vector<System.Double> left, System.Numerics.Vector<System.Double> right) { throw null; }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]public static System.Numerics.Vector<System.Int32> Equals(System.Numerics.Vector<System.Int32> left, System.Numerics.Vector<System.Int32> right) { throw null; }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]public static System.Numerics.Vector<System.Int64> Equals(System.Numerics.Vector<System.Int64> left, System.Numerics.Vector<System.Int64> right) { throw null; }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]public static System.Numerics.Vector<System.Int32> Equals(System.Numerics.Vector<System.Single> left, System.Numerics.Vector<System.Single> right) { throw null; }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]public static bool EqualsAll<T>(System.Numerics.Vector<T> left, System.Numerics.Vector<T> right) where T : struct { throw null; }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]public static bool EqualsAny<T>(System.Numerics.Vector<T> left, System.Numerics.Vector<T> right) where T : struct { throw null; }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]public static System.Numerics.Vector<T> Equals<T>(System.Numerics.Vector<T> left, System.Numerics.Vector<T> right) where T : struct { throw null; }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]public static System.Numerics.Vector<System.Int64> GreaterThan(System.Numerics.Vector<System.Double> left, System.Numerics.Vector<System.Double> right) { throw null; }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]public static System.Numerics.Vector<System.Int32> GreaterThan(System.Numerics.Vector<System.Int32> left, System.Numerics.Vector<System.Int32> right) { throw null; }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]public static System.Numerics.Vector<System.Int64> GreaterThan(System.Numerics.Vector<System.Int64> left, System.Numerics.Vector<System.Int64> right) { throw null; }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]public static System.Numerics.Vector<System.Int32> GreaterThan(System.Numerics.Vector<System.Single> left, System.Numerics.Vector<System.Single> right) { throw null; }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]public static bool GreaterThanAll<T>(System.Numerics.Vector<T> left, System.Numerics.Vector<T> right) where T : struct { throw null; }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]public static bool GreaterThanAny<T>(System.Numerics.Vector<T> left, System.Numerics.Vector<T> right) where T : struct { throw null; }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]public static System.Numerics.Vector<System.Int64> GreaterThanOrEqual(System.Numerics.Vector<System.Double> left, System.Numerics.Vector<System.Double> right) { throw null; }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]public static System.Numerics.Vector<System.Int32> GreaterThanOrEqual(System.Numerics.Vector<System.Int32> left, System.Numerics.Vector<System.Int32> right) { throw null; }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]public static System.Numerics.Vector<System.Int64> GreaterThanOrEqual(System.Numerics.Vector<System.Int64> left, System.Numerics.Vector<System.Int64> right) { throw null; }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]public static System.Numerics.Vector<System.Int32> GreaterThanOrEqual(System.Numerics.Vector<System.Single> left, System.Numerics.Vector<System.Single> right) { throw null; }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]public static bool GreaterThanOrEqualAll<T>(System.Numerics.Vector<T> left, System.Numerics.Vector<T> right) where T : struct { throw null; }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]public static bool GreaterThanOrEqualAny<T>(System.Numerics.Vector<T> left, System.Numerics.Vector<T> right) where T : struct { throw null; }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]public static System.Numerics.Vector<T> GreaterThanOrEqual<T>(System.Numerics.Vector<T> left, System.Numerics.Vector<T> right) where T : struct { throw null; }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]public static System.Numerics.Vector<T> GreaterThan<T>(System.Numerics.Vector<T> left, System.Numerics.Vector<T> right) where T : struct { throw null; }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]public static System.Numerics.Vector<System.Int64> LessThan(System.Numerics.Vector<System.Double> left, System.Numerics.Vector<System.Double> right) { throw null; }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]public static System.Numerics.Vector<System.Int32> LessThan(System.Numerics.Vector<System.Int32> left, System.Numerics.Vector<System.Int32> right) { throw null; }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]public static System.Numerics.Vector<System.Int64> LessThan(System.Numerics.Vector<System.Int64> left, System.Numerics.Vector<System.Int64> right) { throw null; }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]public static System.Numerics.Vector<System.Int32> LessThan(System.Numerics.Vector<System.Single> left, System.Numerics.Vector<System.Single> right) { throw null; }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]public static bool LessThanAll<T>(System.Numerics.Vector<T> left, System.Numerics.Vector<T> right) where T : struct { throw null; }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]public static bool LessThanAny<T>(System.Numerics.Vector<T> left, System.Numerics.Vector<T> right) where T : struct { throw null; }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]public static System.Numerics.Vector<System.Int64> LessThanOrEqual(System.Numerics.Vector<System.Double> left, System.Numerics.Vector<System.Double> right) { throw null; }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]public static System.Numerics.Vector<System.Int32> LessThanOrEqual(System.Numerics.Vector<System.Int32> left, System.Numerics.Vector<System.Int32> right) { throw null; }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]public static System.Numerics.Vector<System.Int64> LessThanOrEqual(System.Numerics.Vector<System.Int64> left, System.Numerics.Vector<System.Int64> right) { throw null; }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]public static System.Numerics.Vector<System.Int32> LessThanOrEqual(System.Numerics.Vector<System.Single> left, System.Numerics.Vector<System.Single> right) { throw null; }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]public static bool LessThanOrEqualAll<T>(System.Numerics.Vector<T> left, System.Numerics.Vector<T> right) where T : struct { throw null; }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]public static bool LessThanOrEqualAny<T>(System.Numerics.Vector<T> left, System.Numerics.Vector<T> right) where T : struct { throw null; }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]public static System.Numerics.Vector<T> LessThanOrEqual<T>(System.Numerics.Vector<T> left, System.Numerics.Vector<T> right) where T : struct { throw null; }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]public static System.Numerics.Vector<T> LessThan<T>(System.Numerics.Vector<T> left, System.Numerics.Vector<T> right) where T : struct { throw null; }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]public static System.Numerics.Vector<T> Max<T>(System.Numerics.Vector<T> left, System.Numerics.Vector<T> right) where T : struct { throw null; }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]public static System.Numerics.Vector<T> Min<T>(System.Numerics.Vector<T> left, System.Numerics.Vector<T> right) where T : struct { throw null; }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]public static System.Numerics.Vector<T> Multiply<T>(System.Numerics.Vector<T> left, System.Numerics.Vector<T> right) where T : struct { throw null; }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]public static System.Numerics.Vector<T> Multiply<T>(System.Numerics.Vector<T> left, T right) where T : struct { throw null; }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]public static System.Numerics.Vector<T> Multiply<T>(T left, System.Numerics.Vector<T> right) where T : struct { throw null; }
        public static System.Numerics.Vector<System.Single> Narrow(System.Numerics.Vector<System.Double> low, System.Numerics.Vector<System.Double> high) { throw null; }
        [System.CLSCompliantAttribute(false)]
        public static System.Numerics.Vector<System.SByte> Narrow(System.Numerics.Vector<System.Int16> low, System.Numerics.Vector<System.Int16> high) { throw null; }
        public static System.Numerics.Vector<System.Int16> Narrow(System.Numerics.Vector<System.Int32> low, System.Numerics.Vector<System.Int32> high) { throw null; }
        public static System.Numerics.Vector<System.Int32> Narrow(System.Numerics.Vector<System.Int64> low, System.Numerics.Vector<System.Int64> high) { throw null; }
        [System.CLSCompliantAttribute(false)]
        public static System.Numerics.Vector<System.Byte> Narrow(System.Numerics.Vector<System.UInt16> low, System.Numerics.Vector<System.UInt16> high) { throw null; }
        [System.CLSCompliantAttribute(false)]
        public static System.Numerics.Vector<System.UInt16> Narrow(System.Numerics.Vector<System.UInt32> low, System.Numerics.Vector<System.UInt32> high) { throw null; }
        [System.CLSCompliantAttribute(false)]
        public static System.Numerics.Vector<System.UInt32> Narrow(System.Numerics.Vector<System.UInt64> low, System.Numerics.Vector<System.UInt64> high) { throw null; }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]public static System.Numerics.Vector<T> Negate<T>(System.Numerics.Vector<T> value) where T : struct { throw null; }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]public static System.Numerics.Vector<T> OnesComplement<T>(System.Numerics.Vector<T> value) where T : struct { throw null; }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]public static System.Numerics.Vector<T> SquareRoot<T>(System.Numerics.Vector<T> value) where T : struct { throw null; }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]public static System.Numerics.Vector<T> Subtract<T>(System.Numerics.Vector<T> left, System.Numerics.Vector<T> right) where T : struct { throw null; }
        [System.CLSCompliantAttribute(false)]
        public static void Widen(System.Numerics.Vector<System.Byte> source, out System.Numerics.Vector<System.UInt16> low, out System.Numerics.Vector<System.UInt16> high) { low = default(System.Numerics.Vector<ushort>); high = default(System.Numerics.Vector<ushort>); }
        public static void Widen(System.Numerics.Vector<System.Int16> source, out System.Numerics.Vector<System.Int32> low, out System.Numerics.Vector<System.Int32> high) { low = default(System.Numerics.Vector<int>); high = default(System.Numerics.Vector<int>); }
        public static void Widen(System.Numerics.Vector<System.Int32> source, out System.Numerics.Vector<System.Int64> low, out System.Numerics.Vector<System.Int64> high) { low = default(System.Numerics.Vector<long>); high = default(System.Numerics.Vector<long>); }
        [System.CLSCompliantAttribute(false)]
        public static void Widen(System.Numerics.Vector<System.SByte> source, out System.Numerics.Vector<System.Int16> low, out System.Numerics.Vector<System.Int16> high) { low = default(System.Numerics.Vector<short>); high = default(System.Numerics.Vector<short>); }
        public static void Widen(System.Numerics.Vector<System.Single> source, out System.Numerics.Vector<System.Double> low, out System.Numerics.Vector<System.Double> high) { low = default(System.Numerics.Vector<double>); high = default(System.Numerics.Vector<double>); }
        [System.CLSCompliantAttribute(false)]
        public static void Widen(System.Numerics.Vector<System.UInt16> source, out System.Numerics.Vector<System.UInt32> low, out System.Numerics.Vector<System.UInt32> high) { low = default(System.Numerics.Vector<uint>); high = default(System.Numerics.Vector<uint>); }
        [System.CLSCompliantAttribute(false)]
        public static void Widen(System.Numerics.Vector<System.UInt32> source, out System.Numerics.Vector<System.UInt64> low, out System.Numerics.Vector<System.UInt64> high) { low = default(System.Numerics.Vector<ulong>); high = default(System.Numerics.Vector<ulong>); }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]public static System.Numerics.Vector<T> Xor<T>(System.Numerics.Vector<T> left, System.Numerics.Vector<T> right) where T : struct { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public partial struct Vector<T> : System.IEquatable<System.Numerics.Vector<T>>, System.IFormattable where T : struct
    {
        public Vector(T value) { throw null;}
        public Vector(T[] values) { throw null;}
        public Vector(T[] values, int index) { throw null;}
        public static int Count { get { throw null; } }
        public T this[int index] { get { throw null; } }
        public static System.Numerics.Vector<T> One { get { throw null; } }
        public static System.Numerics.Vector<T> Zero { get { throw null; } }
        public void CopyTo(T[] destination) { }
        public void CopyTo(T[] destination, int startIndex) { }
        public bool Equals(System.Numerics.Vector<T> other) { throw null; }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]public override bool Equals(object obj) { throw null; }
        public override int GetHashCode() { throw null; }
        public static System.Numerics.Vector<T> operator +(System.Numerics.Vector<T> left, System.Numerics.Vector<T> right) { throw null; }
        public static System.Numerics.Vector<T> operator &(System.Numerics.Vector<T> left, System.Numerics.Vector<T> right) { throw null; }
        public static System.Numerics.Vector<T> operator |(System.Numerics.Vector<T> left, System.Numerics.Vector<T> right) { throw null; }
        public static System.Numerics.Vector<T> operator /(System.Numerics.Vector<T> left, System.Numerics.Vector<T> right) { throw null; }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]public static bool operator ==(System.Numerics.Vector<T> left, System.Numerics.Vector<T> right) { throw null; }
        public static System.Numerics.Vector<T> operator ^(System.Numerics.Vector<T> left, System.Numerics.Vector<T> right) { throw null; }
        public static explicit operator System.Numerics.Vector<System.Byte> (System.Numerics.Vector<T> value) { throw null; }
        public static explicit operator System.Numerics.Vector<System.Double> (System.Numerics.Vector<T> value) { throw null; }
        public static explicit operator System.Numerics.Vector<System.Int16> (System.Numerics.Vector<T> value) { throw null; }
        public static explicit operator System.Numerics.Vector<System.Int32> (System.Numerics.Vector<T> value) { throw null; }
        public static explicit operator System.Numerics.Vector<System.Int64> (System.Numerics.Vector<T> value) { throw null; }
        [System.CLSCompliantAttribute(false)]
        public static explicit operator System.Numerics.Vector<System.SByte> (System.Numerics.Vector<T> value) { throw null; }
        public static explicit operator System.Numerics.Vector<System.Single> (System.Numerics.Vector<T> value) { throw null; }
        [System.CLSCompliantAttribute(false)]
        public static explicit operator System.Numerics.Vector<System.UInt16> (System.Numerics.Vector<T> value) { throw null; }
        [System.CLSCompliantAttribute(false)]
        public static explicit operator System.Numerics.Vector<System.UInt32> (System.Numerics.Vector<T> value) { throw null; }
        [System.CLSCompliantAttribute(false)]
        public static explicit operator System.Numerics.Vector<System.UInt64> (System.Numerics.Vector<T> value) { throw null; }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]public static bool operator !=(System.Numerics.Vector<T> left, System.Numerics.Vector<T> right) { throw null; }
        public static System.Numerics.Vector<T> operator *(System.Numerics.Vector<T> left, System.Numerics.Vector<T> right) { throw null; }
        public static System.Numerics.Vector<T> operator *(System.Numerics.Vector<T> value, T factor) { throw null; }
        public static System.Numerics.Vector<T> operator *(T factor, System.Numerics.Vector<T> value) { throw null; }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]public static System.Numerics.Vector<T> operator ~(System.Numerics.Vector<T> value) { throw null; }
        public static System.Numerics.Vector<T> operator -(System.Numerics.Vector<T> left, System.Numerics.Vector<T> right) { throw null; }
        public static System.Numerics.Vector<T> operator -(System.Numerics.Vector<T> value) { throw null; }
        public override string ToString() { throw null; }
        public string ToString(string format) { throw null; }
        public string ToString(string format, System.IFormatProvider formatProvider) { throw null; }
    }
}
