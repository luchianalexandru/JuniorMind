using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ExcelColumns
{
    [TestClass]
    public class ExcelColumns
    {
        [TestMethod]
        public void FirstTestWithNothingInString()
        {
            Assert.AreEqual("", ColumnsInExcelForGivenNumber(27));
        }

        [TestMethod]
        public void TestForNumberUpTo26()
        {
            Assert.AreEqual("p", ColumnsInExcelForGivenNumber(15));
        }

        string ColumnsInExcelForGivenNumber(int number)
        {
            string column = "";
            string alphabet = "abcdefghijklmnopqrstuvwxyz";

            if (number <= 26) return column += alphabet[number];

            return "";

        }
    }
}
