using Konscious.Security.Cryptography;
using System;

using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;


namespace CoreLibrary.Utility
{

    public static class HashingUtility
    {
        private const int SaltSize = 16;   // 16-byte salt
        private const int HashSize = 32;   // 32-byte hash
        private const int Iterations = 3;  // Number of iterations
        private const int MemorySize = 65536; // Memory in KB
        private const int Parallelism = 4; // Number of CPU threads

        /// <summary>
        /// Generates a cryptographically secure random salt.
        /// </summary>
        public static string GenerateSalt()
        {
            byte[] salt = new byte[SaltSize];
            using (var rng = RandomNumberGenerator.Create())
            {
                rng.GetBytes(salt);
            }
            return Encoding.UTF8.GetString(salt);
        }

        /// <summary>
        /// Computes a hash from a password and salt.
        /// </summary>
        /// <param name="password"></param>
        /// <param name="salt"></param>
        /// <param name="storeSaltWithHash">if true it retun hash:salt</param>
        /// <returns>hashed string</returns>
        public static string ComputeHash(string password, ref string salt, bool storeSaltWithHash)
        {
            if (salt == null)
                salt = GenerateSalt();
            byte[] hash = ComputeHashWithSalt(password, salt);

            // Store in Base64 format: hash:salt
            if(storeSaltWithHash)
                return Convert.ToBase64String(hash) + ":" + salt;
            else
                return Convert.ToBase64String(hash);
        }

        /// <summary>
        /// Verifies if an entered password matches the stored hash.
        /// </summary>
        public static bool VerifyHash(string enteredText, string storedHash, string storedSalt = null)
        {
            // Split stored value (Hash:Salt)
            string[] parts = storedHash.Split(':');
            if (parts.Length < 2 && storedHash == null) // invalid argument
                return false;
            byte[] storedHashBytes = null;


            if (parts.Length > 1) // stored value is in Base64 format
            {
                storedHashBytes = Convert.FromBase64String(parts[0]);
                storedSalt = parts[1];
            }
            else
            {
                storedHashBytes = Convert.FromBase64String(storedHash);
            }

            // Rehash entered password using stored salt
            byte[] enteredHash = ComputeHashWithSalt(enteredText, storedSalt);

            // Compare hashes securely
            return FixedTimeEquals(storedHashBytes, enteredHash);
        }

        public static bool FixedTimeEquals(byte[] a, byte[] b)
        {
            if (a.Length != b.Length)
                return false;

            int result = 0;
            for (int i = 0; i < a.Length; i++)
            {
                result |= a[i] ^ b[i]; // XOR each byte and OR results
            }

            return result == 0;
        }

        /// <summary>
        /// Hashes a password with a provided salt using Argon2id.
        /// </summary>
        private static byte[] ComputeHashWithSalt(string password, string salt)
        {
            using (var argon2 = new Argon2id(Encoding.UTF8.GetBytes(password)))
            {
                argon2.Salt = Encoding.UTF8.GetBytes(salt);
                argon2.DegreeOfParallelism = Parallelism;
                argon2.MemorySize = MemorySize;
                argon2.Iterations = Iterations;

                return argon2.GetBytes(HashSize);
            }
        }

        public static bool IsLooksLikeHash(string value)
        {
            string argon2Pattern = @"^[A-Za-z0-9+/=]{43,}$";
            return value.Contains(":") || Regex.IsMatch(value, argon2Pattern);
        }
    }
}


