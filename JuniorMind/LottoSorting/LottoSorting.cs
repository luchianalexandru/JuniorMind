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
            int[] numbers = { 3, 1, 2, 5, 4 };
            SortArray(numbers);
            CollectionAssert.AreEqual(new int[] { 1, 2, 3, 4, 5 }, numbers);
        }

        [TestMethod]
        public void SortTest2()
        {
            int[] numbers = { 3, 1, 2, 5, 4, 7, 10, 9, 6, 8 };
            SortArray(numbers);
            CollectionAssert.AreEqual(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }, numbers);
        }

        [TestMethod]
        public void SwapTest1()
        {
            int a = 3;
            int b = 2;
            Swap(ref a, ref b);
            Assert.AreEqual(2, a);
            Assert.AreEqual(3, b);
        }

        [TestMethod]
        public void SwapTest2()
        {
            int a = 534;
            int b = 2222;
            Swap(ref a, ref b);
            Assert.AreEqual(2222, a);
            Assert.AreEqual(534, b);
        }

        public void SortArray(int[] numArray)
        {
            for(int i = 0; i < numArray.Length; i++)
            {
                for ( int j = i; j > 0; j--)
                {
                    if (numArray[j] < numArray[j-1])
                         Swap(ref numArray[j], ref numArray[j - 1]);                   
                }
            }
        }

        private static void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }
    }
}
