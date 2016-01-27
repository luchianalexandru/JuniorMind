using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PascalTriangle
{
    [TestClass]
    public class PascalTriangle
    {
        [TestMethod]
        public void TestThatFails()
        {
            CollectionAssert.AreEqual(new int[] { 1 }, PascalTriangleGenerator(0));
        }

        int[] PascalTriangleGenerator(int n)
        {
            int[] result = new int[n + 1];
            return result;
        }
    }
}
