using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Pangram
{
    [TestClass]
    public class Pangram
    {
        [TestMethod]
        public void TestOnePangramIsTrue()
        {
            Assert.AreEqual(true, IsPangram("abcdefghijklmnopqrstuvwxyz"));
        }

        bool IsPangram(string sentence)
        {
            string[] pangramContents = new string[26] { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z" };
            return SentenceLength(sentence);
        }

        private static bool SentenceLength(string sentence)
        {
            if (sentence.Length < 26)
            {
                return false;
            }
            else return true;
        }
    }
}
