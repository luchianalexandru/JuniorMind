using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Mushrooms
{
    [TestClass]
    public class Mushrooms
    {
        [TestMethod]
        public void redMushroomsNumberTest1()
        {
            decimal redMushrooms = CalculateRedMushroomsNr(9, 3, 2);
            Assert.AreEqual(6, redMushrooms);

        }

        [TestMethod]
        public void redMushroomsNumberTest2()
        {
            decimal redMushrooms = CalculateRedMushroomsNr(120, 30, 3);
            Assert.AreEqual(90, redMushrooms);

        }

        decimal CalculateRedMushroomsNr(decimal total, decimal whiteMushrooms, decimal redMultiplier)
        {
            return whiteMushrooms * redMultiplier;
        }
    }
}
