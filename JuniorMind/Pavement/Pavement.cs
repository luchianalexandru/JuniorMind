﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Pavement
{
    [TestClass]
    public class Pavement
    {
        [TestMethod]
        public void TestForFirstCase()
        {
            Assert.AreEqual(12, requiredPavementTiles(10, 7, 3, 3));
        }

        [TestMethod]
        public void TestForSecondCase()
        {
            Assert.AreEqual(2, requiredPavementTiles(6, 3, 3, 3));
        }

        [TestMethod]
        public void TestForThirdCase()
        {
            Assert.AreEqual(16, requiredPavementTiles(10, 7, 3, 2));
        }

        int requiredPavementTiles(int marketLength, int marketWidth, int tileLength, int tileWidth)
        {

            int requiredTilesForMarketLength = marketLength / tileLength;
            int requiredTilesForMarketWidth = marketWidth / tileWidth;

            requiredTilesForMarketLength = CalculateReqTilesForGivenDistance(marketLength, tileLength, requiredTilesForMarketLength);
            requiredTilesForMarketWidth = CalculateReqTilesForGivenDistance(marketWidth, tileWidth, requiredTilesForMarketWidth);
           
            return requiredTilesForMarketLength * requiredTilesForMarketWidth;

        }

        public static int CalculateReqTilesForGivenDistance(int x, int y, int z)
        {
            if (x - (z * y) > 0)
            {
                z++;
            }

            return z;
        }
    }
}
