using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace RentDebt
{
    [TestClass]
    public class RentDebt
    {
        [TestMethod]
        public void FirstTest()
        {
            Assert.AreEqual(102, calculateDebt(100, 1));
        }

        decimal calculateDebt (int rent, int nrOfDaysLate)
        {
            int percentIfLate = 0;
            if (nrOfDaysLate <= 10)
            {
             percentIfLate = 2;
            }
            else if (nrOfDaysLate <= 30)
            {
             percentIfLate = 5;
            }
            else if (nrOfDaysLate <= 40)
            {
             percentIfLate = 10;
            }
            decimal penalty = ( rent * percentIfLate) / 100;
            return rent + penalty * nrOfDaysLate;

        }
    }
}
