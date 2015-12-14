using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CubeSuffix
{
    [TestClass]
    public class CubeSuffix
    {
        [TestMethod]
        public void FirstTestForCube()
        {
            Assert.AreEqual(192, cubeForGivenNumber(1));
        }

        [TestMethod]
        public void SecondTestForCube()
        {
            Assert.AreEqual(442, cubeForGivenNumber(2));
        }

        [TestMethod]
        public void ThirdTestForCube()
        {
            Assert.AreEqual(692, cubeForGivenNumber(3));
        }


        decimal cubeForGivenNumber ( int number)
        {
           int numberOfCubes = 0;
          // int numberOfIterations = 0;
           for (int i = 1;;i++)
            {
                if ( i*i*i % 1000 == 888)
                {
                    numberOfCubes+=1;
                }
                if (numberOfCubes == number)
                    return i;
            //    numberOfIterations = i;
            }
            //return numberOfIterations;
        }
    }
}
