// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

[assembly:System.Reflection.AssemblyVersionAttribute("2.0.0.0")]
[assembly:System.Diagnostics.DebuggableAttribute((System.Diagnostics.DebuggableAttribute.DebuggingModes)(2))]
[assembly:System.Runtime.CompilerServices.RuntimeCompatibilityAttribute(WrapNonExceptionThrows=true)]
[assembly:System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.RequestMinimum, SkipVerification=true)]
namespace I18N.Common
{
    [System.SerializableAttribute]
    public abstract partial class ByteEncoding : I18N.Common.MonoEncoding
    {
        protected string bodyName;
        protected string encodingName;
        protected string headerName;
        protected bool isBrowserDisplay;
        protected bool isBrowserSave;
        protected bool isMailNewsDisplay;
        protected bool isMailNewsSave;
        protected char[] toChars;
        protected string webName;
        protected int windowsCodePage;
        protected ByteEncoding(int codePage, char[] toChars, string encodingName, string bodyName, string headerName, string webName, bool isBrowserDisplay, bool isBrowserSave, bool isMailNewsDisplay, bool isMailNewsSave, int windowsCodePage) : base (default(int)) { }
        public override string BodyName { get { throw null; } }
        public override string EncodingName { get { throw null; } }
        public override string HeaderName { get { throw null; } }
        public override bool IsBrowserDisplay { get { throw null; } }
        public override bool IsBrowserSave { get { throw null; } }
        public override bool IsMailNewsDisplay { get { throw null; } }
        public override bool IsMailNewsSave { get { throw null; } }
        public override bool IsSingleByte { get { throw null; } }
        public override string WebName { get { throw null; } }
        public override int WindowsCodePage { get { throw null; } }
        public override int GetByteCount(string s) { throw null; }
        public unsafe override int GetByteCountImpl(char* chars, int count) { throw null; }
        public unsafe override int GetBytesImpl(char* chars, int charCount, byte* bytes, int byteCount) { throw null; }
        public override int GetCharCount(byte[] bytes, int index, int count) { throw null; }
        public override int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex) { throw null; }
        public override int GetMaxByteCount(int charCount) { throw null; }
        public override int GetMaxCharCount(int byteCount) { throw null; }
        public override string GetString(byte[] bytes) { throw null; }
        public override string GetString(byte[] bytes, int index, int count) { throw null; }
        public override bool IsAlwaysNormalized(System.Text.NormalizationForm form) { throw null; }
        protected unsafe abstract void ToBytes(char* chars, int charCount, byte* bytes, int byteCount);
        protected virtual void ToBytes(char[] chars, int charIndex, int charCount, byte[] bytes, int byteIndex) { }
    }
    [System.SerializableAttribute]
    public abstract partial class ByteSafeEncoding : I18N.Common.MonoSafeEncoding
    {
        protected string bodyName;
        protected string encodingName;
        protected string headerName;
        protected bool isBrowserDisplay;
        protected bool isBrowserSave;
        protected bool isMailNewsDisplay;
        protected bool isMailNewsSave;
        protected char[] toChars;
        protected string webName;
        protected int windowsCodePage;
        protected ByteSafeEncoding(int codePage, char[] toChars, string encodingName, string bodyName, string headerName, string webName, bool isBrowserDisplay, bool isBrowserSave, bool isMailNewsDisplay, bool isMailNewsSave, int windowsCodePage) : base (default(int)) { }
        public override string BodyName { get { throw null; } }
        public override string EncodingName { get { throw null; } }
        public override string HeaderName { get { throw null; } }
        public override bool IsBrowserDisplay { get { throw null; } }
        public override bool IsBrowserSave { get { throw null; } }
        public override bool IsMailNewsDisplay { get { throw null; } }
        public override bool IsMailNewsSave { get { throw null; } }
        public override bool IsSingleByte { get { throw null; } }
        public override string WebName { get { throw null; } }
        public override int WindowsCodePage { get { throw null; } }
        public unsafe override int GetByteCount(char* chars, int count) { throw null; }
        public override int GetByteCount(char[] chars, int index, int count) { throw null; }
        public override int GetByteCount(string s) { throw null; }
        public override int GetBytes(char[] chars, int charIndex, int charCount, byte[] bytes, int byteIndex) { throw null; }
        public override byte[] GetBytes(string s) { throw null; }
        public override int GetBytes(string s, int charIndex, int charCount, byte[] bytes, int byteIndex) { throw null; }
        public override int GetCharCount(byte[] bytes, int index, int count) { throw null; }
        public override int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex) { throw null; }
        public override int GetMaxByteCount(int charCount) { throw null; }
        public override int GetMaxCharCount(int byteCount) { throw null; }
        public override string GetString(byte[] bytes) { throw null; }
        public override string GetString(byte[] bytes, int index, int count) { throw null; }
        public override bool IsAlwaysNormalized(System.Text.NormalizationForm form) { throw null; }
        protected abstract void ToBytes(char[] chars, int charIndex, int charCount, byte[] bytes, int byteIndex);
        protected virtual void ToBytes(string s, int charIndex, int charCount, byte[] bytes, int byteIndex) { }
    }
    public sealed partial class Handlers
    {
        public static readonly string[] List;
        public Handlers() { }
        public static string GetAlias(string name) { throw null; }
    }
    public partial class Manager
    {
        internal Manager() { }
        public static I18N.Common.Manager PrimaryManager { get { throw null; } }
        public System.Globalization.CultureInfo GetCulture(int culture, bool useUserOverride) { throw null; }
        public System.Globalization.CultureInfo GetCulture(string name, bool useUserOverride) { throw null; }
        public System.Text.Encoding GetEncoding(int codePage) { throw null; }
        public System.Text.Encoding GetEncoding(string name) { throw null; }
    }
    public abstract partial class MonoEncoder : System.Text.Encoder
    {
        public MonoEncoder(I18N.Common.MonoEncoding encoding) { }
        public override int GetByteCount(char[] chars, int index, int count, bool refresh) { throw null; }
        public unsafe abstract int GetByteCountImpl(char* chars, int charCount, bool refresh);
        public unsafe override int GetBytes(char* chars, int charCount, byte* bytes, int byteCount, bool flush) { throw null; }
        public override int GetBytes(char[] chars, int charIndex, int charCount, byte[] bytes, int byteIndex, bool flush) { throw null; }
        public unsafe abstract int GetBytesImpl(char* chars, int charCount, byte* bytes, int byteCount, bool refresh);
        public unsafe void HandleFallback(char* chars, ref int charIndex, ref int charCount, byte* bytes, ref int byteIndex, ref int byteCount, object state) { }
    }
    [System.SerializableAttribute]
    public abstract partial class MonoEncoding : System.Text.Encoding
    {
        public MonoEncoding(int codePage) { }
        public MonoEncoding(int codePage, int windowsCodePage) { }
        public override int WindowsCodePage { get { throw null; } }
        public unsafe override int GetByteCount(char* chars, int count) { throw null; }
        public override int GetByteCount(char[] chars, int index, int count) { throw null; }
        public unsafe abstract int GetByteCountImpl(char* chars, int charCount);
        public unsafe override int GetBytes(char* chars, int charCount, byte* bytes, int byteCount) { throw null; }
        public override int GetBytes(char[] chars, int charIndex, int charCount, byte[] bytes, int byteIndex) { throw null; }
        public override int GetBytes(string s, int charIndex, int charCount, byte[] bytes, int byteIndex) { throw null; }
        public unsafe abstract int GetBytesImpl(char* chars, int charCount, byte* bytes, int byteCount);
        protected unsafe virtual int GetBytesInternal(char* chars, int charCount, byte* bytes, int byteCount, bool flush, object state) { throw null; }
        public unsafe void HandleFallback(ref System.Text.EncoderFallbackBuffer buffer, char* chars, ref int charIndex, ref int charCount, byte* bytes, ref int byteIndex, ref int byteCount) { }
        public unsafe void HandleFallback(ref System.Text.EncoderFallbackBuffer buffer, char* chars, ref int charIndex, ref int charCount, byte* bytes, ref int byteIndex, ref int byteCount, object state) { }
    }
    public abstract partial class MonoSafeEncoder : System.Text.Encoder
    {
        public MonoSafeEncoder(I18N.Common.MonoSafeEncoding encoding) { }
        public void HandleFallback(char[] chars, ref int charIndex, ref int charCount, byte[] bytes, ref int byteIndex, ref int byteCount, object state) { }
    }
    [System.SerializableAttribute]
    public abstract partial class MonoSafeEncoding : System.Text.Encoding
    {
        public MonoSafeEncoding(int codePage) { }
        public MonoSafeEncoding(int codePage, int windowsCodePage) { }
        public override int WindowsCodePage { get { throw null; } }
        protected virtual int GetBytesInternal(char[] chars, int charIndex, int charCount, byte[] bytes, int byteIndex, bool flush, object state) { throw null; }
        public void HandleFallback(ref System.Text.EncoderFallbackBuffer buffer, char[] chars, ref int charIndex, ref int charCount, byte[] bytes, ref int byteIndex, ref int byteCount, object state) { }
    }
    public sealed partial class Strings
    {
        public Strings() { }
        public static string GetString(string tag) { throw null; }
    }
}
