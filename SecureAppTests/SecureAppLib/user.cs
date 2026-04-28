using System;
using System.Security.Cryptography;
using System.Text;

namespace SecureAppLib
{
    public class User
    {
        public string Username { get; set; }
        public string HashedPassword { get; set; }

        public void Register(string username, string password)
        {
            Username = username;
            HashedPassword = Hash(password);
        }

        public bool Authenticate(string password)
        {
            return HashedPassword == Hash(password);
        }

        private string Hash(string input)
        {
            using (SHA256 sha = SHA256.Create())
            {
                var bytes = sha.ComputeHash(Encoding.UTF8.GetBytes(input));
                return Convert.ToBase64String(bytes);
            }
        }
    }
}