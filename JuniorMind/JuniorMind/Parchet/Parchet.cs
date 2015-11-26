using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Parchet
{
    [TestClass]
    public class Parchet
    {
        [TestMethod]
        public void NecessaryWoodTiles1()
        {
            decimal requiredTylesNr = CalculateWoodTilesNeeded(5, 4, 3, 0.5m);
            Assert.AreEqual(15.333333333333333333333333333m, requiredTylesNr);
        }

        [TestMethod]
        public void NecessaryWoodTiles2()
        {
            decimal requiredTylesNr = CalculateWoodTilesNeeded(15, 12, 3, 0.5m);
            Assert.AreEqual(138, requiredTylesNr);
        }


        decimal CalculateWoodTilesNeeded(decimal roomLength, decimal roomWidth, decimal woodTileLength, decimal woodTilewidth)
        {
            return ( roomLength * roomWidth * 1.15m) / ( woodTileLength * woodTilewidth);
        }
    }
}
