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

        string ColumnsInExcelForGivenNumber(int number)
        {

            return "";

        }
    }
}
