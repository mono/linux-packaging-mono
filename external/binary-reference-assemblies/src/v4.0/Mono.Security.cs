// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

[assembly:System.Reflection.AssemblyVersionAttribute("4.0.0.0")]
[assembly:System.CLSCompliantAttribute(true)]
[assembly:System.Reflection.AssemblyCompanyAttribute("MONO development team")]
[assembly:System.Reflection.AssemblyCopyrightAttribute("(c) 2003-2004 Various Authors")]
[assembly:System.Reflection.AssemblyDescriptionAttribute("Mono.Security.dll")]
[assembly:System.Reflection.AssemblyProductAttribute("MONO CLI")]
[assembly:System.Reflection.AssemblyTitleAttribute("Mono.Security.dll")]
[assembly:System.Resources.NeutralResourcesLanguageAttribute("en-US")]
[assembly:System.Runtime.CompilerServices.ReferenceAssemblyAttribute]
[assembly:System.Runtime.CompilerServices.RuntimeCompatibilityAttribute(WrapNonExceptionThrows=true)]
[assembly:System.Runtime.InteropServices.ComVisibleAttribute(false)]
[assembly:System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.RequestMinimum, SkipVerification=true)]
namespace Mono.Math
{
    public partial class BigInteger
    {
        public BigInteger() { }
        public BigInteger(Mono.Math.BigInteger bi) { }
        [System.CLSCompliantAttribute(false)]
        public BigInteger(Mono.Math.BigInteger bi, uint len) { }
        [System.CLSCompliantAttribute(false)]
        public BigInteger(Mono.Math.BigInteger.Sign sign, uint len) { }
        public BigInteger(byte[] inData) { }
        [System.CLSCompliantAttribute(false)]
        public BigInteger(uint ui) { }
        [System.CLSCompliantAttribute(false)]
        public BigInteger(uint[] inData) { }
        [System.CLSCompliantAttribute(false)]
        public BigInteger(ulong ul) { }
        public static Mono.Math.BigInteger Add(Mono.Math.BigInteger bi1, Mono.Math.BigInteger bi2) { throw null; }
        public int BitCount() { throw null; }
        public void Clear() { }
        [System.CLSCompliantAttribute(false)]
        public void ClearBit(uint bitNum) { }
        public Mono.Math.BigInteger.Sign Compare(Mono.Math.BigInteger bi) { throw null; }
        public static Mono.Math.BigInteger Divid(Mono.Math.BigInteger bi1, Mono.Math.BigInteger bi2) { throw null; }
        public static Mono.Math.BigInteger Divid(Mono.Math.BigInteger bi, int i) { throw null; }
        public override bool Equals(object o) { throw null; }
        public Mono.Math.BigInteger GCD(Mono.Math.BigInteger bi) { throw null; }
        public static Mono.Math.BigInteger GeneratePseudoPrime(int bits) { throw null; }
        public static Mono.Math.BigInteger GenerateRandom(int bits) { throw null; }
        public static Mono.Math.BigInteger GenerateRandom(int bits, System.Security.Cryptography.RandomNumberGenerator rng) { throw null; }
        public byte[] GetBytes() { throw null; }
        public override int GetHashCode() { throw null; }
        public void Incr2() { }
        public bool IsProbablePrime() { throw null; }
        public int LowestSetBit() { throw null; }
        public Mono.Math.BigInteger ModInverse(Mono.Math.BigInteger modulus) { throw null; }
        public Mono.Math.BigInteger ModPow(Mono.Math.BigInteger exp, Mono.Math.BigInteger n) { throw null; }
        public static Mono.Math.BigInteger Modulus(Mono.Math.BigInteger bi1, Mono.Math.BigInteger bi2) { throw null; }
        public static int Modulus(Mono.Math.BigInteger bi, int i) { throw null; }
        [System.CLSCompliantAttribute(false)]
        public static uint Modulus(Mono.Math.BigInteger bi, uint ui) { throw null; }
        public static Mono.Math.BigInteger Multiply(Mono.Math.BigInteger bi1, Mono.Math.BigInteger bi2) { throw null; }
        public static Mono.Math.BigInteger Multiply(Mono.Math.BigInteger bi, int i) { throw null; }
        public static Mono.Math.BigInteger NextHighestPrime(Mono.Math.BigInteger bi) { throw null; }
        public static Mono.Math.BigInteger operator +(Mono.Math.BigInteger bi1, Mono.Math.BigInteger bi2) { throw null; }
        public static Mono.Math.BigInteger operator /(Mono.Math.BigInteger bi1, Mono.Math.BigInteger bi2) { throw null; }
        public static Mono.Math.BigInteger operator /(Mono.Math.BigInteger bi, int i) { throw null; }
        public static bool operator ==(Mono.Math.BigInteger bi1, Mono.Math.BigInteger bi2) { throw null; }
        [System.CLSCompliantAttribute(false)]
        public static bool operator ==(Mono.Math.BigInteger bi1, uint ui) { throw null; }
        public static bool operator >(Mono.Math.BigInteger bi1, Mono.Math.BigInteger bi2) { throw null; }
        public static bool operator >=(Mono.Math.BigInteger bi1, Mono.Math.BigInteger bi2) { throw null; }
        public static implicit operator Mono.Math.BigInteger (int value) { throw null; }
        [System.CLSCompliantAttribute(false)]
        public static implicit operator Mono.Math.BigInteger (uint value) { throw null; }
        [System.CLSCompliantAttribute(false)]
        public static implicit operator Mono.Math.BigInteger (ulong value) { throw null; }
        public static bool operator !=(Mono.Math.BigInteger bi1, Mono.Math.BigInteger bi2) { throw null; }
        [System.CLSCompliantAttribute(false)]
        public static bool operator !=(Mono.Math.BigInteger bi1, uint ui) { throw null; }
        public static Mono.Math.BigInteger operator <<(Mono.Math.BigInteger bi1, int shiftVal) { throw null; }
        public static bool operator <(Mono.Math.BigInteger bi1, Mono.Math.BigInteger bi2) { throw null; }
        public static bool operator <=(Mono.Math.BigInteger bi1, Mono.Math.BigInteger bi2) { throw null; }
        public static Mono.Math.BigInteger operator %(Mono.Math.BigInteger bi1, Mono.Math.BigInteger bi2) { throw null; }
        public static int operator %(Mono.Math.BigInteger bi, int i) { throw null; }
        [System.CLSCompliantAttribute(false)]
        public static uint operator %(Mono.Math.BigInteger bi, uint ui) { throw null; }
        public static Mono.Math.BigInteger operator *(Mono.Math.BigInteger bi1, Mono.Math.BigInteger bi2) { throw null; }
        public static Mono.Math.BigInteger operator *(Mono.Math.BigInteger bi, int i) { throw null; }
        public static Mono.Math.BigInteger operator >>(Mono.Math.BigInteger bi1, int shiftVal) { throw null; }
        public static Mono.Math.BigInteger operator -(Mono.Math.BigInteger bi1, Mono.Math.BigInteger bi2) { throw null; }
        public static Mono.Math.BigInteger Parse(string number) { throw null; }
        public void Randomize() { }
        public void Randomize(System.Security.Cryptography.RandomNumberGenerator rng) { }
        [System.CLSCompliantAttribute(false)]
        public void SetBit(uint bitNum) { }
        [System.CLSCompliantAttribute(false)]
        public void SetBit(uint bitNum, bool value) { }
        public static Mono.Math.BigInteger Subtract(Mono.Math.BigInteger bi1, Mono.Math.BigInteger bi2) { throw null; }
        public bool TestBit(int bitNum) { throw null; }
        [System.CLSCompliantAttribute(false)]
        public bool TestBit(uint bitNum) { throw null; }
        public override string ToString() { throw null; }
        [System.CLSCompliantAttribute(false)]
        public string ToString(uint radix) { throw null; }
        [System.CLSCompliantAttribute(false)]
        public string ToString(uint radix, string characterSet) { throw null; }
        public sealed partial class ModulusRing
        {
            public ModulusRing(Mono.Math.BigInteger modulus) { }
            public void BarrettReduction(Mono.Math.BigInteger x) { }
            public Mono.Math.BigInteger Difference(Mono.Math.BigInteger a, Mono.Math.BigInteger b) { throw null; }
            public Mono.Math.BigInteger Multiply(Mono.Math.BigInteger a, Mono.Math.BigInteger b) { throw null; }
            public Mono.Math.BigInteger Pow(Mono.Math.BigInteger a, Mono.Math.BigInteger k) { throw null; }
            [System.CLSCompliantAttribute(false)]
            public Mono.Math.BigInteger Pow(uint b, Mono.Math.BigInteger exp) { throw null; }
        }
        public enum Sign
        {
            Negative = -1,
            Positive = 1,
            Zero = 0,
        }
    }
}
namespace Mono.Math.Prime
{
    public enum ConfidenceFactor
    {
        ExtraHigh = 4,
        ExtraLow = 0,
        High = 3,
        Low = 1,
        Medium = 2,
        Provable = 5,
    }
    public delegate bool PrimalityTest(Mono.Math.BigInteger bi, Mono.Math.Prime.ConfidenceFactor confidence);
    public sealed partial class PrimalityTests
    {
        internal PrimalityTests() { }
        public static bool RabinMillerTest(Mono.Math.BigInteger n, Mono.Math.Prime.ConfidenceFactor confidence) { throw null; }
        public static bool SmallPrimeSppTest(Mono.Math.BigInteger bi, Mono.Math.Prime.ConfidenceFactor confidence) { throw null; }
        public static bool Test(Mono.Math.BigInteger n, Mono.Math.Prime.ConfidenceFactor confidence) { throw null; }
    }
}
namespace Mono.Math.Prime.Generator
{
    public partial class NextPrimeFinder : Mono.Math.Prime.Generator.SequentialSearchPrimeGeneratorBase
    {
        public NextPrimeFinder() { }
        protected override Mono.Math.BigInteger GenerateSearchBase(int bits, object Context) { throw null; }
    }
    public abstract partial class PrimeGeneratorBase
    {
        protected PrimeGeneratorBase() { }
        public virtual Mono.Math.Prime.ConfidenceFactor Confidence { get { throw null; } }
        public virtual Mono.Math.Prime.PrimalityTest PrimalityTest { get { throw null; } }
        public virtual int TrialDivisionBounds { get { throw null; } }
        public abstract Mono.Math.BigInteger GenerateNewPrime(int bits);
        protected bool PostTrialDivisionTests(Mono.Math.BigInteger bi) { throw null; }
    }
    public partial class SequentialSearchPrimeGeneratorBase : Mono.Math.Prime.Generator.PrimeGeneratorBase
    {
        public SequentialSearchPrimeGeneratorBase() { }
        public override Mono.Math.BigInteger GenerateNewPrime(int bits) { throw null; }
        public virtual Mono.Math.BigInteger GenerateNewPrime(int bits, object context) { throw null; }
        protected virtual Mono.Math.BigInteger GenerateSearchBase(int bits, object context) { throw null; }
        protected virtual bool IsPrimeAcceptable(Mono.Math.BigInteger bi, object context) { throw null; }
    }
}
namespace Mono.Security
{
    public partial class ASN1
    {
        public ASN1() { }
        public ASN1(byte tag) { }
        public ASN1(byte tag, byte[] data) { }
        public ASN1(byte[] data) { }
        public int Count { get { throw null; } }
        public Mono.Security.ASN1 this[int index] { get { throw null; } }
        public int Length { get { throw null; } }
        public byte Tag { get { throw null; } }
        public byte[] Value { get { throw null; } set { } }
        public Mono.Security.ASN1 Add(Mono.Security.ASN1 asn1) { throw null; }
        public bool CompareValue(byte[] value) { throw null; }
        protected void Decode(byte[] asn1, ref int anPos, int anLength) { }
        protected void DecodeTLV(byte[] asn1, ref int pos, out byte tag, out int length, out byte[] content) { tag = default(byte); length = default(int); content = default(byte[]); }
        public Mono.Security.ASN1 Element(int index, byte anTag) { throw null; }
        public bool Equals(byte[] asn1) { throw null; }
        public virtual byte[] GetBytes() { throw null; }
        public void SaveToFile(string filename) { }
        public override string ToString() { throw null; }
    }
    public static partial class ASN1Convert
    {
        public static Mono.Security.ASN1 FromDateTime(System.DateTime dt) { throw null; }
        public static Mono.Security.ASN1 FromInt32(int value) { throw null; }
        public static Mono.Security.ASN1 FromOid(string oid) { throw null; }
        public static Mono.Security.ASN1 FromUnsignedBigInteger(byte[] big) { throw null; }
        public static System.DateTime ToDateTime(Mono.Security.ASN1 time) { throw null; }
        public static int ToInt32(Mono.Security.ASN1 asn1) { throw null; }
        public static string ToOid(Mono.Security.ASN1 asn1) { throw null; }
    }
    public sealed partial class PKCS7
    {
        internal PKCS7() { }
        public static Mono.Security.ASN1 AlgorithmIdentifier(string oid) { throw null; }
        public static Mono.Security.ASN1 AlgorithmIdentifier(string oid, Mono.Security.ASN1 parameters) { throw null; }
        public static Mono.Security.ASN1 Attribute(string oid, Mono.Security.ASN1 value) { throw null; }
        public static Mono.Security.ASN1 IssuerAndSerialNumber(Mono.Security.X509.X509Certificate x509) { throw null; }
        public partial class ContentInfo
        {
            public ContentInfo() { }
            public ContentInfo(Mono.Security.ASN1 asn1) { }
            public ContentInfo(byte[] data) { }
            public ContentInfo(string oid) { }
            public Mono.Security.ASN1 ASN1 { get { throw null; } }
            public Mono.Security.ASN1 Content { get { throw null; } set { } }
            public string ContentType { get { throw null; } set { } }
            public byte[] GetBytes() { throw null; }
        }
        public partial class EncryptedData
        {
            public EncryptedData() { }
            public EncryptedData(Mono.Security.ASN1 asn1) { }
            public EncryptedData(byte[] data) { }
            public Mono.Security.ASN1 ASN1 { get { throw null; } }
            public Mono.Security.PKCS7.ContentInfo ContentInfo { get { throw null; } }
            public byte[] EncryptedContent { get { throw null; } }
            public Mono.Security.PKCS7.ContentInfo EncryptionAlgorithm { get { throw null; } }
            public byte Version { get { throw null; } set { } }
            public byte[] GetBytes() { throw null; }
        }
        public partial class EnvelopedData
        {
            public EnvelopedData() { }
            public EnvelopedData(Mono.Security.ASN1 asn1) { }
            public EnvelopedData(byte[] data) { }
            public Mono.Security.ASN1 ASN1 { get { throw null; } }
            public Mono.Security.PKCS7.ContentInfo ContentInfo { get { throw null; } }
            public byte[] EncryptedContent { get { throw null; } }
            public Mono.Security.PKCS7.ContentInfo EncryptionAlgorithm { get { throw null; } }
            public System.Collections.ArrayList RecipientInfos { get { throw null; } }
            public byte Version { get { throw null; } set { } }
            public byte[] GetBytes() { throw null; }
        }
        public partial class Oid
        {
            public const string contentType = "1.2.840.113549.1.9.3";
            public const string countersignature = "1.2.840.113549.1.9.6";
            public const string data = "1.2.840.113549.1.7.1";
            public const string digestedData = "1.2.840.113549.1.7.5";
            public const string encryptedData = "1.2.840.113549.1.7.6";
            public const string envelopedData = "1.2.840.113549.1.7.3";
            public const string messageDigest = "1.2.840.113549.1.9.4";
            public const string rsaEncryption = "1.2.840.113549.1.1.1";
            public const string signedAndEnvelopedData = "1.2.840.113549.1.7.4";
            public const string signedData = "1.2.840.113549.1.7.2";
            public const string signingTime = "1.2.840.113549.1.9.5";
            public Oid() { }
        }
        public partial class RecipientInfo
        {
            public RecipientInfo() { }
            public RecipientInfo(Mono.Security.ASN1 data) { }
            public string Issuer { get { throw null; } }
            public byte[] Key { get { throw null; } }
            public string Oid { get { throw null; } }
            public byte[] Serial { get { throw null; } }
            public byte[] SubjectKeyIdentifier { get { throw null; } }
            public int Version { get { throw null; } }
        }
        public partial class SignedData
        {
            public SignedData() { }
            public SignedData(Mono.Security.ASN1 asn1) { }
            public SignedData(byte[] data) { }
            public Mono.Security.ASN1 ASN1 { get { throw null; } }
            public Mono.Security.X509.X509CertificateCollection Certificates { get { throw null; } }
            public Mono.Security.PKCS7.ContentInfo ContentInfo { get { throw null; } }
            public System.Collections.ArrayList Crls { get { throw null; } }
            public string HashName { get { throw null; } set { } }
            public Mono.Security.PKCS7.SignerInfo SignerInfo { get { throw null; } }
            public bool UseAuthenticatedAttributes { get { throw null; } set { } }
            public byte Version { get { throw null; } set { } }
            public byte[] GetBytes() { throw null; }
            public bool VerifySignature(System.Security.Cryptography.AsymmetricAlgorithm aa) { throw null; }
        }
        public partial class SignerInfo
        {
            public SignerInfo() { }
            public SignerInfo(Mono.Security.ASN1 asn1) { }
            public SignerInfo(byte[] data) { }
            public Mono.Security.ASN1 ASN1 { get { throw null; } }
            public System.Collections.ArrayList AuthenticatedAttributes { get { throw null; } }
            public Mono.Security.X509.X509Certificate Certificate { get { throw null; } set { } }
            public string HashName { get { throw null; } set { } }
            public string IssuerName { get { throw null; } }
            public System.Security.Cryptography.AsymmetricAlgorithm Key { get { throw null; } set { } }
            public byte[] SerialNumber { get { throw null; } }
            public byte[] Signature { get { throw null; } set { } }
            public byte[] SubjectKeyIdentifier { get { throw null; } }
            public System.Collections.ArrayList UnauthenticatedAttributes { get { throw null; } }
            public byte Version { get { throw null; } set { } }
            public byte[] GetBytes() { throw null; }
        }
    }
    public sealed partial class StrongName
    {
        public StrongName() { }
        public StrongName(byte[] data) { }
        public StrongName(int keySize) { }
        public StrongName(System.Security.Cryptography.RSA rsa) { }
        public bool CanSign { get { throw null; } }
        public byte[] PublicKey { get { throw null; } }
        public byte[] PublicKeyToken { get { throw null; } }
        public System.Security.Cryptography.RSA RSA { get { throw null; } set { } }
        public string TokenAlgorithm { get { throw null; } set { } }
        public byte[] GetBytes() { throw null; }
        public byte[] Hash(string fileName) { throw null; }
        public bool Sign(string fileName) { throw null; }
        public bool Verify(System.IO.Stream stream) { throw null; }
        public bool Verify(string fileName) { throw null; }
    }
}
namespace Mono.Security.Authenticode
{
    public partial class AuthenticodeBase
    {
        public const string spcIndirectDataContext = "1.3.6.1.4.1.311.2.1.4";
        public AuthenticodeBase() { }
        protected byte[] HashFile(string fileName, string hashName) { throw null; }
    }
    public partial class AuthenticodeDeformatter : Mono.Security.Authenticode.AuthenticodeBase
    {
        public AuthenticodeDeformatter() { }
        public AuthenticodeDeformatter(string fileName) { }
        public Mono.Security.X509.X509CertificateCollection Certificates { get { throw null; } }
        public string FileName { get { throw null; } set { } }
        public byte[] Hash { get { throw null; } }
        public int Reason { get { throw null; } }
        public byte[] Signature { get { throw null; } }
        public Mono.Security.X509.X509Certificate SigningCertificate { get { throw null; } }
        public System.DateTime Timestamp { get { throw null; } }
        public bool IsTrusted() { throw null; }
    }
    public partial class AuthenticodeFormatter : Mono.Security.Authenticode.AuthenticodeBase
    {
        public AuthenticodeFormatter() { }
        public Mono.Security.Authenticode.Authority Authority { get { throw null; } set { } }
        public Mono.Security.X509.X509CertificateCollection Certificates { get { throw null; } }
        public System.Collections.ArrayList Crl { get { throw null; } }
        public string Description { get { throw null; } set { } }
        public string Hash { get { throw null; } set { } }
        public System.Security.Cryptography.RSA RSA { get { throw null; } set { } }
        public System.Uri TimestampUrl { get { throw null; } set { } }
        public System.Uri Url { get { throw null; } set { } }
        public void ProcessTimestamp(byte[] response) { }
        public bool Sign(string fileName) { throw null; }
        public bool Timestamp(string fileName) { throw null; }
        public Mono.Security.ASN1 TimestampRequest(byte[] signature) { throw null; }
    }
    public enum Authority
    {
        Commercial = 1,
        Individual = 0,
        Maximum = 2,
    }
    public partial class PrivateKey
    {
        public PrivateKey() { }
        public PrivateKey(byte[] data, string password) { }
        public bool Encrypted { get { throw null; } }
        public int KeyType { get { throw null; } set { } }
        public System.Security.Cryptography.RSA RSA { get { throw null; } set { } }
        public bool Weak { get { throw null; } set { } }
        public static Mono.Security.Authenticode.PrivateKey CreateFromFile(string filename) { throw null; }
        public static Mono.Security.Authenticode.PrivateKey CreateFromFile(string filename, string password) { throw null; }
        public void Save(string filename) { }
        public void Save(string filename, string password) { }
    }
    public partial class SoftwarePublisherCertificate
    {
        public SoftwarePublisherCertificate() { }
        public SoftwarePublisherCertificate(byte[] data) { }
        public Mono.Security.X509.X509CertificateCollection Certificates { get { throw null; } }
        public System.Collections.ArrayList Crls { get { throw null; } }
        public static Mono.Security.Authenticode.SoftwarePublisherCertificate CreateFromFile(string filename) { throw null; }
        public byte[] GetBytes() { throw null; }
    }
}
namespace Mono.Security.Cryptography
{
    public partial class ARC4Managed : Mono.Security.Cryptography.RC4, System.IDisposable, System.Security.Cryptography.ICryptoTransform
    {
        public ARC4Managed() { }
        public bool CanReuseTransform { get { throw null; } }
        public bool CanTransformMultipleBlocks { get { throw null; } }
        public int InputBlockSize { get { throw null; } }
        public override byte[] Key { get { throw null; } set { } }
        public int OutputBlockSize { get { throw null; } }
        public override System.Security.Cryptography.ICryptoTransform CreateDecryptor(byte[] rgbKey, byte[] rgvIV) { throw null; }
        public override System.Security.Cryptography.ICryptoTransform CreateEncryptor(byte[] rgbKey, byte[] rgvIV) { throw null; }
        protected override void Dispose(bool disposing) { }
        ~ARC4Managed() { }
        public override void GenerateIV() { }
        public override void GenerateKey() { }
        public int TransformBlock(byte[] inputBuffer, int inputOffset, int inputCount, byte[] outputBuffer, int outputOffset) { throw null; }
        public byte[] TransformFinalBlock(byte[] inputBuffer, int inputOffset, int inputCount) { throw null; }
    }
    public partial class BlockProcessor
    {
        public BlockProcessor(System.Security.Cryptography.ICryptoTransform transform) { }
        public BlockProcessor(System.Security.Cryptography.ICryptoTransform transform, int blockSize) { }
        public void Core(byte[] rgb) { }
        public void Core(byte[] rgb, int ib, int cb) { }
        public byte[] Final() { throw null; }
        ~BlockProcessor() { }
        public void Initialize() { }
    }
    public sealed partial class CryptoConvert
    {
        internal CryptoConvert() { }
        public static System.Security.Cryptography.RSA FromCapiKeyBlob(byte[] blob) { throw null; }
        public static System.Security.Cryptography.RSA FromCapiKeyBlob(byte[] blob, int offset) { throw null; }
        public static System.Security.Cryptography.DSA FromCapiKeyBlobDSA(byte[] blob) { throw null; }
        public static System.Security.Cryptography.DSA FromCapiKeyBlobDSA(byte[] blob, int offset) { throw null; }
        public static System.Security.Cryptography.RSA FromCapiPrivateKeyBlob(byte[] blob) { throw null; }
        public static System.Security.Cryptography.RSA FromCapiPrivateKeyBlob(byte[] blob, int offset) { throw null; }
        public static System.Security.Cryptography.DSA FromCapiPrivateKeyBlobDSA(byte[] blob) { throw null; }
        public static System.Security.Cryptography.DSA FromCapiPrivateKeyBlobDSA(byte[] blob, int offset) { throw null; }
        public static System.Security.Cryptography.RSA FromCapiPublicKeyBlob(byte[] blob) { throw null; }
        public static System.Security.Cryptography.RSA FromCapiPublicKeyBlob(byte[] blob, int offset) { throw null; }
        public static System.Security.Cryptography.DSA FromCapiPublicKeyBlobDSA(byte[] blob) { throw null; }
        public static System.Security.Cryptography.DSA FromCapiPublicKeyBlobDSA(byte[] blob, int offset) { throw null; }
        public static byte[] FromHex(string hex) { throw null; }
        public static byte[] ToCapiKeyBlob(System.Security.Cryptography.AsymmetricAlgorithm keypair, bool includePrivateKey) { throw null; }
        public static byte[] ToCapiKeyBlob(System.Security.Cryptography.DSA dsa, bool includePrivateKey) { throw null; }
        public static byte[] ToCapiKeyBlob(System.Security.Cryptography.RSA rsa, bool includePrivateKey) { throw null; }
        public static byte[] ToCapiPrivateKeyBlob(System.Security.Cryptography.DSA dsa) { throw null; }
        public static byte[] ToCapiPrivateKeyBlob(System.Security.Cryptography.RSA rsa) { throw null; }
        public static byte[] ToCapiPublicKeyBlob(System.Security.Cryptography.DSA dsa) { throw null; }
        public static byte[] ToCapiPublicKeyBlob(System.Security.Cryptography.RSA rsa) { throw null; }
        public static string ToHex(byte[] input) { throw null; }
    }
    public enum DHKeyGeneration
    {
        Random = 0,
        Static = 1,
    }
    [System.SerializableAttribute]
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public partial struct DHParameters
    {
        public byte[] G;
        public byte[] P;
        [System.NonSerializedAttribute]
        public byte[] X;
    }
    public abstract partial class DiffieHellman : System.Security.Cryptography.AsymmetricAlgorithm
    {
        protected DiffieHellman() { }
        public static new Mono.Security.Cryptography.DiffieHellman Create() { throw null; }
        public static new Mono.Security.Cryptography.DiffieHellman Create(string algName) { throw null; }
        public abstract byte[] CreateKeyExchange();
        public abstract byte[] DecryptKeyExchange(byte[] keyex);
        public abstract Mono.Security.Cryptography.DHParameters ExportParameters(bool includePrivate);
        public override void FromXmlString(string xmlString) { }
        public abstract void ImportParameters(Mono.Security.Cryptography.DHParameters parameters);
        public override string ToXmlString(bool includePrivateParameters) { throw null; }
    }
    public sealed partial class DiffieHellmanManaged : Mono.Security.Cryptography.DiffieHellman
    {
        public DiffieHellmanManaged() { }
        public DiffieHellmanManaged(byte[] p, byte[] g, byte[] x) { }
        public DiffieHellmanManaged(byte[] p, byte[] g, int l) { }
        public DiffieHellmanManaged(int bitLength, int l, Mono.Security.Cryptography.DHKeyGeneration method) { }
        public override string KeyExchangeAlgorithm { get { throw null; } }
        public override string SignatureAlgorithm { get { throw null; } }
        public override byte[] CreateKeyExchange() { throw null; }
        public override byte[] DecryptKeyExchange(byte[] keyEx) { throw null; }
        protected override void Dispose(bool disposing) { }
        public override Mono.Security.Cryptography.DHParameters ExportParameters(bool includePrivateParameters) { throw null; }
        ~DiffieHellmanManaged() { }
        public override void ImportParameters(Mono.Security.Cryptography.DHParameters parameters) { }
    }
    public sealed partial class KeyBuilder
    {
        internal KeyBuilder() { }
        public static byte[] IV(int size) { throw null; }
        public static byte[] Key(int size) { throw null; }
    }
    public partial class KeyPairPersistence
    {
        public KeyPairPersistence(System.Security.Cryptography.CspParameters parameters) { }
        public KeyPairPersistence(System.Security.Cryptography.CspParameters parameters, string keyPair) { }
        public string Filename { get { throw null; } }
        public string KeyValue { get { throw null; } set { } }
        public System.Security.Cryptography.CspParameters Parameters { get { throw null; } }
        public bool Load() { throw null; }
        public void Remove() { }
        public void Save() { }
    }
    public abstract partial class MD2 : System.Security.Cryptography.HashAlgorithm
    {
        protected MD2() { }
        public static new Mono.Security.Cryptography.MD2 Create() { throw null; }
        public static new Mono.Security.Cryptography.MD2 Create(string hashName) { throw null; }
    }
    public partial class MD2Managed : Mono.Security.Cryptography.MD2
    {
        public MD2Managed() { }
        protected override void HashCore(byte[] array, int ibStart, int cbSize) { }
        protected override byte[] HashFinal() { throw null; }
        public override void Initialize() { }
    }
    public abstract partial class MD4 : System.Security.Cryptography.HashAlgorithm
    {
        protected MD4() { }
        public static new Mono.Security.Cryptography.MD4 Create() { throw null; }
        public static new Mono.Security.Cryptography.MD4 Create(string hashName) { throw null; }
    }
    public partial class MD4Managed : Mono.Security.Cryptography.MD4
    {
        public MD4Managed() { }
        protected override void HashCore(byte[] array, int ibStart, int cbSize) { }
        protected override byte[] HashFinal() { throw null; }
        public override void Initialize() { }
    }
    public sealed partial class PKCS1
    {
        internal PKCS1() { }
        public static byte[] Decrypt_OAEP(System.Security.Cryptography.RSA rsa, System.Security.Cryptography.HashAlgorithm hash, byte[] C) { throw null; }
        public static byte[] Decrypt_v15(System.Security.Cryptography.RSA rsa, byte[] C) { throw null; }
        public static byte[] Encode_v15(System.Security.Cryptography.HashAlgorithm hash, byte[] hashValue, int emLength) { throw null; }
        public static byte[] Encrypt_OAEP(System.Security.Cryptography.RSA rsa, System.Security.Cryptography.HashAlgorithm hash, System.Security.Cryptography.RandomNumberGenerator rng, byte[] M) { throw null; }
        public static byte[] Encrypt_v15(System.Security.Cryptography.RSA rsa, System.Security.Cryptography.RandomNumberGenerator rng, byte[] M) { throw null; }
        public static byte[] I2OSP(byte[] x, int size) { throw null; }
        public static byte[] I2OSP(int x, int size) { throw null; }
        public static byte[] MGF1(System.Security.Cryptography.HashAlgorithm hash, byte[] mgfSeed, int maskLen) { throw null; }
        public static byte[] OS2IP(byte[] x) { throw null; }
        public static byte[] RSADP(System.Security.Cryptography.RSA rsa, byte[] c) { throw null; }
        public static byte[] RSAEP(System.Security.Cryptography.RSA rsa, byte[] m) { throw null; }
        public static byte[] RSASP1(System.Security.Cryptography.RSA rsa, byte[] m) { throw null; }
        public static byte[] RSAVP1(System.Security.Cryptography.RSA rsa, byte[] s) { throw null; }
        public static byte[] Sign_v15(System.Security.Cryptography.RSA rsa, System.Security.Cryptography.HashAlgorithm hash, byte[] hashValue) { throw null; }
        public static bool Verify_v15(System.Security.Cryptography.RSA rsa, System.Security.Cryptography.HashAlgorithm hash, byte[] hashValue, byte[] signature) { throw null; }
        public static bool Verify_v15(System.Security.Cryptography.RSA rsa, System.Security.Cryptography.HashAlgorithm hash, byte[] hashValue, byte[] signature, bool tryNonStandardEncoding) { throw null; }
    }
    public sealed partial class PKCS8
    {
        internal PKCS8() { }
        public static Mono.Security.Cryptography.PKCS8.KeyInfo GetType(byte[] data) { throw null; }
        public partial class EncryptedPrivateKeyInfo
        {
            public EncryptedPrivateKeyInfo() { }
            public EncryptedPrivateKeyInfo(byte[] data) { }
            public string Algorithm { get { throw null; } set { } }
            public byte[] EncryptedData { get { throw null; } set { } }
            public int IterationCount { get { throw null; } set { } }
            public byte[] Salt { get { throw null; } set { } }
            public byte[] GetBytes() { throw null; }
        }
        public enum KeyInfo
        {
            EncryptedPrivateKey = 1,
            PrivateKey = 0,
            Unknown = 2,
        }
        public partial class PrivateKeyInfo
        {
            public PrivateKeyInfo() { }
            public PrivateKeyInfo(byte[] data) { }
            public string Algorithm { get { throw null; } set { } }
            public System.Collections.ArrayList Attributes { get { throw null; } }
            public byte[] PrivateKey { get { throw null; } set { } }
            public int Version { get { throw null; } set { } }
            public static System.Security.Cryptography.DSA DecodeDSA(byte[] privateKey, System.Security.Cryptography.DSAParameters dsaParameters) { throw null; }
            public static System.Security.Cryptography.RSA DecodeRSA(byte[] keypair) { throw null; }
            public static byte[] Encode(System.Security.Cryptography.AsymmetricAlgorithm aa) { throw null; }
            public static byte[] Encode(System.Security.Cryptography.DSA dsa) { throw null; }
            public static byte[] Encode(System.Security.Cryptography.RSA rsa) { throw null; }
            public byte[] GetBytes() { throw null; }
        }
    }
    public abstract partial class RC4 : System.Security.Cryptography.SymmetricAlgorithm
    {
        public RC4() { }
        public override byte[] IV { get { throw null; } set { } }
        public static new Mono.Security.Cryptography.RC4 Create() { throw null; }
        public static new Mono.Security.Cryptography.RC4 Create(string algName) { throw null; }
    }
    public partial class RSAManaged : System.Security.Cryptography.RSA
    {
        public RSAManaged() { }
        public RSAManaged(int keySize) { }
        public bool IsCrtPossible { get { throw null; } }
        public override string KeyExchangeAlgorithm { get { throw null; } }
        public override int KeySize { get { throw null; } }
        public bool PublicOnly { get { throw null; } }
        public override string SignatureAlgorithm { get { throw null; } }
        public bool UseKeyBlinding { get { throw null; } set { } }
        public event Mono.Security.Cryptography.RSAManaged.KeyGeneratedEventHandler KeyGenerated { add { } remove { } }
        public override byte[] DecryptValue(byte[] rgb) { throw null; }
        protected override void Dispose(bool disposing) { }
        public override byte[] EncryptValue(byte[] rgb) { throw null; }
        public override System.Security.Cryptography.RSAParameters ExportParameters(bool includePrivateParameters) { throw null; }
        ~RSAManaged() { }
        public override void ImportParameters(System.Security.Cryptography.RSAParameters parameters) { }
        public override string ToXmlString(bool includePrivateParameters) { throw null; }
        public delegate void KeyGeneratedEventHandler(object sender, System.EventArgs e);
    }
    public abstract partial class SHA224 : System.Security.Cryptography.HashAlgorithm
    {
        public SHA224() { }
        public static new Mono.Security.Cryptography.SHA224 Create() { throw null; }
        public static new Mono.Security.Cryptography.SHA224 Create(string hashName) { throw null; }
    }
    public partial class SHA224Managed : Mono.Security.Cryptography.SHA224
    {
        public SHA224Managed() { }
        protected override void HashCore(byte[] rgb, int start, int size) { }
        protected override byte[] HashFinal() { throw null; }
        public override void Initialize() { }
    }
}
namespace Mono.Security.Protocol.Ntlm
{
    [System.ObsoleteAttribute("Use of this API is highly discouraged, it selects legacy-mode LM/NTLM authentication, which sends your password in very weak encryption over the wire even if the server supports the more secure NTLMv2 / NTLMv2 Session. You need to use the new `Type3Message (Type2Message)' constructor to use the more secure NTLMv2 / NTLMv2 Session authentication modes. These require the Type 2 message from the server to compute the response.")]
    public partial class ChallengeResponse : System.IDisposable
    {
        public ChallengeResponse() { }
        public ChallengeResponse(string password, byte[] challenge) { }
        public byte[] Challenge { get { throw null; } set { } }
        public byte[] LM { get { throw null; } }
        public byte[] NT { get { throw null; } }
        public string Password { get { throw null; } set { } }
        public void Dispose() { }
        ~ChallengeResponse() { }
    }
    public static partial class ChallengeResponse2
    {
        public static void Compute(Mono.Security.Protocol.Ntlm.Type2Message type2, Mono.Security.Protocol.Ntlm.NtlmAuthLevel level, string username, string password, string domain, out byte[] lm, out byte[] ntlm) { lm = default(byte[]); ntlm = default(byte[]); }
    }
    public abstract partial class MessageBase
    {
        protected MessageBase(int messageType) { }
        public Mono.Security.Protocol.Ntlm.NtlmFlags Flags { get { throw null; } set { } }
        public int Type { get { throw null; } }
        protected bool CheckHeader(byte[] message) { throw null; }
        protected virtual void Decode(byte[] message) { }
        public abstract byte[] GetBytes();
        protected byte[] PrepareMessage(int messageSize) { throw null; }
    }
    public enum NtlmAuthLevel
    {
        LM_and_NTLM = 0,
        LM_and_NTLM_and_try_NTLMv2_Session = 1,
        NTLMv2_only = 3,
        NTLM_only = 2,
    }
    [System.FlagsAttribute]
    public enum NtlmFlags
    {
        Negotiate128 = 536870912,
        Negotiate56 = -2147483648,
        NegotiateAlwaysSign = 32768,
        NegotiateDomainSupplied = 4096,
        NegotiateNtlm = 512,
        NegotiateNtlm2Key = 524288,
        NegotiateOem = 2,
        NegotiateUnicode = 1,
        NegotiateWorkstationSupplied = 8192,
        RequestTarget = 4,
    }
    public static partial class NtlmSettings
    {
        public static Mono.Security.Protocol.Ntlm.NtlmAuthLevel DefaultAuthLevel { get { throw null; } set { } }
    }
    public partial class Type1Message : Mono.Security.Protocol.Ntlm.MessageBase
    {
        public Type1Message() : base (default(int)) { }
        public Type1Message(byte[] message) : base (default(int)) { }
        public string Domain { get { throw null; } set { } }
        public string Host { get { throw null; } set { } }
        protected override void Decode(byte[] message) { }
        public override byte[] GetBytes() { throw null; }
    }
    public partial class Type2Message : Mono.Security.Protocol.Ntlm.MessageBase
    {
        public Type2Message() : base (default(int)) { }
        public Type2Message(byte[] message) : base (default(int)) { }
        public byte[] Nonce { get { throw null; } set { } }
        public byte[] TargetInfo { get { throw null; } }
        public string TargetName { get { throw null; } }
        protected override void Decode(byte[] message) { }
        ~Type2Message() { }
        public override byte[] GetBytes() { throw null; }
    }
    public partial class Type3Message : Mono.Security.Protocol.Ntlm.MessageBase
    {
        [System.ObsoleteAttribute("Use of this API is highly discouraged, it selects legacy-mode LM/NTLM authentication, which sends your password in very weak encryption over the wire even if the server supports the more secure NTLMv2 / NTLMv2 Session. You need to use the new `Type3Message (Type2Message)' constructor to use the more secure NTLMv2 / NTLMv2 Session authentication modes. These require the Type 2 message from the server to compute the response.")]
        public Type3Message() : base (default(int)) { }
        public Type3Message(Mono.Security.Protocol.Ntlm.Type2Message type2) : base (default(int)) { }
        public Type3Message(byte[] message) : base (default(int)) { }
        [System.ObsoleteAttribute("Use of this API is highly discouraged, it selects legacy-mode LM/NTLM authentication, which sends your password in very weak encryption over the wire even if the server supports the more secure NTLMv2 / NTLMv2 Session. You need to use the new `Type3Message (Type2Message)' constructor to use the more secure NTLMv2 / NTLMv2 Session authentication modes. These require the Type 2 message from the server to compute the response.")]
        public byte[] Challenge { get { throw null; } set { } }
        [System.ObsoleteAttribute("Use NtlmSettings.DefaultAuthLevel")]
        public static Mono.Security.Protocol.Ntlm.NtlmAuthLevel DefaultAuthLevel { get { throw null; } set { } }
        public string Domain { get { throw null; } set { } }
        public string Host { get { throw null; } set { } }
        public Mono.Security.Protocol.Ntlm.NtlmAuthLevel Level { get { throw null; } set { } }
        public byte[] LM { get { throw null; } }
        public byte[] NT { get { throw null; } set { } }
        public string Password { get { throw null; } set { } }
        public string Username { get { throw null; } set { } }
        protected override void Decode(byte[] message) { }
        ~Type3Message() { }
        public override byte[] GetBytes() { throw null; }
    }
}
namespace Mono.Security.Protocol.Tls
{
    public delegate System.Security.Cryptography.X509Certificates.X509Certificate CertificateSelectionCallback(System.Security.Cryptography.X509Certificates.X509CertificateCollection clientCertificates, System.Security.Cryptography.X509Certificates.X509Certificate serverCertificate, string targetHost, System.Security.Cryptography.X509Certificates.X509CertificateCollection serverRequestedCertificates);
    public delegate bool CertificateValidationCallback(System.Security.Cryptography.X509Certificates.X509Certificate certificate, int[] certificateErrors);
    public delegate Mono.Security.Protocol.Tls.ValidationResult CertificateValidationCallback2(Mono.Security.X509.X509CertificateCollection collection);
    [System.SerializableAttribute]
    public enum CipherAlgorithmType
    {
        Des = 0,
        None = 1,
        Rc2 = 2,
        Rc4 = 3,
        Rijndael = 4,
        SkipJack = 5,
        TripleDes = 6,
    }
    [System.SerializableAttribute]
    public enum ExchangeAlgorithmType
    {
        DiffieHellman = 0,
        Fortezza = 1,
        None = 2,
        RsaKeyX = 3,
        RsaSign = 4,
    }
    [System.SerializableAttribute]
    public enum HashAlgorithmType
    {
        Md5 = 0,
        None = 1,
        Sha1 = 2,
    }
    public delegate System.Security.Cryptography.AsymmetricAlgorithm PrivateKeySelectionCallback(System.Security.Cryptography.X509Certificates.X509Certificate certificate, string targetHost);
    public enum SecurityCompressionType
    {
        None = 0,
        Zlib = 1,
    }
    [System.FlagsAttribute]
    [System.SerializableAttribute]
    public enum SecurityProtocolType
    {
        Default = -1073741824,
        Ssl2 = 12,
        Ssl3 = 48,
        Tls = 192,
    }
    public partial class SslClientStream : Mono.Security.Protocol.Tls.SslStreamBase
    {
        public SslClientStream(System.IO.Stream stream, string targetHost, bool ownsStream) : base (default(System.IO.Stream), default(bool)) { }
        public SslClientStream(System.IO.Stream stream, string targetHost, bool ownsStream, Mono.Security.Protocol.Tls.SecurityProtocolType securityProtocolType) : base (default(System.IO.Stream), default(bool)) { }
        public SslClientStream(System.IO.Stream stream, string targetHost, bool ownsStream, Mono.Security.Protocol.Tls.SecurityProtocolType securityProtocolType, System.Security.Cryptography.X509Certificates.X509CertificateCollection clientCertificates) : base (default(System.IO.Stream), default(bool)) { }
        public SslClientStream(System.IO.Stream stream, string targetHost, System.Security.Cryptography.X509Certificates.X509Certificate clientCertificate) : base (default(System.IO.Stream), default(bool)) { }
        public SslClientStream(System.IO.Stream stream, string targetHost, System.Security.Cryptography.X509Certificates.X509CertificateCollection clientCertificates) : base (default(System.IO.Stream), default(bool)) { }
        public System.Security.Cryptography.X509Certificates.X509CertificateCollection ClientCertificates { get { throw null; } }
        public Mono.Security.Protocol.Tls.CertificateSelectionCallback ClientCertSelectionDelegate { get { throw null; } set { } }
        public Mono.Security.Protocol.Tls.PrivateKeySelectionCallback PrivateKeyCertSelectionDelegate { get { throw null; } set { } }
        public System.Security.Cryptography.X509Certificates.X509Certificate SelectedClientCertificate { get { throw null; } }
        public Mono.Security.Protocol.Tls.CertificateValidationCallback ServerCertValidationDelegate { get { throw null; } set { } }
        public event Mono.Security.Protocol.Tls.CertificateValidationCallback2 ServerCertValidation2 { add { } remove { } }
        protected override void Dispose(bool disposing) { }
        ~SslClientStream() { }
    }
    public partial class SslServerStream : Mono.Security.Protocol.Tls.SslStreamBase
    {
        public SslServerStream(System.IO.Stream stream, System.Security.Cryptography.X509Certificates.X509Certificate serverCertificate) : base (default(System.IO.Stream), default(bool)) { }
        public SslServerStream(System.IO.Stream stream, System.Security.Cryptography.X509Certificates.X509Certificate serverCertificate, bool clientCertificateRequired, bool ownsStream) : base (default(System.IO.Stream), default(bool)) { }
        public SslServerStream(System.IO.Stream stream, System.Security.Cryptography.X509Certificates.X509Certificate serverCertificate, bool clientCertificateRequired, bool ownsStream, Mono.Security.Protocol.Tls.SecurityProtocolType securityProtocolType) : base (default(System.IO.Stream), default(bool)) { }
        public SslServerStream(System.IO.Stream stream, System.Security.Cryptography.X509Certificates.X509Certificate serverCertificate, bool clientCertificateRequired, bool requestClientCertificate, bool ownsStream) : base (default(System.IO.Stream), default(bool)) { }
        public SslServerStream(System.IO.Stream stream, System.Security.Cryptography.X509Certificates.X509Certificate serverCertificate, bool clientCertificateRequired, bool requestClientCertificate, bool ownsStream, Mono.Security.Protocol.Tls.SecurityProtocolType securityProtocolType) : base (default(System.IO.Stream), default(bool)) { }
        public System.Security.Cryptography.X509Certificates.X509Certificate ClientCertificate { get { throw null; } }
        public Mono.Security.Protocol.Tls.CertificateValidationCallback ClientCertValidationDelegate { get { throw null; } set { } }
        public Mono.Security.Protocol.Tls.PrivateKeySelectionCallback PrivateKeyCertSelectionDelegate { get { throw null; } set { } }
        public event Mono.Security.Protocol.Tls.CertificateValidationCallback2 ClientCertValidation2 { add { } remove { } }
        protected override void Dispose(bool disposing) { }
        ~SslServerStream() { }
    }
    public abstract partial class SslStreamBase : System.IO.Stream, System.IDisposable
    {
        protected SslStreamBase(System.IO.Stream stream, bool ownsStream) { }
        public override bool CanRead { get { throw null; } }
        public override bool CanSeek { get { throw null; } }
        public override bool CanWrite { get { throw null; } }
        public bool CheckCertRevocationStatus { get { throw null; } set { } }
        public Mono.Security.Protocol.Tls.CipherAlgorithmType CipherAlgorithm { get { throw null; } }
        public int CipherStrength { get { throw null; } }
        public Mono.Security.Protocol.Tls.HashAlgorithmType HashAlgorithm { get { throw null; } }
        public int HashStrength { get { throw null; } }
        public Mono.Security.Protocol.Tls.ExchangeAlgorithmType KeyExchangeAlgorithm { get { throw null; } }
        public int KeyExchangeStrength { get { throw null; } }
        public override long Length { get { throw null; } }
        public override long Position { get { throw null; } set { } }
        public Mono.Security.Protocol.Tls.SecurityProtocolType SecurityProtocol { get { throw null; } }
        public System.Security.Cryptography.X509Certificates.X509Certificate ServerCertificate { get { throw null; } }
        public override System.IAsyncResult BeginRead(byte[] buffer, int offset, int count, System.AsyncCallback callback, object state) { throw null; }
        public override System.IAsyncResult BeginWrite(byte[] buffer, int offset, int count, System.AsyncCallback callback, object state) { throw null; }
        public override void Close() { }
        protected override void Dispose(bool disposing) { }
        public override int EndRead(System.IAsyncResult asyncResult) { throw null; }
        public override void EndWrite(System.IAsyncResult asyncResult) { }
        ~SslStreamBase() { }
        public override void Flush() { }
        public int Read(byte[] buffer) { throw null; }
        public override int Read(byte[] buffer, int offset, int count) { throw null; }
        public override long Seek(long offset, System.IO.SeekOrigin origin) { throw null; }
        public override void SetLength(long value) { }
        public void Write(byte[] buffer) { }
        public override void Write(byte[] buffer, int offset, int count) { }
    }
    public partial class ValidationResult
    {
        public ValidationResult(bool trusted, bool user_denied, int error_code) { }
        public int ErrorCode { get { throw null; } }
        public bool Trusted { get { throw null; } }
        public bool UserDenied { get { throw null; } }
    }
}
namespace Mono.Security.X509
{
    public partial class PKCS12 : System.ICloneable
    {
        public const string certBag = "1.2.840.113549.1.12.10.1.3";
        public const string crlBag = "1.2.840.113549.1.12.10.1.4";
        public const int CryptoApiPasswordLimit = 32;
        public const string keyBag = "1.2.840.113549.1.12.10.1.1";
        public const string pbeWithSHAAnd128BitRC2CBC = "1.2.840.113549.1.12.1.5";
        public const string pbeWithSHAAnd128BitRC4 = "1.2.840.113549.1.12.1.1";
        public const string pbeWithSHAAnd2KeyTripleDESCBC = "1.2.840.113549.1.12.1.4";
        public const string pbeWithSHAAnd3KeyTripleDESCBC = "1.2.840.113549.1.12.1.3";
        public const string pbeWithSHAAnd40BitRC2CBC = "1.2.840.113549.1.12.1.6";
        public const string pbeWithSHAAnd40BitRC4 = "1.2.840.113549.1.12.1.2";
        public const string pkcs8ShroudedKeyBag = "1.2.840.113549.1.12.10.1.2";
        public const string safeContentsBag = "1.2.840.113549.1.12.10.1.6";
        public const string sdsiCertificate = "1.2.840.113549.1.9.22.2";
        public const string secretBag = "1.2.840.113549.1.12.10.1.5";
        public const string x509Certificate = "1.2.840.113549.1.9.22.1";
        public const string x509Crl = "1.2.840.113549.1.9.23.1";
        public PKCS12() { }
        public PKCS12(byte[] data) { }
        public PKCS12(byte[] data, byte[] password) { }
        public PKCS12(byte[] data, string password) { }
        public Mono.Security.X509.X509CertificateCollection Certificates { get { throw null; } }
        public int IterationCount { get { throw null; } set { } }
        public System.Collections.ArrayList Keys { get { throw null; } }
        public static int MaximumPasswordLength { get { throw null; } set { } }
        public string Password { set { } }
        public System.Collections.ArrayList Secrets { get { throw null; } }
        public void AddCertificate(Mono.Security.X509.X509Certificate cert) { }
        public void AddCertificate(Mono.Security.X509.X509Certificate cert, System.Collections.IDictionary attributes) { }
        public void AddKeyBag(System.Security.Cryptography.AsymmetricAlgorithm aa) { }
        public void AddKeyBag(System.Security.Cryptography.AsymmetricAlgorithm aa, System.Collections.IDictionary attributes) { }
        public void AddPkcs8ShroudedKeyBag(System.Security.Cryptography.AsymmetricAlgorithm aa) { }
        public void AddPkcs8ShroudedKeyBag(System.Security.Cryptography.AsymmetricAlgorithm aa, System.Collections.IDictionary attributes) { }
        public void AddSecretBag(byte[] secret) { }
        public void AddSecretBag(byte[] secret, System.Collections.IDictionary attributes) { }
        public object Clone() { throw null; }
        public byte[] Decrypt(Mono.Security.PKCS7.EncryptedData ed) { throw null; }
        public byte[] Decrypt(string algorithmOid, byte[] salt, int iterationCount, byte[] encryptedData) { throw null; }
        public byte[] Encrypt(string algorithmOid, byte[] salt, int iterationCount, byte[] data) { throw null; }
        ~PKCS12() { }
        public System.Security.Cryptography.AsymmetricAlgorithm GetAsymmetricAlgorithm(System.Collections.IDictionary attrs) { throw null; }
        public System.Collections.IDictionary GetAttributes(Mono.Security.X509.X509Certificate cert) { throw null; }
        public System.Collections.IDictionary GetAttributes(System.Security.Cryptography.AsymmetricAlgorithm aa) { throw null; }
        public byte[] GetBytes() { throw null; }
        public Mono.Security.X509.X509Certificate GetCertificate(System.Collections.IDictionary attrs) { throw null; }
        public byte[] GetSecret(System.Collections.IDictionary attrs) { throw null; }
        public static Mono.Security.X509.PKCS12 LoadFromFile(string filename) { throw null; }
        public static Mono.Security.X509.PKCS12 LoadFromFile(string filename, string password) { throw null; }
        public void RemoveCertificate(Mono.Security.X509.X509Certificate cert) { }
        public void RemoveCertificate(Mono.Security.X509.X509Certificate cert, System.Collections.IDictionary attrs) { }
        public void RemoveKeyBag(System.Security.Cryptography.AsymmetricAlgorithm aa) { }
        public void RemovePkcs8ShroudedKeyBag(System.Security.Cryptography.AsymmetricAlgorithm aa) { }
        public void RemoveSecretBag(byte[] secret) { }
        public void SaveToFile(string filename) { }
        public partial class DeriveBytes
        {
            public DeriveBytes() { }
            public string HashName { get { throw null; } set { } }
            public int IterationCount { get { throw null; } set { } }
            public byte[] Password { get { throw null; } set { } }
            public byte[] Salt { get { throw null; } set { } }
            public byte[] DeriveIV(int size) { throw null; }
            public byte[] DeriveKey(int size) { throw null; }
            public byte[] DeriveMAC(int size) { throw null; }
            public enum Purpose
            {
                IV = 1,
                Key = 0,
                MAC = 2,
            }
        }
    }
    public partial class PKCS5
    {
        public const string pbeWithMD2AndDESCBC = "1.2.840.113549.1.5.1";
        public const string pbeWithMD2AndRC2CBC = "1.2.840.113549.1.5.4";
        public const string pbeWithMD5AndDESCBC = "1.2.840.113549.1.5.3";
        public const string pbeWithMD5AndRC2CBC = "1.2.840.113549.1.5.6";
        public const string pbeWithSHA1AndDESCBC = "1.2.840.113549.1.5.10";
        public const string pbeWithSHA1AndRC2CBC = "1.2.840.113549.1.5.11";
        public PKCS5() { }
    }
    public partial class PKCS9
    {
        public const string friendlyName = "1.2.840.113549.1.9.20";
        public const string localKeyId = "1.2.840.113549.1.9.21";
        public PKCS9() { }
    }
    public sealed partial class X501
    {
        internal X501() { }
        public static Mono.Security.ASN1 FromString(string rdn) { throw null; }
        public static string ToString(Mono.Security.ASN1 seq) { throw null; }
        public static string ToString(Mono.Security.ASN1 seq, bool reversed, string separator, bool quotes) { throw null; }
    }
    public abstract partial class X509Builder
    {
        protected X509Builder() { }
        public string Hash { get { throw null; } set { } }
        protected string GetOid(string hashName) { throw null; }
        public virtual byte[] Sign(System.Security.Cryptography.AsymmetricAlgorithm aa) { throw null; }
        public virtual byte[] Sign(System.Security.Cryptography.DSA key) { throw null; }
        public virtual byte[] Sign(System.Security.Cryptography.RSA key) { throw null; }
        protected abstract Mono.Security.ASN1 ToBeSigned(string hashName);
    }
    public partial class X509Certificate : System.Runtime.Serialization.ISerializable
    {
        public X509Certificate(byte[] data) { }
        protected X509Certificate(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        public System.Security.Cryptography.DSA DSA { get { throw null; } set { } }
        public Mono.Security.X509.X509ExtensionCollection Extensions { get { throw null; } }
        public byte[] Hash { get { throw null; } }
        public bool IsCurrent { get { throw null; } }
        public bool IsSelfSigned { get { throw null; } }
        public virtual string IssuerName { get { throw null; } }
        public byte[] IssuerUniqueIdentifier { get { throw null; } }
        public virtual string KeyAlgorithm { get { throw null; } }
        public virtual byte[] KeyAlgorithmParameters { get { throw null; } set { } }
        public virtual byte[] PublicKey { get { throw null; } }
        public virtual byte[] RawData { get { throw null; } }
        public virtual System.Security.Cryptography.RSA RSA { get { throw null; } set { } }
        public virtual byte[] SerialNumber { get { throw null; } }
        public virtual byte[] Signature { get { throw null; } }
        public virtual string SignatureAlgorithm { get { throw null; } }
        public virtual byte[] SignatureAlgorithmParameters { get { throw null; } }
        public virtual string SubjectName { get { throw null; } }
        public byte[] SubjectUniqueIdentifier { get { throw null; } }
        public virtual System.DateTime ValidFrom { get { throw null; } }
        public virtual System.DateTime ValidUntil { get { throw null; } }
        public int Version { get { throw null; } }
        public bool CheckSignature(byte[] hash, string hashAlgorithm, byte[] signature) { throw null; }
        public Mono.Security.ASN1 GetIssuerName() { throw null; }
        [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.Demand, SerializationFormatter=true)]
        public virtual void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        public Mono.Security.ASN1 GetSubjectName() { throw null; }
        public bool VerifySignature(System.Security.Cryptography.AsymmetricAlgorithm aa) { throw null; }
        public bool WasCurrent(System.DateTime instant) { throw null; }
    }
    public partial class X509CertificateBuilder : Mono.Security.X509.X509Builder
    {
        public X509CertificateBuilder() { }
        public X509CertificateBuilder(byte version) { }
        public Mono.Security.X509.X509ExtensionCollection Extensions { get { throw null; } }
        public string IssuerName { get { throw null; } set { } }
        public byte[] IssuerUniqueId { get { throw null; } set { } }
        public System.DateTime NotAfter { get { throw null; } set { } }
        public System.DateTime NotBefore { get { throw null; } set { } }
        public byte[] SerialNumber { get { throw null; } set { } }
        public string SubjectName { get { throw null; } set { } }
        public System.Security.Cryptography.AsymmetricAlgorithm SubjectPublicKey { get { throw null; } set { } }
        public byte[] SubjectUniqueId { get { throw null; } set { } }
        public byte Version { get { throw null; } set { } }
        protected override Mono.Security.ASN1 ToBeSigned(string oid) { throw null; }
    }
    [System.SerializableAttribute]
    public partial class X509CertificateCollection : System.Collections.CollectionBase, System.Collections.IEnumerable
    {
        public X509CertificateCollection() { }
        public X509CertificateCollection(Mono.Security.X509.X509CertificateCollection value) { }
        public X509CertificateCollection(Mono.Security.X509.X509Certificate[] value) { }
        public Mono.Security.X509.X509Certificate this[int index] { get { throw null; } set { } }
        public int Add(Mono.Security.X509.X509Certificate value) { throw null; }
        public void AddRange(Mono.Security.X509.X509CertificateCollection value) { }
        public void AddRange(Mono.Security.X509.X509Certificate[] value) { }
        public bool Contains(Mono.Security.X509.X509Certificate value) { throw null; }
        public void CopyTo(Mono.Security.X509.X509Certificate[] array, int index) { }
        public new Mono.Security.X509.X509CertificateCollection.X509CertificateEnumerator GetEnumerator() { throw null; }
        public override int GetHashCode() { throw null; }
        public int IndexOf(Mono.Security.X509.X509Certificate value) { throw null; }
        public void Insert(int index, Mono.Security.X509.X509Certificate value) { }
        public void Remove(Mono.Security.X509.X509Certificate value) { }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
        public partial class X509CertificateEnumerator : System.Collections.IEnumerator
        {
            public X509CertificateEnumerator(Mono.Security.X509.X509CertificateCollection mappings) { }
            public Mono.Security.X509.X509Certificate Current { get { throw null; } }
            object System.Collections.IEnumerator.Current { get { throw null; } }
            public bool MoveNext() { throw null; }
            public void Reset() { }
            bool System.Collections.IEnumerator.MoveNext() { throw null; }
            void System.Collections.IEnumerator.Reset() { }
        }
    }
    public partial class X509Chain
    {
        public X509Chain() { }
        public X509Chain(Mono.Security.X509.X509CertificateCollection chain) { }
        public Mono.Security.X509.X509CertificateCollection Chain { get { throw null; } }
        public Mono.Security.X509.X509Certificate Root { get { throw null; } }
        public Mono.Security.X509.X509ChainStatusFlags Status { get { throw null; } }
        public Mono.Security.X509.X509CertificateCollection TrustAnchors { get { throw null; } [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.Demand, Flags=(System.Security.Permissions.SecurityPermissionFlag)(64))]set { } }
        public bool Build(Mono.Security.X509.X509Certificate leaf) { throw null; }
        public Mono.Security.X509.X509Certificate FindByIssuerName(string issuerName) { throw null; }
        public void LoadCertificate(Mono.Security.X509.X509Certificate x509) { }
        public void LoadCertificates(Mono.Security.X509.X509CertificateCollection collection) { }
        public void Reset() { }
    }
    [System.FlagsAttribute]
    [System.SerializableAttribute]
    public enum X509ChainStatusFlags
    {
        InvalidBasicConstraints = 1024,
        NoError = 0,
        NotSignatureValid = 8,
        NotTimeNested = 2,
        NotTimeValid = 1,
        PartialChain = 65536,
        UntrustedRoot = 32,
    }
    public partial class X509Crl
    {
        public X509Crl(byte[] crl) { }
        public System.Collections.ArrayList Entries { get { throw null; } }
        public Mono.Security.X509.X509ExtensionCollection Extensions { get { throw null; } }
        public byte[] Hash { get { throw null; } }
        public bool IsCurrent { get { throw null; } }
        public string IssuerName { get { throw null; } }
        public Mono.Security.X509.X509Crl.X509CrlEntry this[byte[] serialNumber] { get { throw null; } }
        public Mono.Security.X509.X509Crl.X509CrlEntry this[int index] { get { throw null; } }
        public System.DateTime NextUpdate { get { throw null; } }
        public byte[] RawData { get { throw null; } }
        public byte[] Signature { get { throw null; } }
        public string SignatureAlgorithm { get { throw null; } }
        public System.DateTime ThisUpdate { get { throw null; } }
        public byte Version { get { throw null; } }
        public static Mono.Security.X509.X509Crl CreateFromFile(string filename) { throw null; }
        public byte[] GetBytes() { throw null; }
        public Mono.Security.X509.X509Crl.X509CrlEntry GetCrlEntry(Mono.Security.X509.X509Certificate x509) { throw null; }
        public Mono.Security.X509.X509Crl.X509CrlEntry GetCrlEntry(byte[] serialNumber) { throw null; }
        public bool VerifySignature(Mono.Security.X509.X509Certificate x509) { throw null; }
        public bool VerifySignature(System.Security.Cryptography.AsymmetricAlgorithm aa) { throw null; }
        public bool WasCurrent(System.DateTime instant) { throw null; }
        public partial class X509CrlEntry
        {
            internal X509CrlEntry() { }
            public Mono.Security.X509.X509ExtensionCollection Extensions { get { throw null; } }
            public System.DateTime RevocationDate { get { throw null; } }
            public byte[] SerialNumber { get { throw null; } }
            public byte[] GetBytes() { throw null; }
        }
    }
    public partial class X509Extension
    {
        protected bool extnCritical;
        protected string extnOid;
        protected Mono.Security.ASN1 extnValue;
        protected X509Extension() { }
        public X509Extension(Mono.Security.ASN1 asn1) { }
        public X509Extension(Mono.Security.X509.X509Extension extension) { }
        public Mono.Security.ASN1 ASN1 { get { throw null; } }
        public bool Critical { get { throw null; } set { } }
        public virtual string Name { get { throw null; } }
        public string Oid { get { throw null; } }
        public Mono.Security.ASN1 Value { get { throw null; } }
        protected virtual void Decode() { }
        protected virtual void Encode() { }
        public override bool Equals(object obj) { throw null; }
        public byte[] GetBytes() { throw null; }
        public override int GetHashCode() { throw null; }
        public override string ToString() { throw null; }
    }
    public sealed partial class X509ExtensionCollection : System.Collections.CollectionBase, System.Collections.IEnumerable
    {
        public X509ExtensionCollection() { }
        public X509ExtensionCollection(Mono.Security.ASN1 asn1) { }
        public Mono.Security.X509.X509Extension this[int index] { get { throw null; } }
        public Mono.Security.X509.X509Extension this[string oid] { get { throw null; } }
        public int Add(Mono.Security.X509.X509Extension extension) { throw null; }
        public void AddRange(Mono.Security.X509.X509ExtensionCollection collection) { }
        public void AddRange(Mono.Security.X509.X509Extension[] extension) { }
        public bool Contains(Mono.Security.X509.X509Extension extension) { throw null; }
        public bool Contains(string oid) { throw null; }
        public void CopyTo(Mono.Security.X509.X509Extension[] extensions, int index) { }
        public byte[] GetBytes() { throw null; }
        public int IndexOf(Mono.Security.X509.X509Extension extension) { throw null; }
        public int IndexOf(string oid) { throw null; }
        public void Insert(int index, Mono.Security.X509.X509Extension extension) { }
        public void Remove(Mono.Security.X509.X509Extension extension) { }
        public void Remove(string oid) { }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
    }
    public partial class X509Store
    {
        internal X509Store() { }
        public Mono.Security.X509.X509CertificateCollection Certificates { get { throw null; } }
        public System.Collections.ArrayList Crls { get { throw null; } }
        public string Name { get { throw null; } }
        public void Clear() { }
        public void Import(Mono.Security.X509.X509Certificate certificate) { }
        public void Import(Mono.Security.X509.X509Crl crl) { }
        public void Remove(Mono.Security.X509.X509Certificate certificate) { }
        public void Remove(Mono.Security.X509.X509Crl crl) { }
    }
    public sealed partial class X509StoreManager
    {
        internal X509StoreManager() { }
        public static Mono.Security.X509.X509Stores CurrentUser { get { throw null; } }
        public static Mono.Security.X509.X509CertificateCollection IntermediateCACertificates { get { throw null; } }
        public static System.Collections.ArrayList IntermediateCACrls { get { throw null; } }
        public static Mono.Security.X509.X509Stores LocalMachine { get { throw null; } }
        public static System.Collections.ArrayList TrustedRootCACrls { get { throw null; } }
        public static Mono.Security.X509.X509CertificateCollection TrustedRootCertificates { get { throw null; } }
        public static Mono.Security.X509.X509CertificateCollection UntrustedCertificates { get { throw null; } }
    }
    public partial class X509Stores
    {
        internal X509Stores() { }
        public Mono.Security.X509.X509Store IntermediateCA { get { throw null; } }
        public Mono.Security.X509.X509Store OtherPeople { get { throw null; } }
        public Mono.Security.X509.X509Store Personal { get { throw null; } }
        public Mono.Security.X509.X509Store TrustedRoot { get { throw null; } }
        public Mono.Security.X509.X509Store Untrusted { get { throw null; } }
        public void Clear() { }
        public Mono.Security.X509.X509Store Open(string storeName, bool create) { throw null; }
        public partial class Names
        {
            public const string IntermediateCA = "CA";
            public const string OtherPeople = "AddressBook";
            public const string Personal = "My";
            public const string TrustedRoot = "Trust";
            public const string Untrusted = "Disallowed";
            public Names() { }
        }
    }
    public partial class X520
    {
        public X520() { }
        public abstract partial class AttributeTypeAndValue
        {
            protected AttributeTypeAndValue(string oid, int upperBound) { }
            protected AttributeTypeAndValue(string oid, int upperBound, byte encoding) { }
            public Mono.Security.ASN1 ASN1 { get { throw null; } }
            public string Value { get { throw null; } set { } }
            public byte[] GetBytes() { throw null; }
            public byte[] GetBytes(byte encoding) { throw null; }
        }
        public partial class CommonName : Mono.Security.X509.X520.AttributeTypeAndValue
        {
            public CommonName() : base (default(string), default(int)) { }
        }
        public partial class CountryName : Mono.Security.X509.X520.AttributeTypeAndValue
        {
            public CountryName() : base (default(string), default(int)) { }
        }
        public partial class DnQualifier : Mono.Security.X509.X520.AttributeTypeAndValue
        {
            public DnQualifier() : base (default(string), default(int)) { }
        }
        public partial class DomainComponent : Mono.Security.X509.X520.AttributeTypeAndValue
        {
            public DomainComponent() : base (default(string), default(int)) { }
        }
        public partial class EmailAddress : Mono.Security.X509.X520.AttributeTypeAndValue
        {
            public EmailAddress() : base (default(string), default(int)) { }
        }
        public partial class GivenName : Mono.Security.X509.X520.AttributeTypeAndValue
        {
            public GivenName() : base (default(string), default(int)) { }
        }
        public partial class Initial : Mono.Security.X509.X520.AttributeTypeAndValue
        {
            public Initial() : base (default(string), default(int)) { }
        }
        public partial class LocalityName : Mono.Security.X509.X520.AttributeTypeAndValue
        {
            public LocalityName() : base (default(string), default(int)) { }
        }
        public partial class Name : Mono.Security.X509.X520.AttributeTypeAndValue
        {
            public Name() : base (default(string), default(int)) { }
        }
        public partial class Oid : Mono.Security.X509.X520.AttributeTypeAndValue
        {
            public Oid(string oid) : base (default(string), default(int)) { }
        }
        public partial class OrganizationalUnitName : Mono.Security.X509.X520.AttributeTypeAndValue
        {
            public OrganizationalUnitName() : base (default(string), default(int)) { }
        }
        public partial class OrganizationName : Mono.Security.X509.X520.AttributeTypeAndValue
        {
            public OrganizationName() : base (default(string), default(int)) { }
        }
        public partial class SerialNumber : Mono.Security.X509.X520.AttributeTypeAndValue
        {
            public SerialNumber() : base (default(string), default(int)) { }
        }
        public partial class StateOrProvinceName : Mono.Security.X509.X520.AttributeTypeAndValue
        {
            public StateOrProvinceName() : base (default(string), default(int)) { }
        }
        public partial class Surname : Mono.Security.X509.X520.AttributeTypeAndValue
        {
            public Surname() : base (default(string), default(int)) { }
        }
        public partial class Title : Mono.Security.X509.X520.AttributeTypeAndValue
        {
            public Title() : base (default(string), default(int)) { }
        }
        public partial class UserId : Mono.Security.X509.X520.AttributeTypeAndValue
        {
            public UserId() : base (default(string), default(int)) { }
        }
    }
}
namespace Mono.Security.X509.Extensions
{
    public partial class AuthorityKeyIdentifierExtension : Mono.Security.X509.X509Extension
    {
        public AuthorityKeyIdentifierExtension() { }
        public AuthorityKeyIdentifierExtension(Mono.Security.ASN1 asn1) { }
        public AuthorityKeyIdentifierExtension(Mono.Security.X509.X509Extension extension) { }
        public byte[] Identifier { get { throw null; } set { } }
        public override string Name { get { throw null; } }
        protected override void Decode() { }
        protected override void Encode() { }
        public override string ToString() { throw null; }
    }
    public partial class BasicConstraintsExtension : Mono.Security.X509.X509Extension
    {
        public const int NoPathLengthConstraint = -1;
        public BasicConstraintsExtension() { }
        public BasicConstraintsExtension(Mono.Security.ASN1 asn1) { }
        public BasicConstraintsExtension(Mono.Security.X509.X509Extension extension) { }
        public bool CertificateAuthority { get { throw null; } set { } }
        public override string Name { get { throw null; } }
        public int PathLenConstraint { get { throw null; } set { } }
        protected override void Decode() { }
        protected override void Encode() { }
        public override string ToString() { throw null; }
    }
    public partial class CertificatePoliciesExtension : Mono.Security.X509.X509Extension
    {
        public CertificatePoliciesExtension() { }
        public CertificatePoliciesExtension(Mono.Security.ASN1 asn1) { }
        public CertificatePoliciesExtension(Mono.Security.X509.X509Extension extension) { }
        public override string Name { get { throw null; } }
        protected override void Decode() { }
        public override string ToString() { throw null; }
    }
    public partial class CRLDistributionPointsExtension : Mono.Security.X509.X509Extension
    {
        public CRLDistributionPointsExtension() { }
        public CRLDistributionPointsExtension(Mono.Security.ASN1 asn1) { }
        public CRLDistributionPointsExtension(Mono.Security.X509.X509Extension extension) { }
        public System.Collections.Generic.IEnumerable<Mono.Security.X509.Extensions.CRLDistributionPointsExtension.DistributionPoint> DistributionPoints { get { throw null; } }
        public override string Name { get { throw null; } }
        protected override void Decode() { }
        public override string ToString() { throw null; }
        public partial class DistributionPoint
        {
            public DistributionPoint(Mono.Security.ASN1 dp) { }
            public DistributionPoint(string dp, Mono.Security.X509.Extensions.CRLDistributionPointsExtension.ReasonFlags reasons, string issuer) { }
            public string CRLIssuer { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
            public string Name { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
            public Mono.Security.X509.Extensions.CRLDistributionPointsExtension.ReasonFlags Reasons { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        }
        [System.FlagsAttribute]
        public enum ReasonFlags
        {
            AACompromise = 8,
            AffiliationChanged = 3,
            CACompromise = 2,
            CertificateHold = 6,
            CessationOfOperation = 5,
            KeyCompromise = 1,
            PrivilegeWithdrawn = 7,
            Superseded = 4,
            Unused = 0,
        }
    }
    public partial class ExtendedKeyUsageExtension : Mono.Security.X509.X509Extension
    {
        public ExtendedKeyUsageExtension() { }
        public ExtendedKeyUsageExtension(Mono.Security.ASN1 asn1) { }
        public ExtendedKeyUsageExtension(Mono.Security.X509.X509Extension extension) { }
        public System.Collections.ArrayList KeyPurpose { get { throw null; } }
        public override string Name { get { throw null; } }
        protected override void Decode() { }
        protected override void Encode() { }
        public override string ToString() { throw null; }
    }
    public partial class KeyAttributesExtension : Mono.Security.X509.X509Extension
    {
        public KeyAttributesExtension() { }
        public KeyAttributesExtension(Mono.Security.ASN1 asn1) { }
        public KeyAttributesExtension(Mono.Security.X509.X509Extension extension) { }
        public byte[] KeyIdentifier { get { throw null; } }
        public override string Name { get { throw null; } }
        public System.DateTime NotAfter { get { throw null; } }
        public System.DateTime NotBefore { get { throw null; } }
        protected override void Decode() { }
        public bool Support(Mono.Security.X509.Extensions.KeyUsages usage) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class KeyUsageExtension : Mono.Security.X509.X509Extension
    {
        public KeyUsageExtension() { }
        public KeyUsageExtension(Mono.Security.ASN1 asn1) { }
        public KeyUsageExtension(Mono.Security.X509.X509Extension extension) { }
        public Mono.Security.X509.Extensions.KeyUsages KeyUsage { get { throw null; } set { } }
        public override string Name { get { throw null; } }
        protected override void Decode() { }
        protected override void Encode() { }
        public bool Support(Mono.Security.X509.Extensions.KeyUsages usage) { throw null; }
        public override string ToString() { throw null; }
    }
    [System.FlagsAttribute]
    public enum KeyUsages
    {
        cRLSign = 2,
        dataEncipherment = 16,
        decipherOnly = 2048,
        digitalSignature = 128,
        encipherOnly = 1,
        keyAgreement = 8,
        keyCertSign = 4,
        keyEncipherment = 32,
        none = 0,
        nonRepudiation = 64,
    }
    public partial class NetscapeCertTypeExtension : Mono.Security.X509.X509Extension
    {
        public NetscapeCertTypeExtension() { }
        public NetscapeCertTypeExtension(Mono.Security.ASN1 asn1) { }
        public NetscapeCertTypeExtension(Mono.Security.X509.X509Extension extension) { }
        public override string Name { get { throw null; } }
        protected override void Decode() { }
        public bool Support(Mono.Security.X509.Extensions.NetscapeCertTypeExtension.CertTypes usage) { throw null; }
        public override string ToString() { throw null; }
        [System.FlagsAttribute]
        public enum CertTypes
        {
            ObjectSigning = 16,
            ObjectSigningCA = 1,
            Smime = 32,
            SmimeCA = 2,
            SslCA = 4,
            SslClient = 128,
            SslServer = 64,
        }
    }
    public partial class PrivateKeyUsagePeriodExtension : Mono.Security.X509.X509Extension
    {
        public PrivateKeyUsagePeriodExtension() { }
        public PrivateKeyUsagePeriodExtension(Mono.Security.ASN1 asn1) { }
        public PrivateKeyUsagePeriodExtension(Mono.Security.X509.X509Extension extension) { }
        public override string Name { get { throw null; } }
        protected override void Decode() { }
        public override string ToString() { throw null; }
    }
    public partial class SubjectAltNameExtension : Mono.Security.X509.X509Extension
    {
        public SubjectAltNameExtension() { }
        public SubjectAltNameExtension(Mono.Security.ASN1 asn1) { }
        public SubjectAltNameExtension(Mono.Security.X509.X509Extension extension) { }
        public SubjectAltNameExtension(string[] rfc822, string[] dnsNames, string[] ipAddresses, string[] uris) { }
        public string[] DNSNames { get { throw null; } }
        public string[] IPAddresses { get { throw null; } }
        public override string Name { get { throw null; } }
        public string[] RFC822 { get { throw null; } }
        public string[] UniformResourceIdentifiers { get { throw null; } }
        protected override void Decode() { }
        public override string ToString() { throw null; }
    }
    public partial class SubjectKeyIdentifierExtension : Mono.Security.X509.X509Extension
    {
        public SubjectKeyIdentifierExtension() { }
        public SubjectKeyIdentifierExtension(Mono.Security.ASN1 asn1) { }
        public SubjectKeyIdentifierExtension(Mono.Security.X509.X509Extension extension) { }
        public byte[] Identifier { get { throw null; } set { } }
        public override string Name { get { throw null; } }
        protected override void Decode() { }
        protected override void Encode() { }
        public override string ToString() { throw null; }
    }
}
namespace Mono.Xml
{
    [System.CLSCompliantAttribute(false)]
    public partial class MiniParser
    {
        protected int col;
        protected static string[] errors;
        protected int line;
        protected bool splitCData;
        protected int[] twoCharBuff;
        public MiniParser() { }
        protected void FatalErr(string descr) { }
        public void Parse(Mono.Xml.MiniParser.IReader reader, Mono.Xml.MiniParser.IHandler handler) { }
        public void Reset() { }
        protected static bool StrEquals(string str, System.Text.StringBuilder sb, int sbStart, int len) { throw null; }
        protected static int Xlat(int charCode, int state) { throw null; }
        public partial class AttrListImpl : Mono.Xml.MiniParser.IAttrList, Mono.Xml.MiniParser.IMutableAttrList
        {
            protected System.Collections.ArrayList names;
            protected System.Collections.ArrayList values;
            public AttrListImpl() { }
            public AttrListImpl(Mono.Xml.MiniParser.IAttrList attrs) { }
            public AttrListImpl(int initialCapacity) { }
            public bool IsEmpty { get { throw null; } }
            public int Length { get { throw null; } }
            public string[] Names { get { throw null; } }
            public string[] Values { get { throw null; } }
            public void Add(string name, string value) { }
            public void ChangeValue(string name, string newValue) { }
            public void Clear() { }
            public void CopyFrom(Mono.Xml.MiniParser.IAttrList attrs) { }
            public string GetName(int i) { throw null; }
            public string GetValue(int i) { throw null; }
            public string GetValue(string name) { throw null; }
            public void Remove(int i) { }
            public void Remove(string name) { }
        }
        public partial class HandlerAdapter : Mono.Xml.MiniParser.IHandler
        {
            public HandlerAdapter() { }
            public void OnChars(string ch) { }
            public void OnEndElement(string name) { }
            public void OnEndParsing(Mono.Xml.MiniParser parser) { }
            public void OnStartElement(string name, Mono.Xml.MiniParser.IAttrList attrs) { }
            public void OnStartParsing(Mono.Xml.MiniParser parser) { }
        }
        public partial interface IAttrList
        {
            bool IsEmpty { get; }
            int Length { get; }
            string[] Names { get; }
            string[] Values { get; }
            void ChangeValue(string name, string newValue);
            string GetName(int i);
            string GetValue(int i);
            string GetValue(string name);
        }
        public partial interface IHandler
        {
            void OnChars(string ch);
            void OnEndElement(string name);
            void OnEndParsing(Mono.Xml.MiniParser parser);
            void OnStartElement(string name, Mono.Xml.MiniParser.IAttrList attrs);
            void OnStartParsing(Mono.Xml.MiniParser parser);
        }
        public partial interface IMutableAttrList : Mono.Xml.MiniParser.IAttrList
        {
            void Add(string name, string value);
            void Clear();
            void CopyFrom(Mono.Xml.MiniParser.IAttrList attrs);
            void Remove(int i);
            void Remove(string name);
        }
        public partial interface IReader
        {
            int Read();
        }
        public partial class XMLError : System.Exception
        {
            protected int column;
            protected string descr;
            protected int line;
            public XMLError() { }
            public XMLError(string descr) { }
            public XMLError(string descr, int line, int column) { }
            public int Column { get { throw null; } }
            public int Line { get { throw null; } }
            public override string ToString() { throw null; }
        }
    }
    [System.CLSCompliantAttribute(false)]
    public partial class SecurityParser : Mono.Xml.MiniParser, Mono.Xml.MiniParser.IHandler, Mono.Xml.MiniParser.IReader
    {
        public SecurityParser() { }
        public void LoadXml(string xml) { }
        public void OnChars(string ch) { }
        public void OnEndElement(string name) { }
        public void OnEndParsing(Mono.Xml.MiniParser parser) { }
        public void OnStartElement(string name, Mono.Xml.MiniParser.IAttrList attrs) { }
        public void OnStartParsing(Mono.Xml.MiniParser parser) { }
        public int Read() { throw null; }
        public System.Security.SecurityElement ToXml() { throw null; }
    }
}
