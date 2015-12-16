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
            Assert.AreEqual(12, CalculateBiggestCommonMultiplier(4, 6));
        }

        [TestMethod]
        public void TestFor7And11()
        {
            Assert.AreEqual(77, CalculateBiggestCommonMultiplier(7, 11));
        }

        [TestMethod]
        public void TestFor9And12()
        {
            Assert.AreEqual(36, CalculateBiggestCommonMultiplier(9, 12));
        }

        public int CalculateBiggestCommonMultiplier(int nr1, int nr2)
        {

            for(int i=1; ;i++)
            {
                if ( i%nr1 == 0 && i%nr2 == 0)
                {
                    return i;
                }

            }

        }
    }
}
