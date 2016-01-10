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
            CollectionAssert.AreEqual(new byte[] { 1, 0 }, ConvertFromBase10ToBase2(2));
        }

        [TestMethod]
        public void ConvertFromBase10ToBase2Test2()
        {
            CollectionAssert.AreEqual(new byte[] { 1, 0, 0 }, ConvertFromBase10ToBase2(4));
        }

        [TestMethod]
        public void ConvertFromBase10ToBase2Test3()
        {
            CollectionAssert.AreEqual(new byte[] { 1, 0, 1 }, ConvertFromBase10ToBase2(5));
        }

        [TestMethod]
        public void ConvertFromBase10ToBase2Test4()
        {
            CollectionAssert.AreEqual(new byte[] { 1, 0, 0, 1 }, ConvertFromBase10ToBase2(9));
        }

        [TestMethod]
        public void ConvertFromBase10ToBase2Test5()
        {
            CollectionAssert.AreEqual(new byte[] { 1, 0, 0, 0, 1 }, ConvertFromBase10ToBase2(17));
        }

        [TestMethod]
        public void ConvertFromBase10ToBase2Test6()
        {
            CollectionAssert.AreEqual(new byte[] { 1, 1, 0, 1, 1, 1, 1, 1 }, ConvertFromBase10ToBase2(223));
        }
        
        [TestMethod]
        public void InverterTest1()
        {
            CollectionAssert.AreEqual(new byte[] { 3, 2, 1 }, Inverter(new byte[] { 1, 2, 3 }));
        }

        [TestMethod]
        public void InverterTest2()
        {
            CollectionAssert.AreEqual(new byte[] { 3, 9, 7 }, Inverter(new byte[] { 7, 9, 3 }));
        }

        [TestMethod]
        public void NotOperationTest1()
        {
            CollectionAssert.AreEqual(new byte[] { 1, 0 }, NotOperation(new byte[] { 0, 1 }));
        }

        [TestMethod]
        public void NotOperationTest2()
        {
            CollectionAssert.AreEqual(new byte[] { 0, 1, 1 }, NotOperation(new byte[] { 1, 0, 0 }));
        }

        [TestMethod]
        public void NotOperationTest3()
        {
            CollectionAssert.AreEqual(new byte[] { 0, 1, 1, 1, 0 }, NotOperation(new byte[] { 1, 0, 0, 0, 1 }));
        }

        [TestMethod]
        public void NotOperationTest4()
        {
            CollectionAssert.AreEqual(new byte[] { 0, 0, 1, 0, 0, 0, 0, 0 }, NotOperation(new byte[] { 1, 1, 0, 1, 1, 1, 1, 1 }));
        }

        byte[] ConvertFromBase10ToBase2(int number)
        {
            byte[] array = { };

            while (number > 0)
            {
                Array.Resize(ref array, array.Length + 1);
                array[array.Length - 1] = (byte)(number % 2);
                number /= 2;
            }

            return Inverter(array);
        }


        private static byte[] Inverter(byte[] array)
        {
            byte[] reversedArray = new byte[array.Length];
            for (int i = 0; i < array.Length; i++) reversedArray[i] = array[array.Length - 1 - i];
            return reversedArray;
        }
                

        byte[] NotOperation(byte[] array)
        {
            byte[] notArray = new byte[array.Length];
            for(int i = 0; i < notArray.Length; i++) notArray[i] = array[i] == (byte)0 ? (byte)1 : (byte)0;
            return notArray;
        }

        [TestMethod]
        public void AndOperationTest1()
        {
            CollectionAssert.AreEqual(new byte[] { 1, 1}, AndOperation(new byte[] { 1, 1 }, new byte[] { 1, 1 }));
        }

        [TestMethod]
        public void AndOperationTest2()
        {
            CollectionAssert.AreEqual(new byte[] { 1, 0 }, AndOperation(new byte[] { 1, 1 }, new byte[] { 1, 0 }));
        }
        
        [TestMethod]
        public void AndOperationTest3()
        {
            CollectionAssert.AreEqual(new byte[] { 1, 0, 1, 0 }, AndOperation(new byte[] { 1, 1, 1, 0 }, new byte[] { 1, 0, 1, 0 }));
        }

        byte[] AndOperation(byte[] arrayA, byte[] arrayB)
        {
            byte[] result = new byte[arrayA.Length];
            for(int i = 0; i < arrayA.Length; i++)
            {
                if (arrayA[i] == (byte)1 && arrayB[i] == (byte)1) result[i] = (byte)1;
                else result[i] = (byte)0;
            }
            return result; 

        }
    }
}
