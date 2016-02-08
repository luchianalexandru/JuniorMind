using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace WordSort
{
    [TestClass]
    public class WordSort
    {
        [TestMethod]
        public void TestMethod1()
        {
        }


        public WordCount[] SortByTextNrOfRepetition(string textToSort)
        {
            string[] array = textToSort.Split(' ');
            var wordCount = new WordCount[array.Length];

            return wordCount;
        }

        public struct WordCount
        {
            public string word;
            public int repetitions;
            public WordCount(string word, int repetitions)
            {
                this.word = word;
                this.repetitions = repetitions;
            }

        }
    }
}
