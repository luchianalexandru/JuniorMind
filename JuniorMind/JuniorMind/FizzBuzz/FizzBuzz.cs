using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FizzBuzz
{
    [TestClass]
    public class FizzBuzz
    {
        [TestMethod]
        public void Fizzbuzz1()
        {
            Assert.AreEqual("Numarul nu este divizibil cu 3 sau 5", FizzSauBuzz(17));
        }

        [TestMethod]
        public void Fizzbuzz2()
        {
            Assert.AreEqual("Fizz!", FizzSauBuzz(6));
        }

        [TestMethod]
        public void Fizzbuzz3()
        {
            Assert.AreEqual("Buzz!", FizzSauBuzz(10));
        }

        [TestMethod]
        public void Fizzbuzz4()
        {
            Assert.AreEqual("FizzBuzz!", FizzSauBuzz(45));
        }

        string FizzSauBuzz(int number)
        {
            return number % 3 == 0 && number % 5 == 0 ? "FizzBuzz!" : number % 3 == 0 ? "Fizz!" : number % 5 == 0 ? "Buzz!" : "Numarul nu este divizibil cu 3 sau 5";
            //  if (number % 3 == 0 && number % 5 == 0)
            //  {
            //      return "FizzBuzz!";
            // }
            //    else if (number % 3 == 0)
            //   {
            //        return "Fizz!";
            //  }
            //   else if (number % 5 == 0)
            //   {
            //   return "Buzz!";
            // }
            //    else return "Numarul nu este divizibil cu 3 sau 5";
        }
    }
}

