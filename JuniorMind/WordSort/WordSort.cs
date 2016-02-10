using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace WordSort
{
    [TestClass]
    public class WordSort
    {
        [TestMethod]
        public void TestsTheStructCountForTwoElements()
        {
            var structArray = new WordCount[] { new WordCount("abc", 2), new WordCount("bca", 1) };
            CollectionAssert.AreEqual(structArray, SortByTextNrOfRepetition("abc bca abc"));
        }


        public WordCount[] SortByTextNrOfRepetition(string textToSort)
        {
            string[] array = textToSort.Split(' ');
            WordCount[] wordCount = new WordCount[0];
            string[] tempArray = new string[0];

            while (array.Length > 0)
            {
                int count = 1;
                for (int j = 1; j < array.Length; j++)
                {
                    if (array[0] == array[j]) count++;
                    else
                    {
                        Array.Resize(ref tempArray, tempArray.Length + 1);
                        tempArray[tempArray.Length - 1] = array[j];
                    }

                }
                Array.Resize(ref wordCount, wordCount.Length + 1);
                wordCount[wordCount.Length - 1] = new WordCount(array[0], count);
                array = tempArray;
                tempArray = new string[0];
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
