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
            Assert.AreEqual("", CharReplaceWithString("", 'a', "bc"));
        }

        [TestMethod]
        public void ReplaceCharWithStringTest2()
        {
            Assert.AreEqual("bc", CharReplaceWithString("a", 'a', "bc"));
        }

        [TestMethod]
        public void ReplaceCharWithStringTest3()
        {
            Assert.AreEqual("abefd", CharReplaceWithString("abcd", 'c', "ef"));
        }

        [TestMethod]
        public void ReplaceCharWithStringTest4()
        {
            Assert.AreEqual("chechecheche", CharReplaceWithString("chchchch", 'h', "he"));
        }


        public static string CharReplaceWithString(string s, char toReplace, string replacement)
        {
            if (s.Length < 1) return "";
            string result = "";
            if (s[0] == toReplace) result = replacement;
            else result = s[0].ToString(); 
            return result + CharReplaceWithString(s.Substring(1, s.Length-1), toReplace, replacement); 

        }
    }
}
