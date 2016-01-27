using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace StringInverterRecursive
{
    [TestClass]
    public class StringInverterRecursive
    {
        [TestMethod]
        public void TestForReverseFail()
        {
            Assert.AreEqual("ba", ReverseString("ab"));
        }

        string ReverseString(string a)
        {
            return "";

        }
    }
}
