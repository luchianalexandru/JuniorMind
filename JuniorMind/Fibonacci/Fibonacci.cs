using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Fibonacci
{
    [TestClass]
    public class Fibonacci
    {

        [TestMethod]
        public void TestFibonacciFor0()
        {
            Assert.AreEqual(0, FindFibonacciForGivenNumber(0));
        }

        [TestMethod]
        public void TestFibonacciFor1()
        {
            Assert.AreEqual(1, FindFibonacciForGivenNumber(1));
        }

        [TestMethod]
        public void TestFibonacciFor2()
        {
            Assert.AreEqual(1, FindFibonacciForGivenNumber(2));
        }

        [TestMethod]
        public void TestFibonacciFor3()
        {
            Assert.AreEqual(2, FindFibonacciForGivenNumber(3));
        }

        public int FindFibonacciForGivenNumber(int n)
        {
            if ((n == 0) || (n == 1)) return n;
            return FindFibonacciForGivenNumber(n - 1) + FindFibonacciForGivenNumber(n - 2);  
        }
    }
}
