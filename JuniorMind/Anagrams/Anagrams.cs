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
            Assert.AreEqual(1, NrOfTimesCharIsContained("a",'a'));
        }

        [TestMethod]
        public void IfWordContainsTest2()
        {
            Assert.AreEqual(3, NrOfTimesCharIsContained("aaabbbbcbc", 'a'));
        }

        [TestMethod]
        public void IfWordContainsTest3()
        {
            Assert.AreEqual(5, NrOfTimesCharIsContained("aaabbbbcbc", 'b'));
        }

        [TestMethod]
        public void FactorialTestFor2()
        {
            Assert.AreEqual(2, Factorial(2));
        }

        [TestMethod]
        public void FactorialTestfor3()
        {
            Assert.AreEqual(6, Factorial(3));
        }

        [TestMethod]
        public void FactorialTestfor4()
        {
            Assert.AreEqual(24, Factorial(4));
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
            Assert.AreEqual(60, CountAnagrams("aaabbc"));
        }

        [TestMethod]
        public void AnagramTestFor10Letters()
        {
            Assert.AreEqual(5040, CountAnagrams("aaaaabbbcd"));
        }   

        int Factorial(int number)
        {
            int f = 1;
            for (int i = 1; i <= number; i++) f *= i;
            return f;
        }
        
        int NrOfTimesCharIsContained(string tocheck, char c)
        {
            int contained = 0;
            for (int i = 0; i < tocheck.Length; i++)
            {
                if (tocheck[i] == c) contained++;

            }
            return contained;
        }


        int CountAnagrams(string word)
        {
            int counter = 0;
            string newstring = "";
            for (int i = 0; i < word.Length; i++)
            {
                if (NrOfTimesCharIsContained(word, word[i]) >= 1)
                {
                    if (NrOfTimesCharIsContained(newstring, word[i]) < 1)
                    {
                        newstring = newstring + word[i];
                        if (NrOfTimesCharIsContained(word, word[i]) > 1) counter += NrOfTimesCharIsContained(word, word[i]);
                    }
                }
            }
            int pfactoriale = 1;
            for (int i = 0; i < newstring.Length; i++) pfactoriale *= Factorial(NrOfTimesCharIsContained(word,newstring[i]));
            return Factorial(word.Length) / pfactoriale;
        }
    }
}
