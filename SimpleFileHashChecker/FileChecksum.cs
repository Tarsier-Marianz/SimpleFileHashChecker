using System;
using System.IO;
using System.Security.Cryptography;

namespace SimpleFileHashChecker {
    public class FileChecksum {
        public static string GetHashFromFile(string fileName, HashAlgorithm algorithm) {
            try {
                using(var stream = new BufferedStream(File.OpenRead(fileName), 100000)) {
                    return BitConverter.ToString(algorithm.ComputeHash(stream)).Replace("-", string.Empty);
                }
            } catch {
                return "Error in computing hash using algorithm " +  algorithm.GetType().Name;
            }
        }
    }
}
