using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FarmerFieldSize
{
    [TestClass]
    public class FarmerFieldSize
    {
        [TestMethod]
        public void FieldSizeTest1()
        {
            Assert.AreEqual(1, fieldSizeCalculation(1, 2));
        }

        [TestMethod]
        public void FieldSizeTest2()
        {
            Assert.AreEqual(5, fieldSizeCalculation(10, 75));
        }

        double fieldSizeCalculation(int additionalLength, int totalArea)
        {
            //functia de gradul 2: a*x*x +b*x - c = 0 
            //discriminantul functiei de gradul 2: Delta= b*b + 4*a*c
            //a = 1;
            //b = additionalLength
            //c = totalArea

            double Delta = additionalLength * additionalLength + 4 * totalArea;

            //solutia ecuatiei de gradul doi = s(x1, x2)
            // x1= (-b+ sqrt(Delta))/2a; x2 = (-b-sqrt(Delta))/2a;
            double x1 = (-additionalLength + Math.Sqrt(Delta)) / 2;
            double x2 = (-additionalLength + Math.Sqrt(Delta)) / 2;

            if (x1 > 0)
            {
                return x1;
            }
            else return x2;
        }
    }
}
