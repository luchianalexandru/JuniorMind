using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LottoSortingUsingShell
{
    [TestClass]
    public class LottoSortingUsingShell
    {
        [TestMethod]
        public void SortTest1()
        {
            int[] numbers = new int[] { 3, 1, 2, 5, 4 };
            ShellSort(numbers);
            CollectionAssert.AreEqual(new int[] { 1, 2, 3, 4, 5 }, numbers);
        }

        [TestMethod]
        public void SortTest2()
        {
            int[] numbers = new int[] { 3, 1, 2, 5, 4, 7, 10, 9, 6, 8 };
            ShellSort(numbers);
            CollectionAssert.AreEqual(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }, numbers);
        }

        [TestMethod]
        public void SortTest3()
        {
            int[] numbers = new int[] { 45, 78, 3, 75, 23 };
            ShellSort(numbers);
            CollectionAssert.AreEqual(new int[] { 3, 23, 45, 75, 78 }, numbers);
        }

        static void ShellSort(int[] numbers)
        {
            int increment = 3;
            while(increment > 0)
            {
                for( int i = 0; i < numbers.Length; i++)
                {
                    int j = i;
                    int temp = numbers[i];
                    while ((j >= increment) && (numbers[j-increment] > temp))
                    {
                        numbers[j] = numbers[j - increment];
                        j = j - increment;
                    }
                    numbers[j] = temp;
                }
                if (increment / 2 != 0) increment = increment / 2;
                else if (increment == 1) increment = 0;
                else increment = 1;
            }
        }
    }
}
