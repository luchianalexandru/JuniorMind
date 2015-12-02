﻿using System;
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

        string FizzSauBuzz(int number)
        {
            if (number % 3 == 0 && number % 5 == 0)
            {
                return "FizzBuzz!";
            }
            else if (number % 3 == 0)
            {
                return "Fizz!";
            }
            else if (number % 5 == 0)
            {
                return "Buzz!";
            }
            else return "Numarul nu este divizibil cu 3 sau 5";
        }
    }
}
