using System.Security.Cryptography;

namespace SimpleFileHashChecker {
    public static class Algorithms {
        public static readonly HashAlgorithm MD5 = new MD5CryptoServiceProvider();
        public static readonly HashAlgorithm SHA1 = new SHA1Managed();
        public static readonly HashAlgorithm SHA256 = new SHA256Managed();
        public static readonly HashAlgorithm SHA384 = new SHA384Managed();
        public static readonly HashAlgorithm SHA512 = new SHA512Managed();
        public static readonly HashAlgorithm RIPEMD160 = new RIPEMD160Managed();

        public static readonly HashAlgorithm HMACMD5 = new HMACMD5();
        public static readonly HashAlgorithm HMACSHA1 = new HMACSHA1();
        public static readonly HashAlgorithm HMACSHA256 = new HMACSHA256();
        public static readonly HashAlgorithm HMACSHA384 = new HMACSHA384();
        public static readonly HashAlgorithm HMACSHA512 = new HMACSHA512();
        public static readonly HashAlgorithm HMACRIPEMD160 = new HMACRIPEMD160();
    }
}
