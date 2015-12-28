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

        [TestMethod]
        public void AnagramTestFor1Letter()
        {
            Assert.AreEqual(1, CountAnagrams("a"));
        }

        [TestMethod]
        public void AnagramTestFor2Letters()
        {
            Assert.AreEqual(2, CountAnagrams("ab"));
        }


        [TestMethod]
        public void AnagramTestFor3Letters()
        {
            Assert.AreEqual(6, CountAnagrams("abc"));
        }

        [TestMethod]
        public void AnagramTestFor4Letters()
        {
            Assert.AreEqual(24, CountAnagrams("abcd"));
        }

        [TestMethod]
        public void AnagramTestFor5Letters()
        {
            Assert.AreEqual(120, CountAnagrams("abcde"));
        }


        [TestMethod]
        public void AnagramTestFor6Letters()
        {
            Assert.AreEqual(720, CountAnagrams("aaabbc"));
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
            for (int i = 0; i < word.Length; i++)
            {
                if (Contains(word, word[i]) >= 1)
                {
                    if (Contains(NewString, word[i]) < 1)
                    {
                        NewString = NewString + word[i];
                        if (Contains(word, word[i]) > 1) counter += Contains(word, word[i]);
                    }
                }
            }
            int pfactoriale = 1;
            for (int i = 0; i < NewString.Length; i++) pfactoriale *= factorial(Contains(NewString,NewString[i]));
            return factorial(word.Length) / pfactoriale;
        }
    }
}
