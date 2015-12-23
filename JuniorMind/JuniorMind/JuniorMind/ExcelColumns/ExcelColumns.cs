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
            Assert.AreEqual("", ColumnsInExcelForGivenNumber(0));
        }

        [TestMethod]
        public void TestForNumberUpTo26()
        {
            Assert.AreEqual("o", ColumnsInExcelForGivenNumber(15));
        }

        [TestMethod]
        public void TestForAnotherNumberUpTo26()
        {
            Assert.AreEqual("d", ColumnsInExcelForGivenNumber(4));
        }
        
        [TestMethod]
        public void TestFor28()
        {
            Assert.AreEqual("ab", ColumnsInExcelForGivenNumber(28));
        }


        [TestMethod]
        public void TestFor52()
        {
            Assert.AreEqual("az", ColumnsInExcelForGivenNumber(52));
        }

        [TestMethod]
        public void TestFor56()
        {
            Assert.AreEqual("bd", ColumnsInExcelForGivenNumber(56));
        }


        [TestMethod]
        public void TestFor92()
        {
            Assert.AreEqual("cn", ColumnsInExcelForGivenNumber(92));
        }

        [TestMethod]
        public void TestFor702()
        {
            Assert.AreEqual("zz", ColumnsInExcelForGivenNumber(702));
        }

        [TestMethod]
        public void TestFor703()
        {
            Assert.AreEqual("aaa", ColumnsInExcelForGivenNumber(703));
        }


        string ColumnsInExcelForGivenNumber(int columnNumber)
        {
            string alphabet = "abcdefghijklmnopqrstuvwxyz";
            string columnName = "";
            int dividend = columnNumber;
            int modulo = 1; 

            while(dividend != 0)
            {

                modulo = (dividend - 1) % 26;
                columnName = alphabet[modulo] + columnName;
                dividend = (dividend - modulo) / 26;

            }

            return columnName;
            
        }
    }
}
