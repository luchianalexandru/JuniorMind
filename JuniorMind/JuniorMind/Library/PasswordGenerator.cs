using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Library
{
    public class PasswordGenerator
    {
        private readonly Random random = new Random();

        private int NumberOfUpperChars(string pass)
        {
            int counter = 0;
            foreach (char c in pass)
            {
                if (char.IsUpper(c)) counter++;
            }

            return counter;
        }

        private int NumberOfDigits(string pass)
        {
            int counter = 0;
            foreach (char c in pass)
            {
                if (char.IsNumber(c))
                {
                    counter++;
                }
            }

            return counter;
        }

        public string GeneratePass(PasswordOptions options)
        {
            StringBuilder passBuilder = new StringBuilder();
            passBuilder.Append(GeneratePassWithSymbols(options.Symbols, options.Ambiguous));
            passBuilder.Append(GeneratePassWithinLimits(options.UpperCase, 'A', 'Z' + 1, options.Similar));
            passBuilder.Append(GeneratePassWithinLimits(options.Numbers, '0', '9' + 1, options.Similar));
            passBuilder.Append(GeneratePassWithinLimits(options.Length - passBuilder.Length, 'a', 'z' + 1, options.Similar));

            return ShuffleString(passBuilder.ToString());
        }

        private string GeneratePassWithinLimits(int length, int lowerLimit, int upperLimit, bool similar)
        {
            string tempString = "";
            string notAllowedCharacters = "1lLoO0";

            for (int i = 0; i < length; i++)
            {
                char c = (char)random.Next(lowerLimit, upperLimit);
                while (similar && Contained(c, notAllowedCharacters))
                {
                    c = (char)random.Next(lowerLimit, upperLimit);
                }
                tempString += c;
            }
            return tempString;
        }

        private string GeneratePassWithSymbols(int length, bool ambiguous)
        {
            string tempString = string.Empty;
            string allowedSymbols = "!@#$%^&*()_+{}[]()/\'~,;.<>" + '"';
            string notAllowedSymbols = "{}[]()/\'~,;.<> " + '"';
            for (int i = 0; i < length; i++)
            {
                int index = random.Next(0, allowedSymbols.Length);
                char temp = allowedSymbols[index];
                while (ambiguous && Contained(temp, notAllowedSymbols))
                {
                    index = (char)random.Next(0, allowedSymbols.Length);
                    temp = allowedSymbols[index];
                }
                tempString += allowedSymbols[index];
            }
            return tempString;
        }

        private bool Contained(char x, string y)
        {
            foreach (char item in y)
            {
                if (item == x) return true;
            }
            return false;
        }

        private string ShuffleString(string toShuffle)
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