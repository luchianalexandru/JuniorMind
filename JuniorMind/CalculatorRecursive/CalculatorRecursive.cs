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

        [TestMethod]
        public void CalculatorSecondTestMoreOperations()
        {
            Assert.AreEqual(3, Calculate("+ + + 3 -4 7 -3"));
        }


        public double Calculate(string operation)
        {
            int pos = 0;
            string[] array = operation.Split(' ');
            return Calculate(array, ref pos);
        }

        public double Calculate(string[] operation, ref int pos)
        {
            double result;
            if (double.TryParse(operation[pos], out result))
            {
                pos++;
                return result;
            }
            string op = operation[pos];
            pos++;
            return Operation(operation, op, ref pos);
        }

        public double Operation(string[] array, string operation, ref int pos)
        {
            switch (operation)
            {
                case "+":
                    return Calculate(array, ref pos) + Calculate(array, ref pos);
                default:
                    return 0;
            }
        }
    }
}
