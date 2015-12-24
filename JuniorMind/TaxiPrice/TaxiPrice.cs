using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TaxiPrice
{
    [TestClass]
    public class TaxiPrice
    {
        [TestMethod]
        public void TestForDayShortDistance()
        {
            Assert.AreEqual(5, TaxiPriceCalculation(1, 9));
        }



        int TaxiPriceCalculation(int distanceInKm, int hour)
        {
            int pricePerKm = 0;
            if (hour > 8 && hour < 21)
            {
                if (distanceInKm >= 1 && distanceInKm <= 20)
                {
                    pricePerKm = 5;
                }
                else if (distanceInKm >= 21 && distanceInKm <= 60)
                {
                    pricePerKm = 8;
                }
                else if (distanceInKm >= 60)
                {
                    pricePerKm = 6;
                }
            }
            else if (hour >= 21)
            {

                if (distanceInKm >= 1 && distanceInKm <= 20)
                {
                    pricePerKm = 7;
                }
                else if (distanceInKm >= 21 && distanceInKm <= 60)
                {
                    pricePerKm = 10;
                }
                else if (distanceInKm >= 60)
                {
                    pricePerKm = 8;
                }
            }
            return distanceInKm * pricePerKm;
        }
    }
}

