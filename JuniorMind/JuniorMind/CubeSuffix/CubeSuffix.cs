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

        decimal cubeForGivenNumber ( int number)
        {
           int numberOfCubes = 0;
           int numberOfIterations = 0;
           for (int i = 1;numberOfCubes <= number;i++)
            {
                if ( i*i*i % 1000 == 888)
                {
                    numberOfCubes+=1;
                    numberOfIterations = i;
                } 
            }
            return numberOfIterations;
        }
    }
}
