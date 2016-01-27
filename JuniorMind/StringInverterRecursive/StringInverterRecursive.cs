using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace StringInverterRecursive
{
    [TestClass]
    public class StringInverterRecursive
    {
        [TestMethod]
        public void TestForReverse1()
        {
            Assert.AreEqual("ba", ReverseString("ab"));
        }

        [TestMethod]
        public void TestForReverse2()
        {
            Assert.AreEqual("leber", ReverseString("rebel"));
        }

        string ReverseString(string a)
        {
            if (a.Length > 0)
                return a[a.Length - 1] + ReverseString(a.Substring(0, a.Length - 1));
            else return a;
        }
    }
}
