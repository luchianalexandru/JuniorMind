using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace WordsPrefix
{
    [TestClass]
    public class WordsPrefix
    {
        //[TestMethod]
        //public void FirstTest()
        //{
        //    Assert.AreEqual("a", wordsPrefix("a", "ab"));
        //}

        [TestMethod]
        public void SecondTestForNoPrefix()
        {
            Assert.AreEqual("", wordsPrefix("a", "b"));
        }

        string wordsPrefix ( string firstWord, string secondWord)
        {
            string prefix = "";
            return prefix;
        }
    }
}
