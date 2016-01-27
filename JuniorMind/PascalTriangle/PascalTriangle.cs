using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PascalTriangle
{
    [TestClass]
    public class PascalTriangle
    {
        [TestMethod]
        public void TestsTheGeneratorFor0()
        {
            CollectionAssert.AreEqual(new int[] { 1 }, PascalTriangleGenerator(0));
        }

        [TestMethod]
        public void TestsTheGeneratorFor1()
        {
            CollectionAssert.AreEqual(new int[] { 1 , 1 }, PascalTriangleGenerator(1));
        }

        [TestMethod]
        public void TestsTheGeneratorFor2()
        {
            CollectionAssert.AreEqual(new int[] { 1, 2, 1 }, PascalTriangleGenerator(2));
        }

        [TestMethod]
        public void TestsTheGeneratorFor3()
        {
            CollectionAssert.AreEqual(new int[] { 1, 3, 3, 1 }, PascalTriangleGenerator(3));
        }

        [TestMethod]
        public void TestsTheGeneratorFor4()
        {
            CollectionAssert.AreEqual(new int[] { 1, 4, 6, 4, 1 }, PascalTriangleGenerator(4));
        }

        [TestMethod]
        public void TestsTheGeneratorFor5()
        {
            CollectionAssert.AreEqual(new int[] { 1, 5, 10, 10, 5, 1 }, PascalTriangleGenerator(5));
        }

        [TestMethod]
        public void TestsTheGeneratorFor6()
        {
            CollectionAssert.AreEqual(new int[] { 1, 6, 15, 20, 15, 6, 1 }, PascalTriangleGenerator(6));
        }

        private int[] PascalTriangleGenerator(int n)
        {
            int[] result = new int[n + 1];
            if (n == 0) return new int[] { 1 };
            result[0] = 1;
            result[n] = 1;
            int[] p = PascalTriangleGenerator(n - 1);
            for(int i = 1; i < n; i++)
            {
                result[i] = p[i - 1] + p[i];
            }
            return result;
        }
    }
}
