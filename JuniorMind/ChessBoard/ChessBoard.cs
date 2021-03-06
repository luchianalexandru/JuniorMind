﻿using System;
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

        [TestMethod]
        public void TestforSquareOf4By4()
        {
            Assert.AreEqual(30, squaresOnBoard(4));
        }

        [TestMethod]
        public void TestforSquareOf8By8()
        {
            Assert.AreEqual(204, squaresOnBoard(8));
        }

        int squaresOnBoard ( int boardSizeLength)
        {

            return boardSizeLength * (boardSizeLength + 1) * (2 * boardSizeLength + 1) / 6;
           //int squares = 0; 
           //for (int i = 1; i <= boardSizeLength; i++)
           // {
           //     squares += i * i;
           // }
           //return squares;
        }
    }
}
