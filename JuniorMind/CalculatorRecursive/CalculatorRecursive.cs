using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CalculatorRecursive
{
    [TestClass]
    public class CalculatorRecursive
    {
        [TestMethod]
        public void CalculatorTestSumm()
        {
            Assert.AreEqual(5, Calculate("+ 2 3"));
        }

        [TestMethod]
        public void CalculatorTestDoubleNumbers()
        {
            Assert.AreEqual(-1, Calculate("+ 3 -4"));
        }

        [TestMethod]
        public void CalculatorTestMoreThanOneOperation()
        { 
            Assert.AreEqual(3, Calculate("+ + + 3 -4 7 -3"));
        }

        [TestMethod]
        public void CalculatorTestSubstraction()
        {
            Assert.AreEqual(0, Calculate("- -1 -1"));
        }

        [TestMethod]
        public void CalculatorAnotherTestSubstraction()
        {
            Assert.AreEqual(7, Calculate("- 6 -1"));
        }

        [TestMethod]
        public void CalculatorTestSubstractionAndSum()
        {
            Assert.AreEqual(-11, Calculate("+ - + 3 -4 7 -3"));
        }

        [TestMethod]
        public void CalculatorTestAdding()
        {
            Assert.AreEqual(112.5, Calculate("* * 3 5 7.5"));
        }

        [TestMethod]
        public void CalculatorTestDivision()
        {
            Assert.AreEqual(15, Calculate("/ 112.5 7.5"));
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
                case "-":
                    return Calculate(array, ref pos) - Calculate(array, ref pos);
                case "*":
                    return Calculate(array, ref pos) * Calculate(array, ref pos);
                case "/":
                    return Calculate(array, ref pos) / Calculate(array, ref pos);
                default:
                    return 0;
            }
        }
    }
}
