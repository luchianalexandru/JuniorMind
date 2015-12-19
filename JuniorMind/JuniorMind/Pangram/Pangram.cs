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
            Assert.AreEqual(true, IsPangram("MrJockTvQuizPhdBagsFewLynx"));
        }


        bool IsPangram(string sentence)
        {
            string s = sentence.ToLower();
            string[] pangramContents = new string[26] { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z" };
            if (!SentenceLength(s))
            {
                return false;
            }

            for(int i=0;i<pangramContents.Length ;i++)
            {
                if (!s.Contains(pangramContents[i]))
                {
                    return false;
                }
            }
            return true;
        }

        private static bool SentenceLength(string s)
        {
            if (s.Length < 26)
            {
                return false;
            }
            else return true;
        }
    }
}
