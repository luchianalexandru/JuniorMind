using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace WordSort
{
    [TestClass]
    public class WordSort
    {
        [TestMethod]
        public void Test1()
        {
            var structArray = new WordCount[] { new WordCount("abc", 2), new WordCount("bca", 1)};
            CollectionAssert.AreEqual(structArray, SortByTextNrOfRepetition("abc abc bca"));
        }


        public WordCount[] SortByTextNrOfRepetition(string textToSort)
        {
            string[] array = textToSort.Split(' ');
            var wordCount = new WordCount[array.Length];

            for (int i = 0; i < array.Length; i++)
            {
                int count = 0;
                for (int j = 0; j < array.Length; j++)
                {

                    if (array[i] == array[j])
                        count++;
                }
                wordCount[i].word = array[i];
                wordCount[i].repetitions = count;
            }
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
