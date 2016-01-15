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
            CollectionAssert.AreEqual(new byte[] { 1, 0 }, ConvertFromBase10ToAnother(2, 2));
        }

        [TestMethod]
        public void ConvertFromBase10ToBase2Test2()
        {
            CollectionAssert.AreEqual(new byte[] { 1, 0, 0 }, ConvertFromBase10ToAnother(4, 2));
        }

        [TestMethod]
        public void ConvertFromBase10ToBase2Test3()
        {
            CollectionAssert.AreEqual(new byte[] { 1, 0, 1 }, ConvertFromBase10ToAnother(5, 2));
        }

        [TestMethod]
        public void ConvertFromBase10ToBase2Test4()
        {
            CollectionAssert.AreEqual(new byte[] { 1, 0, 0, 1 }, ConvertFromBase10ToAnother(9, 2));
        }

        [TestMethod]
        public void ConvertFromBase10ToBase2Test5()
        {
            CollectionAssert.AreEqual(new byte[] { 1, 0, 0, 0, 1 }, ConvertFromBase10ToAnother(17, 2 ));
        }

        [TestMethod]
        public void ConvertFromBase10ToBase2Test6()
        {
            CollectionAssert.AreEqual(new byte[] { 1, 1, 0, 1, 1, 1, 1, 1 }, ConvertFromBase10ToAnother(223, 2));
        }

        [TestMethod]
        public void ConvertFromAnyBaseToAnyBaseTest1()
        {
            CollectionAssert.AreEqual(new byte[] { 2 }, ConvertFromBase10ToAnother(2, 3));
        }

        [TestMethod]
        public void ConvertFromAnyBaseToAnyBaseTest2()
        {
            CollectionAssert.AreEqual(new byte[] { 9 }, ConvertFromBase10ToAnother(9, 10));
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

        [TestMethod]
        public void LeftHandShiftOperationTest1()
        {
            CollectionAssert.AreEqual(new byte[] { 0, 1, 0, 0 }, LeftHandShift(new byte[] { 0, 1 }, 2));
        }

        [TestMethod]
        public void LeftHandShiftOperationTest2()
        {
            CollectionAssert.AreEqual(new byte[] { 0, 1, 0, 1, 0, 1, 0, 0, 0, 0 }, LeftHandShift(new byte[] { 0, 1, 0, 1, 0, 1 }, 4));
        }

        [TestMethod]
        public void RightHandShiftOperationTest1()
        {
            CollectionAssert.AreEqual(new byte[] { 0, 0, 0, 1, }, RightHandShift(new byte[] { 0, 1 }, 2));
        }

        [TestMethod]
        public void RightHandShiftOperationTest2()
        {
            CollectionAssert.AreEqual(new byte[] { 0, 0, 0, 0, 0, 1, 0, 1, 0, 1 }, RightHandShift(new byte[] { 0, 1, 0, 1, 0, 1 }, 4));
        }

        [TestMethod]
        public void RightHandShiftOperationTest3()
        {
            CollectionAssert.AreEqual(new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 1, 0, 1 }, RightHandShift(new byte[] { 0, 1, 0, 1, 0, 1 }, 7));
        }

        [TestMethod]
        public void ALessThanBTest1()
        {
            Assert.AreEqual(true, LessThan(new byte[] { 0, 1 }, new byte[] { 1, 0, 1 }));
        }

        [TestMethod]
        public void ALessThanBTest2()
        {
            Assert.AreEqual(true, LessThan(new byte[] { 1, 0, 0 }, new byte[] { 1, 0, 1 }));
        }

        [TestMethod]
        public void ALessThanBTest3()
        {
            Assert.AreEqual(false, LessThan(new byte[] { 1, 0, 1 }, new byte[] { 1, 0, 0 }));
        }

        [TestMethod]
        public void ALessThanBTest4()
        {
            Assert.AreEqual(true, LessThan(new byte[] { 0, 1, 0, 0 }, new byte[] { 1, 0, 1 }));
        }

        [TestMethod]
        public void ALessThanBTest5()
        {
            Assert.AreEqual(true, LessThan(new byte[] { 0, 1, 1, 0 }, new byte[] { 1, 0, 1 }));
        }

        [TestMethod]
        public void MakeArrayWithout0AtBeginningTest1()
        {
            CollectionAssert.AreEqual(new byte[] { 1, 0, 0 }, MakeArrayWithout0AtBeginning(new byte[] { 0, 0, 1, 0, 0 }));
        }

        [TestMethod]
        public void MakeArrayWithout0AtBeginningTest2()
        {
            CollectionAssert.AreEqual(new byte[] { 1, 1, 0, 1 }, MakeArrayWithout0AtBeginning(new byte[] { 0, 0, 0, 0, 1, 1, 0, 1 }));
        }

        [TestMethod]
        public void EqualToTest1()
        {
            Assert.AreEqual(false, EqualTo(new byte[] { 0, 1, 1, 0 }, new byte[] { 1, 0, 1 }));
        }

        [TestMethod]
        public void EqualToTest2()
        {
            Assert.AreEqual(true, EqualTo(new byte[] { 1, 1, 0 }, new byte[] { 1, 1, 0 }));
        }

        [TestMethod]
        public void EqualToTest3()
        {
            Assert.AreEqual(true, EqualTo(new byte[] { 0, 0, 1, 1, 0 }, new byte[] { 1, 1, 0 }));
        }

        [TestMethod]
        public void GreaterThanTest1()
        {
            Assert.AreEqual(true, GreaterThan(new byte[] { 1, 1, 1 }, new byte[] { 1, 1, 0 }));
        }

        [TestMethod]
        public void GreaterThanTest2()
        {
            Assert.AreEqual(false, GreaterThan(new byte[] { 1, 1, 0 }, new byte[] { 1, 1, 1 }));
        }

        [TestMethod]
        public void GreaterThanTest3()
        {
            Assert.AreEqual(false, GreaterThan(new byte[] { 0, 0, 1, 1, 0 }, new byte[] { 0, 1, 1, 1 }));
        }

        [TestMethod]
        public void GreaterThanTest4()
        {
            Assert.AreEqual(true, GreaterThan(new byte[] { 0, 0, 1, 1, 1 }, new byte[] { 0, 1, 1, 0 }));
        }

        [TestMethod]
        public void NotEqualToTest1()
        {
            Assert.AreEqual(true, NotEqual(new byte[] { 0, 1, 1, 0 }, new byte[] { 1, 0, 1 }));
        }

        [TestMethod]
        public void NotEqualToTest2()
        {
            Assert.AreEqual(true, NotEqual(new byte[] { 0, 0, 1, 1, 1, 1, 0 }, new byte[] { 0, 0, 1, 1, 1 }));
        }

        [TestMethod]
        public void AdditionTest1()
        {
            CollectionAssert.AreEqual(new byte[] { 1, 1 }, Addition(new byte[] { 0, 1 }, new byte[] { 1, 0 }, 2));
        }

        [TestMethod]
        public void AdditionTest2()
        {
            CollectionAssert.AreEqual(new byte[] { 1, 0, 0, 1, 1, 1, 1 }, Addition(new byte[] { 1, 1, 0, 1, 0, 1 }, new byte[] { 1, 1, 0, 1, 0 }, 2));
        }

        [TestMethod]
        public void SubstractionTest1()
        {
            CollectionAssert.AreEqual(new byte[] { 1 }, Substraction(new byte[] { 1, 0 }, new byte[] { 1 }, 2));
        }

        [TestMethod]
        public void SubstractionTest2()
        {
            CollectionAssert.AreEqual(new byte[] { 1, 1, 1, 0 }, Substraction(new byte[] { 1, 1, 1, 1 }, new byte[] { 1 }, 2));
        }

        [TestMethod]
        public void SubstractionTest3()
        {
            CollectionAssert.AreEqual(new byte[] { 7, 8 }, Substraction(new byte[] { 8, 7 }, new byte[] { 9 }, 10));
        }


        byte[] ConvertFromBase10ToAnother(int number, int baza )
        {
            byte[] array = { };

            while (number > 0)
            {
                Array.Resize(ref array, array.Length + 1);
                array[array.Length - 1] = (byte)(number % baza);
                number /= baza;
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

        private byte[] LeftHandShift(byte[] array, int steps)
        {
            byte[] finalArray = new byte[array.Length+steps];
            
            for(int i = 0; i < finalArray.Length; i++)
            {
                if (i >= array.Length) finalArray[i] = 0;
                else finalArray[i] = array[i];
            }
            return finalArray;
        }

        private byte[] RightHandShift(byte[] array, int steps)
        {
            byte[] finalArray = new byte[array.Length + steps];

            for (int i = 0; i < finalArray.Length; i++)
            {
                if (i < steps) finalArray[i] = 0;
                else finalArray[i] = array[i-steps];
            }
            return finalArray;
        }

        private static byte[] MakeArrayWithout0AtBeginning(byte[] array)
        {
            int i = 0;
            for (i = 0; i < array.Length; i++)
            {
                if (array[i] != 0) break;
            }

            byte[] temp = new byte[array.Length - i];

            for (int j = i; j < array.Length; j++)
            {
                temp[j - i] = array[j];
            }
            
            return temp;
        }

        bool LessThan(byte[] a, byte[] b)
        {
            a = MakeArrayWithout0AtBeginning(a);
            b = MakeArrayWithout0AtBeginning(b);

            if (a.Length < b.Length) return true;
            if (a.Length == b.Length)
                for (int i = 0; i < a.Length; i++)
                {
                    if (a[i] < b[i]) return true;
                }
            return false;
        }

        bool EqualTo(byte[] a, byte[]b)
        {
            if (LessThan(a, b) == false && LessThan(b, a) == false) return true;
            return false;
        }

        bool GreaterThan(byte[] a, byte[] b)
        {
            if (LessThan(a, b) != true)
                if (LessThan(b, a) == true) return true;
            return false;

        }

        bool NotEqual(byte[] a, byte[] b)
        {
            return !EqualTo(a, b);
            
        }

        byte[] Addition(byte[] a, byte[] b, int baza)
        {            
            int rest = 0;
            byte[] rezultat = new byte[Math.Max(a.Length, b.Length) + 1];
            int suma;
            for(int i = rezultat.Length-1; i >=0; i--)
            {
                suma = GetNullIfShort(a, rezultat.Length - i - 1) + GetNullIfShort(b, rezultat.Length - i - 1) + rest;
                rest = suma / baza;
                rezultat[i] = (byte)(suma % baza);
            }
            return MakeArrayWithout0AtBeginning(rezultat);
        }

        byte[] Substraction(byte[] a, byte[] b, int baza)
        {
            if (EqualTo(a, b)) return new byte[] { };
            byte[] descazut = new byte[] { };
            byte[] scazator = new byte[] { };
            descazut = GreaterThan(a, b) ? a : b;
            scazator = LessThan(a, b) ? a : b;
            scazator = RightHandShift(scazator, descazut.Length - scazator.Length);

            byte[] rezultat = new byte[descazut.Length];
            int diferenta = 0;
            int rest = 0;

            for (int i = descazut.Length-1; i >= 0; i-- )
            {
                diferenta = descazut[i] - scazator[i] - rest;
                rest = 0;
                if (diferenta < 0)
                {
                    rest++;
                    diferenta = baza - (scazator[i] - descazut[i]);
                    rezultat[i] = (byte)diferenta;
                }
                else rezultat[i] = (byte)diferenta;
            }
            return MakeArrayWithout0AtBeginning(rezultat);
        }
    }
}
