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

        [TestMethod]
        public void ShouldCheckIfEnoughUpperCaseChars()
        {
            var options = new PasswordOptions { length = 8, UpperCase = 3 };
            var tempPass = GeneratePass(options);
            int counter = 0;
            for(int i = 0; i < tempPass.Length - 1; i++)
            {
                if (char.IsUpper(tempPass[i])) counter++;
            }
            Assert.AreEqual(3, counter);
          
        }

        string GeneratePass(PasswordOptions options)
        {
            string pass = "";
            pass += GeneratePassWithinLimits(options.UpperCase, 65, 91);
            pass += GeneratePassWithinLimits(options.length - pass.Length, 91, 123);
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
