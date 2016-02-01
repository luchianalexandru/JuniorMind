using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CalculatorRecursive
{
    [TestClass]
    public class CalculatorRecursive
    {
        [TestMethod]
        public void CalculatorFirstTest()
        {
            Assert.AreEqual(0, Calculate("+ 2 3"));
        }

        public double Calculate(string operation)
        {
            string[] array = operation.Split(' ');
            return 0;
        }


    }
}
