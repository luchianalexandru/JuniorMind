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
