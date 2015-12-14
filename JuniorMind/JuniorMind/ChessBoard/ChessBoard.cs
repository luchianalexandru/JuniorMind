using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ChessBoard
{
    [TestClass]
    public class ChessBoard
    {
        [TestMethod]
        public void TestforSquareOf1By1()
        {
            Assert.AreEqual(1, squaresOnBoard(1));
        }

        [TestMethod]
        public void TestforSquareOf2By2()
        {
            Assert.AreEqual(5, squaresOnBoard(2));
        }

        [TestMethod]
        public void TestforSquareOf3By3()
        {
            Assert.AreEqual(14, squaresOnBoard(3));
        }

        int squaresOnBoard ( int boardSizeLength)
        {
           int squares = 0; 
           for (int i = 1; i <= boardSizeLength; i++)
            {
                squares += i * i;
            }
           return squares;
        }
    }
}
