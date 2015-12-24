using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Sportiv
{
    [TestClass]
    public class Sportiv
    {
        [TestMethod]
        public void repetitionsTest1()
        {
            decimal RepetitionsNr = CalculateTotalRepetitions(7);
            Assert.AreEqual(49, RepetitionsNr);
        }

        [TestMethod]
        public void repetitionsTest2()
        {
            decimal RepetitionsNr = CalculateTotalRepetitions(235);
            Assert.AreEqual(55225, RepetitionsNr);
        }
        decimal CalculateTotalRepetitions ( decimal MaxRepNr)
        {
          
            return MaxRepNr * MaxRepNr;
        }
    }
}
