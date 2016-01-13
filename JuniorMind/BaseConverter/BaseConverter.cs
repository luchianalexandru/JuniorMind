﻿using System;
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
        public void TestForMakingArraysHaveSameLength1()
        {
            CollectionAssert.AreEqual(new byte[] { 0, 1, 1 }, ReturnsTheShorterArrayWithZeroesAtTheBeginning(new byte[] { 1, 1 }, new byte[] { 1, 1, 0 }));
        }

        [TestMethod]
        public void TestForMakingArraysHaveSameLength2()
        {
            CollectionAssert.AreEqual(new byte[] { 0, 1, 0 }, ReturnsTheShorterArrayWithZeroesAtTheBeginning(new byte[] { 1, 0 }, new byte[] { 1, 1, 0 }));
        }

        [TestMethod]
        public void TestForMakingArraysHaveSameLength3()
        {
            CollectionAssert.AreEqual(new byte[] { 0, 1, 1, 0 }, ReturnsTheShorterArrayWithZeroesAtTheBeginning(new byte[] { 1, 1, 0 }, new byte[] { 1, 0, 0, 1 }));
        }

        [TestMethod]
        public void TestForMakingArraysHaveSameLength4()
        {
            CollectionAssert.AreEqual(new byte[] { 0, 0, 0, 1, 0, 1, 1, 0 }, ReturnsTheShorterArrayWithZeroesAtTheBeginning(new byte[] { 1, 0, 1, 1, 0 }, new byte[] { 1, 0, 0, 1, 1, 0, 0, 1 }));
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

        [TestMethod]
        public void AndOperationTest1()
        {
            CollectionAssert.AreEqual(new byte[] { 1, 1 }, OperationForEachByteInArray(new byte[] { 1, 1 }, new byte[] { 1, 1 }, "AND"));
        }

        [TestMethod]
        public void AndOperationTest2()
        {
            CollectionAssert.AreEqual(new byte[] { 1, 0 }, OperationForEachByteInArray(new byte[] { 1, 1 }, new byte[] { 1, 0 }, "AND"));
        }

        [TestMethod]
        public void AndOperationTest3()
        {
            CollectionAssert.AreEqual(new byte[] { 1, 0, 1, 0 }, OperationForEachByteInArray(new byte[] { 1, 1, 1, 0 }, new byte[] { 1, 0, 1, 0 }, "AND"));
        }

        [TestMethod]
        public void AndOperationTest4()
        {
            CollectionAssert.AreEqual(new byte[] { 0, 0, 1, 0, 1, 0 }, OperationForEachByteInArray(new byte[] { 1, 1, 1, 1, 1, 0 }, new byte[] { 1, 0, 1, 0 }, "AND" ));
        }

        [TestMethod]
        public void AndOperationTest5()
        {
            CollectionAssert.AreEqual(new byte[] { 0, 0, 1, 0, 0 }, OperationForEachByteInArray(new byte[] { 1, 1, 1, 1, 0 }, new byte[] { 1, 0, 1 }, "AND"));
        }

        [TestMethod]
        public void OrOperationTest1()
        {
            CollectionAssert.AreEqual(new byte[] { 1, 1 }, OperationForEachByteInArray(new byte[] { 0, 1 }, new byte[] { 1, 0 }, "OR"));
        }

        [TestMethod]
        public void OrOperationTest2()
        {
            CollectionAssert.AreEqual(new byte[] { 1, 1, 1, 0 }, OperationForEachByteInArray(new byte[] { 1, 1, 1, 0 }, new byte[] { 1, 0, 1, 0 }, "OR"));
        }

        [TestMethod]
        public void OrOperationTest3()
        {
            CollectionAssert.AreEqual(new byte[] { 1, 1, 1, 0, 1, 0 }, OperationForEachByteInArray(new byte[] { 1, 1, 1, 0, 1, 0 }, new byte[] { 1, 0, 1, 0 }, "OR"));
        }

        [TestMethod]
        public void XorOperationTest1()
        {
            CollectionAssert.AreEqual(new byte[] { 1, 1 }, OperationForEachByteInArray(new byte[] { 0, 1 }, new byte[] { 1, 0 }, "XOR"));
        }

        [TestMethod]
        public void XorOperationTest2()
        {
            CollectionAssert.AreEqual(new byte[] { 0, 1, 0, 0 }, OperationForEachByteInArray(new byte[] { 1, 1, 1, 0 }, new byte[] { 1, 0, 1, 0 }, "XOR"));
        }

        [TestMethod]
        public void XorOperationTest3()
        {
            CollectionAssert.AreEqual(new byte[] { 1, 1, 0, 0, 0, 0 }, OperationForEachByteInArray(new byte[] { 1, 1, 1, 0, 1, 0 }, new byte[] { 1, 0, 1, 0 }, "XOR"));
        }

        [TestMethod]
        public void OperationTestForWhenOperationIsNeither()
        {
            CollectionAssert.AreEqual(new byte[] { 0, 0, 0, 0, 0, 0 }, OperationForEachByteInArray(new byte[] { 1, 1, 1, 0, 1, 0 }, new byte[] { 1, 0, 1, 0 }, "RETURNS EMPTY BYTE ARRAY"));
        }

        [TestMethod]
        public void ReturnNullIfArrayTooShortTest1()
        {
            Assert.AreEqual((byte)0, GetNullIfShort(new byte[] { 1, 1 }, 3));
        }

        [TestMethod]
        public void ReturnNullIfArrayTooShortTest2()
        {
            Assert.AreEqual((byte)1, GetNullIfShort(new byte[] { 1, 1 }, 1));
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

        byte[] ReturnsTheShorterArrayWithZeroesAtTheBeginning(byte[] shortArray, byte[] longArray)
        {
            byte[] intermediateArray = new byte[] { };
            intermediateArray = Inverter(shortArray);
            for (int i = shortArray.Length; i < longArray.Length; i++)
            {
                Array.Resize(ref intermediateArray, intermediateArray.Length + 1);
                intermediateArray[i] = (byte)0;
            }
            return Inverter(intermediateArray);

        }

        byte GetNullIfShort(byte[] array, int i)
        {
            if (i < array.Length) return array[array.Length - i - 1];
            return (byte)0;
        }

        byte[] NotOperation(byte[] array)
        {
            byte[] notArray = new byte[array.Length];
            for(int i = 0; i < notArray.Length; i++) notArray[i] = array[i] == (byte)0 ? (byte)1 : (byte)0;
            return notArray;
        }   

        byte[] OperationForEachByteInArray(byte[] arrayA, byte[] arrayB, string operation)
        {

            byte[] result = new byte[Math.Max(arrayA.Length, arrayB.Length)];
            for (int i = 0; i < result.Length; i++)
                result[result.Length - i - 1] = OperationSwitch(GetNullIfShort(arrayA, i), GetNullIfShort(arrayB, i), operation);
            return result;
        }

        private byte OperationSwitch(byte a, byte b, string operation)
        {
            switch (operation)
            {
                case "AND":
                    return a == (byte)1 && b == (byte)1 ? (byte)1 : (byte)0;
                case "OR":
                    return a == (byte)1 || b == (byte)1 ? (byte)1 : (byte)0;
                case "XOR":
                    return a == b ? (byte)0 : (byte)1;
                default:
                    return 0;
            }
        }
    }
}
