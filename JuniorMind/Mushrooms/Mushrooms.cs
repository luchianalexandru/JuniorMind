﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Mushrooms
{
    [TestClass]
    public class Mushrooms
    {
        [TestMethod]
        public void redMushroomsNumberTest1()
        {
            decimal redMushrooms = CalculateRedMushroomsNr(9, 2);
            Assert.AreEqual(6, redMushrooms);

        }

        [TestMethod]
        public void redMushroomsNumberTest2()
        {
            decimal redMushrooms = CalculateRedMushroomsNr(120, 3);
            Assert.AreEqual(90, redMushrooms);

        }


        [TestMethod]
        public void redMushroomsNumberTest3()
        {
            decimal redMushrooms = CalculateRedMushroomsNr(540, 5);
            Assert.AreEqual(450, redMushrooms);

        }

        decimal CalculateRedMushroomsNr(decimal total, decimal redMultiplier)
        {
            decimal a = total / (1 + redMultiplier); 
            return a * redMultiplier; 
        }
    }
}
