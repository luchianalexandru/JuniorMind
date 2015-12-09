using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ArabToRoman
{
    [TestClass]
    public class ArabToRoman
    {
        [TestMethod]
        public void ArabToRomanTestFor100()
        {
            Assert.AreEqual("C", arabToRoman(100));
        }

        [TestMethod]
        public void ArabToRomanTestForNrNotInRange()
        {
            Assert.AreEqual("number not in range!", arabToRoman(101));
        }

        [TestMethod]
        public void ArabToRomanTestFor90()
        {
            Assert.AreEqual("XC", arabToRoman(90));
        }
   
        [TestMethod]
        public void ArabToRomanTestFor0()
        {
           Assert.AreEqual("", arabToRoman(0));
        }

        [TestMethod]
        public void ArabToRomanTestFor50()
        {
            Assert.AreEqual("L", arabToRoman(50));
        }

        [TestMethod]
        public void ArabToRomanTestFor10()
        {
            Assert.AreEqual("X", arabToRoman(10));
        }

        [TestMethod]
        public void ArabToRomanTestFor70()
        {
            Assert.AreEqual("LXX", arabToRoman(70));
        }

        [TestMethod]
        public void ArabToRomanTestFor40()
        {
            Assert.AreEqual("XL", arabToRoman(40));
        }

        string arabToRoman(int numberToConvert)
        {
            string caractereRomane = "";
            int nrIntermediar = numberToConvert;
            if (nrIntermediar > 100) return "number not in range!";
            if (nrIntermediar < 1) return "";
            if (nrIntermediar == 100) return "C";
            if (nrIntermediar >= 90)
            {
                caractereRomane += "XC";
                nrIntermediar -= 90; 
            }

            if (nrIntermediar >= 50)
            {
                caractereRomane += "L";
                nrIntermediar -= 50;
            }

            if (nrIntermediar >= 40)
            {
                caractereRomane += "XL";
                nrIntermediar -= 40;
            }

            if (nrIntermediar >= 9)
            {
                caractereRomane += "X";
                nrIntermediar -= 10;
            }
            return caractereRomane;
        }  
  
    }

    //Convertește un număr dat, între 1 și 100, în cifre romane.

    //I - 1
    //IV - 4
    //V - 5
    //IX - 9
    //X - 10
    //L - 50
    //XC - 90
    //C - 100
}
