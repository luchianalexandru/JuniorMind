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

        int[] PascalTriangleGenerator(int n)
        {
            int[] result = new int[n + 1];
            result[0] = 1;
            result[n] = 1;
            return result;
        }
    }
}
