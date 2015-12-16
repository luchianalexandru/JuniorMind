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
            Assert.AreEqual(0, CalculateBiggestCommonMultiplier(4, 6));
        }


        public int CalculateBiggestCommonMultiplier(int nr1, int nr2)
        {
            return 0;

        }
    }
}
