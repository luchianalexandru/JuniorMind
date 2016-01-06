using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BaseConverter
{
    [TestClass]
    public class BaseConverter
    {
        [TestMethod]
        public void ConvertFromBase10ToBase2Test1()
        {
            CollectionAssert.AreEqual(new byte[] { }, ConvertFromBase10ToBase2(1));
        }

        byte[] ConvertFromBase10ToBase2(int number)
        {
            byte[] array = { };

            return array;
        }
    }
}
