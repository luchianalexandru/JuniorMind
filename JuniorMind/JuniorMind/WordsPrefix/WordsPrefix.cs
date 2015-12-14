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
            Assert.AreEqual("b", prefix("a", "b"));
        }

        string prefix ( string firstWord, string secondWord)
        {

            return "a";
        }
    }
}
