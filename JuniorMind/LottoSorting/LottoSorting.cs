using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LottoSorting
{
    [TestClass]
    public class LottoSorting
    {
        [TestMethod]
        public void SortTest1()
        {
            int[] numbers = new int[] { 3, 1, 2, 5, 4 };
            SortArray(numbers);
            CollectionAssert.AreEqual(new int[] { 1, 2, 3, 4, 5 }, numbers);
        }


        [TestMethod]
        public void SortTest2()
        {
            int[] numbers = new int[10] { 3, 1, 2, 5, 4, 7, 10, 9, 6, 8 };
            SortArray(numbers);
            CollectionAssert.AreEqual(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }, numbers);
        }


        public void SortArray(int[] numArray)
        {
            int j;
            for(int i = 0; i < numArray.Length; i++)
            {
                j = i;
                while(j > 0)
                {
                    if (numArray[j - 1] > numArray[j])
                    {
                        int temp = numArray[j - 1];
                        numArray[j - 1] = numArray[j];
                        numArray[j] = temp;
                        j--;
                    }
                    else break;
                }
            }
        }
    }
}
