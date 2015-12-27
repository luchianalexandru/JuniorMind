using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Anagrams
{
    [TestClass]
    public class Anagrams
    {
        [TestMethod]
        public void IfWordContainsTest1()
        {
            Assert.AreEqual(1, Contains("a",'a'));
        }

        [TestMethod]
        public void IfWordContainsTest2()
        {
            Assert.AreEqual(3, Contains("aaabbbbcbc", 'a'));
        }

        [TestMethod]
        public void IfWordContainsTest3()
        {
            Assert.AreEqual(5, Contains("aaabbbbcbc", 'b'));
        }

        [TestMethod]
        public void FactorialTestFor2()
        {
            Assert.AreEqual(2, factorial(2));
        }

        [TestMethod]
        public void FactorialTestfor3()
        {
            Assert.AreEqual(6, factorial(3));
        }

        [TestMethod]
        public void FactorialTestfor4()
        {
            Assert.AreEqual(24, factorial(4));
        }

        int factorial(int number)
        {
            int f = 1;
            for (int i = 1; i <= number; i++) f *= i;
            return f;
        }



        int Contains(string ToCheck, char c)
        {
            int contained = 0;
            for (int i = 0; i < ToCheck.Length; i++)
            {
                if (ToCheck[i] == c) contained++;

            }
            return contained;
        }


   

        int CountAnagrams(string word)
        {
            int counter = 0;
            string NewString = "";

           

            return 0;

        }
    }
}
