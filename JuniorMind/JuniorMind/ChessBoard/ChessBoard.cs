using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ChessBoard
{
    [TestClass]
    public class ChessBoard
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(1, squaresOnBoard(2));
        }

        int squaresOnBoard ( int boardSizeLength)
        {
            return 0;
        }
    }
}
