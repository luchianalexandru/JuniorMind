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

        [TestMethod]
        public void CheckIfNumberOfDigitsIsCorrect()
        {
            Assert.AreEqual(6, NumberOfDigits("ISUPPERornot234123"));
        }

        [TestMethod]
        public void ShouldCheckIfEnoughNumbersAndUpper()
        {
            var options = new PasswordOptions { length = 8, UpperCase = 3, numbers = 4};
            var password = GeneratePass(options);
            Assert.AreEqual(3, NumberOfUpperChars(password));
            Assert.AreEqual(4, NumberOfDigits(password));

        }

        [TestMethod]
        public void ChecksIfContainedWorksAsIntended()
        {
           
            Assert.IsTrue(contained("e","abcdeeeefghijk"));

        }

        [TestMethod]
        public void ShouldCheckIfNrOfSymbolsCorrect()
        {
            var options = new PasswordOptions { length = 8, UpperCase = 3, numbers = 2, symbols = 1 };
            var tempPass = GeneratePass(options);
            int counter = 0; 
            foreach (char c in tempPass)
            {
                if (!char.IsUpper(c) && !char.IsNumber(c) && !char.IsLower(c)) counter++;
            }
            Assert.AreEqual(1, counter);

        }

        [TestMethod]
        public void CheckIfShuffleWorks()
        {
            string password = "abcdefgijklmn";
            string a = ShuffleString(password);
            string b = ShuffleString(password);
            Assert.AreEqual(a.Length, b.Length);
            Assert.AreNotEqual(a, b);
        }

        Random random = new Random();

        public struct PasswordOptions
        {
            public int length;
            public int UpperCase;
            public int numbers;
            public int symbols;
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

        private static int NumberOfDigits(string pass)
        {
            int counter = 0;
            foreach (char c in pass)
            {
                if (char.IsNumber(c)) counter++;
            }

            return counter;
        }

        string GeneratePass(PasswordOptions options)
        {
            string pass = "";
            pass += GeneratePassWithSymbols(options.symbols);
            pass += GeneratePassWithinLimits(options.UpperCase, 'A', 'Z' + 1);
            pass += GeneratePassWithinLimits(options.numbers, '0', '9' + 1);
            pass += GeneratePassWithinLimits(options.length - pass.Length, 'a', 'z' + 1);
            return ShuffleString(pass);
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

        string GeneratePassWithSymbols(int length)
        {
            string tempString = string.Empty;
            string allowedSymbols = "!@#$%^&*()_+{}[]()/\'~,;.<>";
            string notAllowedSymbols = "{}[]()/\'~,;.<>";
            for ( int i = 0; i < length; i++)
            {
                int index = random.Next(allowedSymbols.Length);
                string temp = allowedSymbols[index].ToString();
                if (contained(temp, notAllowedSymbols)) index = random.Next(allowedSymbols.Length);
                tempString += allowedSymbols[index];
            }
            
            return tempString;
        }

        bool contained ( string x, string y)
        {
            return y.Contains(x);            
        }
        
        string ShuffleString(string toShuffle)
        {
            char[] array = toShuffle.ToCharArray();
            for (int i = 0; i < toShuffle.Length; i++)
            {
                var c = array[i];
                int j = random.Next(0, array.Length);
                array[i] = array[j];
                array[j] = c;
            }
            string s = new string(array);
            return s;
        }
    }
}
