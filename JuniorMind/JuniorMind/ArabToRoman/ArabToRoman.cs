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


        string arabToRoman(int numberToConvert)
    {
            if (numberToConvert > 100) return "number not in range!";
            if (numberToConvert == 100) return "C";
            if (numberToConvert >= 90) return "XC" + arabToRoman(numberToConvert - 90);
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
