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

        [TestMethod]
        public void TestsTheStructCountForTwoElementsWithMoreRepetitions()
        {
            var structArray = new WordCount[] { new WordCount("abc", 4), new WordCount("bca", 2) };
            CollectionAssert.AreEqual(structArray, SortByTextNrOfRepetition("abc bca abc bca abc abc"));
        }

        [TestMethod]
        public void TestsTheStructCountForThreeElements()
        {
            var structArray = new WordCount[] { new WordCount("abc", 4), new WordCount("bca", 2), new WordCount("cde", 1) };
            CollectionAssert.AreEqual(structArray, SortByTextNrOfRepetition("cde bca abc abc bca abc abc"));
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
            Sort(ref wordCount);
            return wordCount;
        }

        public void Sort(ref WordCount[] wordCount)
        {
            for (int i = 0; i < wordCount.Length; i++)
            {
                for (int j = wordCount.Length - 1; j > i; j--)
                {
                    if (wordCount[i].repetitions < wordCount[j].repetitions)
                    {
                        Swap(ref wordCount[i], ref wordCount[j]);
                    }
                }
            }
        }


        [TestMethod]
        public void SwapTest()
        {
            var structArray = new WordCount[] { new WordCount("abc", 2), new WordCount("bca", 1) };
            var expectedArray = new WordCount[] { new WordCount("bca", 1), new WordCount("abc", 2) };
            Swap(ref structArray[0], ref structArray[1]);
            CollectionAssert.AreEqual(expectedArray, structArray);
        }

        private void Swap(ref WordCount first, ref WordCount second)
        {
            WordCount temp = first;
            first = second;
            second = temp;
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
