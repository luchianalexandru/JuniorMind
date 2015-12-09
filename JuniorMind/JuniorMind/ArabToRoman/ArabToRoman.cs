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


        string arabToRoman(int numberToConvert)
        {
            if (numberToConvert > 100) return "number not in range!";
            if (numberToConvert < 1) return "";
            if (numberToConvert == 100) return "C";
            if (numberToConvert >= 90) return "XC" + arabToRoman(numberToConvert - 90);
            if (numberToConvert >= 50) return "L" + arabToRoman(numberToConvert - 50);
            if (numberToConvert >= 10) return "X" + arabToRoman(numberToConvert - 10);
            return "";
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
