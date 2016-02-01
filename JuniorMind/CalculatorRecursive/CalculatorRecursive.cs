using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CalculatorRecursive
{
    [TestClass]
    public class CalculatorRecursive
    {
        [TestMethod]
        public void CalculatorFirstTestSumm()
        {
            Assert.AreEqual(5, Calculate("+ 2 3"));
        }

        [TestMethod]
        public void CalculatorSecondTestDoubleNumbers()
        {
            Assert.AreEqual(-1, Calculate("+ 3 -4"));
        }

        public double Calculate(string operation)
        {
            int pos = 0;
            string[] array = operation.Split(' ');
            return Calculate(array, ref pos);
        }

        public double Calculate(string[] operation, ref int pos)
        {
            double result = 0;
            if (double.TryParse(operation[ref pos], out result))
            {
                pos++;
                return result;
            }
            pos++;
            return Calculate(operation, ref pos) + Calculate(operation, ref pos);
        }
    }
}
