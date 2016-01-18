using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Password
{
    [TestClass]
    public class Password
    {
        [TestMethod]
        public void ShouldReturnAPassOfGivenLength()
        {
            var options = new PasswordOptions { length = 8 };
            string testPass = GeneratePass(options);
            Assert.AreEqual(8, testPass.Length);
        }

        string GeneratePass(PasswordOptions Options)
        {
            string pass = "";
            for (int i = 0; i < Options.length; i++)
            {
                pass += (char)random.Next();
            }
            return pass;
        }

        Random random = new Random();
        public struct PasswordOptions
        {
            public int length;
            public int UpperCase;
            public int numbers;
            public int symbols;
        }
    }
}
