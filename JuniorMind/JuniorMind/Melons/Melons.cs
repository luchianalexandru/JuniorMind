using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Melons
{
    [TestClass]
    public class Melons
    {
        [TestMethod]
        public void testfor3Kg()
        {
            Assert.AreEqual("The melon can't be divided by even numbers!", melon(3));
        }

        [TestMethod]
        public void testfor4Kg()
        {
            Assert.AreEqual("DA!", melon(4));
        }

        [TestMethod]
        public void testfor221Kg()
        {
            Assert.AreEqual("NU!", melon(221));
        }

        string melon(int weight)
        {
            if (weight < 4)
            {
                return "The melon can't be divided by even numbers!";
            }
            if (weight % 2 == 0)
            {
                return "DA!";
            }
            else return "NU!";
        }
    }
}
