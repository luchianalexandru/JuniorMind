using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace RepairCenter
{
    [TestClass]
    public class RepairCenter
    {
        [TestMethod]
        public void ChecksIfPrioritySwitchWorks()
        {
            Assert.AreEqual(3, ReturnsPriorityByNumber("High"));
        }

        [TestMethod]
        public void ChecksIfPrioritySwitchWorks2()
        {
            Assert.AreEqual(2, ReturnsPriorityByNumber("Medium"));
        }

        [TestMethod]
        public void TestsTheSortForATwoElementStruct()
        {
            var expected = new Repair[]
            {
                new Repair("tv", "High"),
                new Repair("radio", "Low")
            };
            var toSort = new Repair[]
            {
                new Repair("radio", "Low"),
                new Repair("tv", "High"),
            };
            CollectionAssert.AreEqual(expected, SortRepairs(toSort));
        }

        [TestMethod]
        public void TestsTheSortForAThreeElementStruct()
        {
            var expected = new Repair[]
            {
                new Repair("tv", "High"),
                new Repair("clock","Medium"),
                new Repair("radio", "Low")    
            };
            var toSort = new Repair[]
            {
                new Repair("clock","Medium"),
                new Repair("tv", "High"),
                new Repair("radio", "Low")
            };
            CollectionAssert.AreEqual(expected, SortRepairs(toSort));
        }

        [TestMethod]
        public void TestsTheSortForASevenElementStruct()
        {
            var toSort = new Repair[]
            {
                new Repair("watch","Medium"),
                new Repair("tv", "High"),
                new Repair("clock","Medium"),
                new Repair("lamp","High"),
                new Repair("toothbrush","Low"),
                new Repair("radio", "Low"),
                new Repair("stove","Medium"),
            };
            var expected = new Repair[]
            {
                new Repair("tv", "High"),
                new Repair("lamp","High"),
                new Repair("watch","Medium"),
                new Repair("clock","Medium"),
                new Repair("stove","Medium"),
                new Repair("toothbrush","Low"),
                new Repair("radio", "Low")
            };
            CollectionAssert.AreEqual(expected, SortRepairs(toSort));
        }


        public Repair[] SortRepairs ( Repair[] toSort)
        {
            for(int i= 0; i < toSort.Length; i++)
            {
                for(int j = 0; j < toSort.Length-1; j++)
                {
                    if(ReturnsPriorityByNumber(toSort[j].priority) < ReturnsPriorityByNumber(toSort[j+1].priority))
                    {
                        Swap(ref toSort, j);
                    }
                }
            }
            return toSort;
        }


        [TestMethod]
        public void TestsSwap()
        {
            var expected = new Repair[]
            {
                new Repair("tv", "High"),
                new Repair("clock","Medium")
            };
            var toSwap = new Repair[]
            {
                new Repair("clock","Medium"),
                new Repair("tv", "High")
            };
            Swap(ref toSwap, 0);
            CollectionAssert.AreEqual(expected, toSwap);
        }

        static void Swap(ref Repair[] toSort, int position)
        {
            Repair temp = toSort[position];
            toSort[position] = toSort[position + 1];
            toSort[position + 1] = temp;
        }

        public int ReturnsPriorityByNumber(string priority)
        {
            switch(priority)
            {
                case "High":
                    return 3;
                case "Medium":
                    return 2;
                case "Low":
                    return 1;
                default:
                    return 0;
            }   
        }

        public struct Repair
        {
            public string name;
            public string priority;
            public Repair(string name, string priority)
            {
                this.name = name;
                this.priority = priority;
            }
        }


    }
}
