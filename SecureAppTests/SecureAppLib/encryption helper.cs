using System;
using System.Security.Cryptography;
using System.Text;

namespace SecureAppLib
{
    public class EncryptionHelper
    {
        private static readonly string key = "1234567890123456";

        public static string Encrypt(string text)
        {
            using (Aes aes = Aes.Create())
            {
                aes.Key = Encoding.UTF8.GetBytes(key);
                aes.IV = new byte[16];

                var encryptor = aes.CreateEncryptor();
                var input = Encoding.UTF8.GetBytes(text);
                var result = encryptor.TransformFinalBlock(input, 0, input.Length);

                return Convert.ToBase64String(result);
            }
        }

        public static string Decrypt(string cipher)
        {
            using (Aes aes = Aes.Create())
            {
                aes.Key = Encoding.UTF8.GetBytes(key);
                aes.IV = new byte[16];

                var decryptor = aes.CreateDecryptor();
                var input = Convert.FromBase64String(cipher);
                var result = decryptor.TransformFinalBlock(input, 0, input.Length);

                return Encoding.UTF8.GetString(result);
            }
        }
    }
}