using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Vector;

namespace Vector
{
    [TestClass]
    public class VectorTests
    {
        [TestMethod]
        public void ShouldCheckIfAddingWorksFor1Element()
        {
            Vector<int> list = new Vector<int>();
            list.Add(0);
            Assert.AreEqual(1, list.Count);
        }

        [TestMethod]
        public void ShouldCheckIfAddingWorksFor2Elements()
        {
            Vector<int> list = new Vector<int>();
            list.Add(0);
            list.Add(2);
            Assert.AreEqual(2, list.Count);
        }

        [TestMethod]
        public void ShouldCheckIfStringAdded()
        {
            Vector<string> list = new Vector<string>();
            list.Add("hello");
            Assert.AreEqual(1, list.Count);
        }

        [TestMethod]
        public void ShouldCheckIfTwoStringsAdded()
        {
            Vector<string> list = new Vector<string>() {
                "hello1",
                "hello2"
            };
            Assert.AreEqual(2, list.Count);
        }

        [TestMethod]
        public void ShouldTestIfClearWorks()
        {
            Vector<string> list = new Vector<string>() {
                "hello1",
                "hello2"
            };
            list.Clear();
            Assert.AreEqual(0, list.Count);
        }

        [TestMethod]
        public void ShouldReturnTrueIfOneElementIsContainedForInteger()
        {
            Vector<int> list = new Vector<int>();
            list.Add(0);
            list.Add(2);
            Assert.IsTrue(list.Contains(2));
        }

        [TestMethod]
        public void ShouldReturnTrueIfOneStringIsContained()
        {
            Vector<string> list = new Vector<string>() {
                "hello1",
                "hello2",
                "hello3"
            };
            Assert.IsTrue(list.Contains("hello2"));
        }

        [TestMethod]
        public void ShouldReturnFalseIfNotContained()
        {
            Vector<string> list = new Vector<string>() {
                "hello1",
                "hello2",
                "hello3"
            };
            Assert.IsFalse(list.Contains("hello4"));
        }

        [TestMethod]
        public void ShouldTestIfCopyWorksForInteger()
        {
            Vector<int> list = new Vector<int>();
            list.Add(3);
            list.Add(2);
            list.Add(4);
            list.Add(5);
            list.Add(7);
            int[] value = new int[list.Count];
            list.CopyTo(value, 0);
            Assert.AreEqual(3, value[0]);
        }
    }
}
