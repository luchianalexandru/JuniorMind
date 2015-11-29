using System;
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

        int requiredPavementTiles(int marketLength, int marketWidth, int tileLength, int tileWidth)
        {

            int requiredTilesForMarketLength = marketLength / tileLength;
            int requiredTilesForMarketWidth = marketWidth / tileWidth; 

            if (marketLength - (requiredTilesForMarketLength*tileLength) > 0)
            {
                requiredTilesForMarketLength++;
            }

            if (marketWidth - ( requiredTilesForMarketWidth * tileWidth) > 0)
            {
                requiredTilesForMarketWidth++;
            }

            return requiredTilesForMarketLength * requiredTilesForMarketWidth;

        }


    }
}
