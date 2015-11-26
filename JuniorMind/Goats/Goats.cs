﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Goats
{
    [TestClass]
    public class Goats
    {
        [TestMethod]
        public void FirstRandomTest()
        {
            Decimal Kilo = kilosEatenByGoatsInGivenDayNumber(5, 2, 3, 2, 1);
            Assert.AreEqual(2.4m, Kilo);

        }

        decimal kilosEatenByGoatsInGivenDayNumber(decimal initialGoatsNr, decimal initialDaysNr, decimal initialKgEaten, decimal givenGoatsNr, decimal givenDaysNr)
        {
            return (initialDaysNr * givenGoatsNr * initialKgEaten) / (givenDaysNr * initialGoatsNr);
        }
    }
}

