using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ArchaeologyArea
{
    [TestClass]
    public class ArchaeologyArea
    {
        [TestMethod]
        public void Firsttest()
        {
            Assert.AreEqual(7.1m, HouseArea(5, 3.1m, 6, 2.1m, 7.2m, 8));

        }

        [TestMethod]
        public void SecondTest()
        {
            Assert.AreEqual(94.8195m, HouseArea(62.31m, 10.5m, 32.4m, 9.75m, 101, 8.3m));

        }
        


        decimal HouseArea(decimal x1, decimal y1, decimal x2, decimal y2, decimal x3, decimal y3)
        {

            decimal AreaDeterminant = ((x1 * y2 * 1) + (x2 * y3 * 1) + (x3 * y1 * 1) - (x3 * y2 * 1) - (x1 * y3 * 1) - (x2 * y1 * 1));
            decimal AbsoluteValueOfDeterminant = Math.Abs(AreaDeterminant);
            return 2 * 0.5m * AbsoluteValueOfDeterminant;
        }

    }
}
