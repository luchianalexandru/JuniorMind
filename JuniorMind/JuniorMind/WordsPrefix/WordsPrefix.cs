using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace WordsPrefix
{
    [TestClass]
    public class WordsPrefix
    {
        [TestMethod]
        public void FirstTest()
        {
            Assert.AreEqual("a", wordsPrefix("a", "ab"));
        }

        [TestMethod]
        public void SecondTestForNoPrefix()
        {
            Assert.AreEqual("", wordsPrefix("a", "b"));
        }

        [TestMethod]
        public void ThirdTestForABCDE()
        {
            Assert.AreEqual("abc", wordsPrefix("abc", "abcde"));
        }

        [TestMethod]
        public void FourthTestForSeaShells()
        {
            Assert.AreEqual("seashells", wordsPrefix("seashells", "seashellsontheseashore"));
        }



        string wordsPrefix ( string firstWord, string secondWord)
        {
            string prefix = "";
            int shortestWord = Math.Min(firstWord.Length, secondWord.Length);
            for ( int i = 0; i < shortestWord; i++)
            {
                if (firstWord[i] == secondWord[i]) prefix += firstWord[i];
                else break;
            }
            return prefix;
        }
    }
}
