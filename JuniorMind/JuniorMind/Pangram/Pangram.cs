using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Pangram
{
    [TestClass]
    public class Pangram
    {
        [TestMethod]
        public void TestOnePangramIsTrue()
        {
            Assert.AreEqual(true, IsPangram("istrue"));
        }

        bool IsPangram(string Sentence)
        {

            return true;
        }
    }
}
