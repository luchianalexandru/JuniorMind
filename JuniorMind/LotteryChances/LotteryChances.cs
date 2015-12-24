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

        [TestMethod]
        public void LottoChance6of49()
        {
            Assert.AreEqual(0.00000007151123842018516d, CalculateLotteryOdds(6, 49), 0.00000000001);
        }

        [TestMethod]
        public void LottoChance5of49()
        {
            Assert.AreEqual(0.0000005244157484146906d, CalculateLotteryOdds(5, 49), 0.00000000001);
        }


        double CalculateLotteryOdds(double NrOfPicks, double RangeOfNrToPick)
        {
            double chance = 1;
            for(int i=0 ; i < NrOfPicks ;i++)
            {

                chance *= (NrOfPicks - i) / (RangeOfNrToPick - i);
            }
            return chance;

        }
    }
}
