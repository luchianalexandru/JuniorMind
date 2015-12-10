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
        public void ArabToRomanTestFor60()
        {
            Assert.AreEqual("LX", arabToRoman(60));
        }


        [TestMethod]
        public void ArabToRomanTestFor40()
        {
            Assert.AreEqual("XL", arabToRoman(40));
        }

        [TestMethod]
        public void ArabToRomanTestFor9()
        {
            Assert.AreEqual("IX", arabToRoman(9));
        }

        [TestMethod]
        public void ArabToRomanTestFor5()
        {
            Assert.AreEqual("V", arabToRoman(5));
        }

        [TestMethod]
        public void ArabToRomanTestFor6()
        {
            Assert.AreEqual("VI", arabToRoman(6));
        }

        [TestMethod]
        public void ArabToRomanTestFor3()
        {
            Assert.AreEqual("III", arabToRoman(3));
        }

        [TestMethod]
        public void ArabToRomanTestFor1()
        {
            Assert.AreEqual("I", arabToRoman(1));
        }

        [TestMethod]
        public void ArabToRomanTestFor4()
        {
            Assert.AreEqual("IV", arabToRoman(4));
        }

  

       string arabToRoman(int numberToConvert)
       {
            string caractereRomane = "";
            string[] zeci = { "X", "XX", "XXX", "XL", "L", "LX", "LXX", "LXXX", "XC", "C" };
            string[] unitati = { "I", "II", "III", "IV", "V", "VI", "VII", "VIII", "IX" };
            int remainder = numberToConvert % 10;
            if (numberToConvert > 100) return "number not in range!";
            if (numberToConvert < 1) return "";
            if (numberToConvert >= 10) caractereRomane += zeci[numberToConvert / 10 - 1];
            if (remainder > 0) caractereRomane += unitati[remainder - 1];
            return caractereRomane;
       }

}

}
