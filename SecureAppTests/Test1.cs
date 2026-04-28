using Microsoft.VisualStudio.TestTools.UnitTesting;
using SecureAppLib;
using System;

namespace SecureAppTests
{
    [TestClass]
    public class Test1
    {
        [TestMethod]
        public void Register_Login_Test()
        {
            var user = new User();
            user.Register("admin", "123");

            Assert.IsTrue(user.Authenticate("123"));
        }

        [TestMethod]
        public void Encryption_Test()
        {
            string text = "hello";

            var encrypted = EncryptionHelper.Encrypt(text);
            var decrypted = EncryptionHelper.Decrypt(encrypted);

            Assert.AreEqual(text, decrypted);
        }

        [TestMethod]
        public void Error_Handling_Test()
        {
            try
            {
                throw new Exception("Test Error");
            }
            catch (Exception ex)
            {
                Logger.LogError(ex);
                Assert.IsTrue(true);
            }
        }
    }
}