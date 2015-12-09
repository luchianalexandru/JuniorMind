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

            if (nrIntermediar >= 10)
            {
                int multipluDeZece = nrIntermediar / 10; 
                for(int i = 0; i < multipluDeZece; i++)
                    caractereRomane += "X";
                nrIntermediar -= (multipluDeZece * 10);
            }

            if (nrIntermediar >= 9)
            {
                caractereRomane += "IX";
                nrIntermediar -= 9;
            }

            if(nrIntermediar >= 5)
            {
                caractereRomane += "V";
                nrIntermediar -= 5;
            }

            if (nrIntermediar >= 4)
            {
                caractereRomane += "IV";
                nrIntermediar -= 4;
            }

            while (nrIntermediar > 0)
                {
                    caractereRomane += "I";
                    nrIntermediar -= 1;
                }

            return caractereRomane;
        }  
  
    }

}
