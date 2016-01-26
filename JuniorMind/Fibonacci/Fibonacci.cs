using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Fibonacci
{
    [TestClass]
    public class Fibonacci
    {
        [TestMethod]
        public void TestFibonacciFor3()
        {
            Assert.AreEqual(1, FindFibonacciForGivenNumber(3));
        }

        public int FindFibonacciForGivenNumber(int n)
        {

            return 0;
        }
    }
}
