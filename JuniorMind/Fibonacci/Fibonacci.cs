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

        [TestMethod]
        public void TestFibonacciFor5()
        {
            Assert.AreEqual(5, FindFibonacciForGivenNumber(5));
        }

        [TestMethod]
        public void TestFibonacciFor6()
        {
            Assert.AreEqual(8, FindFibonacciForGivenNumber(6));
        }

        [TestMethod]
        public void TestFibonacciFor9()
        {
            Assert.AreEqual(34, FindFibonacciForGivenNumber(9));
        }

        public int FindFibonacciForGivenNumber(int n)
        {
            return ((n==0) || (n == 1)) ? n : FindFibonacciForGivenNumber(n - 1) + FindFibonacciForGivenNumber(n - 2);
        }
    }
}
