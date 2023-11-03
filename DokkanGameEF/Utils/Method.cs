using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DokkanGameEF.Utils
{
    public static class Method
    {
        public static byte[] HashPassword(string password)
        {
            byte[] salt = new byte[32];
            System.Security.Cryptography.RNGCryptoServiceProvider.Create().GetBytes(salt);

            byte[] plainTextBytes = Encoding.Unicode.GetBytes(password);

            byte[] combinedBytes = new byte[plainTextBytes.Length + salt.Length];
            System.Buffer.BlockCopy(plainTextBytes, 0, combinedBytes, 0, plainTextBytes.Length);
            System.Buffer.BlockCopy(salt, 0, combinedBytes, plainTextBytes.Length, salt.Length);

            System.Security.Cryptography.HashAlgorithm hashAlgo = new System.Security.Cryptography.SHA256Managed();
            byte[] hash = hashAlgo.ComputeHash(combinedBytes);

            byte[] hashPlusSalt = new byte[hash.Length + salt.Length];
            System.Buffer.BlockCopy(hash, 0, hashPlusSalt, 0, hash.Length);
            System.Buffer.BlockCopy(salt, 0, hashPlusSalt, hash.Length, salt.Length);
            return hashPlusSalt;
        }
    }
}
