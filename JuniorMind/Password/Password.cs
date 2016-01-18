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
            Assert.AreEqual(8, GeneratePass(options).Length);
        }

        [TestMethod]
        public void ShouldReturnTwoDifferentPasswords()
        {
            var options = new PasswordOptions { length = 8 };
            var first = GeneratePass(options);
            var second = GeneratePass(options);
            Assert.AreNotEqual(first, second);
            Assert.AreEqual(first.Length, second.Length);
        }


        string GeneratePass(PasswordOptions Options)
        {
            string pass = "";
            pass += GeneratePassWithinLimits(Options.length, 65, 123);
            return pass;
        }

        private string GeneratePassWithinLimits(int length, int lowerLimit, int upperLimit)
        {
            string tempString = "";
            for (int i = 0; i < length; i++)
            {
                tempString += (char)random.Next(lowerLimit, upperLimit);
            }
            return tempString;
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
