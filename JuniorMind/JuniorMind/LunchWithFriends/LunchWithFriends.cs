using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LunchWithFriends
{
    [TestClass]
    public class LunchWithFriends
    {
        [TestMethod]
        public void TestFor4And6()
        {
            Assert.AreEqual(12, CalculateLeastCommonMultiplier(4, 6));
        }

        [TestMethod]
        public void TestFor7And11()
        {
            Assert.AreEqual(77, CalculateLeastCommonMultiplier(7, 11));
        }

        [TestMethod]
        public void TestFor9And12()
        {
            Assert.AreEqual(36, CalculateLeastCommonMultiplier(9, 12));
        }

        [TestMethod]
        public void TestFor12And32()
        {
            Assert.AreEqual(96, CalculateLeastCommonMultiplier(12, 32));
        }

        [TestMethod]
        public void TestFor73And54()
        {
            Assert.AreEqual(3942, CalculateLeastCommonMultiplier(73, 54));
        }

        public int CalculateLeastCommonMultiplier(int nr1, int nr2)
        {
            int max = Math.Max(nr1, nr2);
            for(int i= max + 1; ;i++)
            {
                if ( i%nr1 == 0 && i%nr2 == 0)
                {
                    return i;
                }

            }

        }
    }
}
