using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FarmerFieldSize
{
    [TestClass]
    public class FarmerFieldSize
    {
        [TestMethod]
        public void FieldSizeTest1()
        {
            Assert.AreEqual(1, fieldSizeCalculation(1, 2));
        }

        double fieldSizeCalculation(int additionalLength, int totalArea)
        {
        return 5;
        }
    }
}
