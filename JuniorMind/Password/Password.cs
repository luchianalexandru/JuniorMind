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
            var password = GeneratePass(options);
            Assert.AreEqual(3, NumberOfUpperChars(password));

        }

        [TestMethod]
        public void CheckNrOfUpperCaseCharacters()
        {
            Assert.AreEqual(7, NumberOfUpperChars("ISUPPERornot"));
        }

        private static int NumberOfUpperChars(string pass)
        {
            int counter = 0;
            foreach (char c in pass)
            {
                if (char.IsUpper(c)) counter++;
            }

            return counter;
        }

        [TestMethod]
        public void ShouldCheckIfEnoughNumbersAndUpper()
        {
            var options = new PasswordOptions { length = 8, UpperCase = 3, numbers = 4};
            var tempPass = GeneratePass(options);
            int counter1 = 0;
            int counter2 = 0;
            for (int i = 0; i < tempPass.Length - 1; i++)
            {
                if (char.IsUpper(tempPass[i])) counter1++;
                if (char.IsNumber(tempPass[i])) counter2++;
            }
            Assert.AreEqual(3, counter1);
            Assert.AreEqual(4, counter2);

        }

        [TestMethod]
        public void ChecksIfContainedWorksAsIntended()
        {
           
            Assert.IsTrue(contained("e","abcdeeeefghijk"));

        }

        string GeneratePass(PasswordOptions options)
        {
            string pass = "";
            pass += GeneratePassWithinLimits(options.UpperCase, 65, 91);
            pass += GeneratePassWithinLimits(options.numbers, 48, 58);
            pass += GeneratePassWithSymbols(options.symbols);
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

        [TestMethod]
        public void ShouldCheckIfNrOfSymbolsCorrect()
        {
            var options = new PasswordOptions { length = 8, UpperCase = 3, numbers = 2, symbols = 1 };
            var tempPass = GeneratePass(options);
            int counter = 0; 
            for (int i = 0; i < tempPass.Length; i++)
            {
                if (!char.IsUpper(tempPass[i]) && (!char.IsNumber(tempPass[i]))) counter++;
            }
            Assert.AreEqual(1, counter);

        }

        string GeneratePassWithSymbols(int length)
        {
            string tempString = string.Empty;
            string allowedSymbols = "!@#$%^&*()_+{}[]()/\'~,;.<>";
            string notAllowedSymbols = "{}[]()/\'~,;.<>";
            for ( int i = 0; i < length; i++)
            {
                int index = random.Next(allowedSymbols.Length);
                string temp = allowedSymbols[index].ToString();
                if (contained(temp, notAllowedSymbols) == true ) index = random.Next(allowedSymbols.Length);
                tempString += allowedSymbols[index];
            }
            
            return tempString;
        }

        bool contained ( string x, string y)
        {
            return y.Contains(x);            
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
