using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LotteryChances
{
    [TestClass]
    public class LotteryChances
    {
        [TestMethod]
        public void LottoChance1of1()
        {
            Assert.AreEqual(1, CalculateLotteryOdds(1, 1));
        }

        [TestMethod]
        public void LottoChance1of2()
        {
            Assert.AreEqual(0.5, CalculateLotteryOdds(1, 2));
        }

        [TestMethod]
        public void LottoChance1of3()
        {
            Assert.AreEqual(0.3333333d, CalculateLotteryOdds(1, 3),0.0000001);
        }

        [TestMethod]
        public void LottoChance1of4()
        {
            Assert.AreEqual(0.25d, CalculateLotteryOdds(1, 4), 0.01);
        }

        double CalculateLotteryOdds(double NrOfPicks, double RangeOfNrToPick)
        {
            double chance;
            chance = NrOfPicks / RangeOfNrToPick;
            return chance;

        }
    }
}
