using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ReplaceCharWithStringRecursive
{
    [TestClass]
    public class ReplaceCharWithStringRecursive
    {

        [TestMethod]
        public void ReplaceCharWithStringTest1()
        {
            Assert.AreEqual("bc", CharReplaceWithString("a", 'a', "bc"));
        }

        [TestMethod]
        public void ReplaceCharWithStringTest2()
        {
            Assert.AreEqual("", CharReplaceWithString("", 'a', "bc"));
        }


        public static string CharReplaceWithString(string s, char a, string b)
        {
            if (s.Length < 1) return "";
            return s; 

        }
    }
}
