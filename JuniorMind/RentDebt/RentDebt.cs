﻿using System;
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

        [TestMethod]
        public void SecondTest()
        {
            Assert.AreEqual(110, calculateDebt(100, 5));
        }


        [TestMethod]
        public void ThirdTest()
        {
            Assert.AreEqual(555, calculateDebt(300, 17));
        }

        [TestMethod]
        public void ForthTest()
        {
            Assert.AreEqual(2300, calculateDebt(500, 36));
        }

        decimal calculateDebt (int rent, int nrOfDaysLate)
        {

            int percentIfLate = nrOfDaysLate <= 10 ? 2 : nrOfDaysLate <= 30 ? 5 : 10; 
            decimal penalty = ( rent * percentIfLate) / 100;
            return rent + penalty * nrOfDaysLate;

        }
    }
}
