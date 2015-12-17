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

        [TestMethod]
        public void TestTwoSentenceIsShorterThan26()
        {
            Assert.AreEqual(false, IsPangram("abcdefghijklmnopqrstuvwxy"));
        }
        
       [TestMethod]
        public void TestThreeDifferentPangramLongerThan26()
        {
            Assert.AreEqual(true, IsPangram("thequickbrownfoxjumpsoverthelazydog"));
        }

        [TestMethod]
        public void TestFourSentenceIsExactly26()
        {
            Assert.AreEqual(true, IsPangram("mrjocktvquizphdbagsfewlynx"));
        }


        bool IsPangram(string sentence)
        {
            string[] pangramContents = new string[26] { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z" };
            if (!SentenceLength(sentence))
            {
                return false;
            }
            for(int i=0;i<sentence.Length ;i++)
            {
                if (!sentence.Contains(pangramContents[i]))
                {
                    return false;

                }
            }
            return true;
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
