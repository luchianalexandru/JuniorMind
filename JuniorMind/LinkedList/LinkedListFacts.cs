using System;
using Xunit;

namespace LinkedList
{
    public class LinkedListFacts
    {
        [Fact]
        public void ShouldCount0ItemsInTheList()
        {
            LinkedList<int> list = new LinkedList<int>();
            Assert.Equal(0, list.Count);
        }

        [Fact]
        public void ShouldAddItemAtTheEndOfTheList()
        {
            LinkedList<int> list = new LinkedList<int> { 2, 3, 4 };
            list.Add(5);
            Assert.Equal(new int[] { 2, 3, 4, 5},  list);

        }

        [Fact]
        public void ShouldClearTheList()
        {
            LinkedList<int> list = new LinkedList<int>();
            list.Add(2);
            Assert.Equal(1, list.Count);
            list.Clear();
            Assert.Equal(0, list.Count);

        }

        [Fact]
        public void ShouldAddItemAsFirst()
        {
            LinkedList<int> list = new LinkedList<int>() { 9, 2, 7 };
            list.AddFirst(5);
            Assert.Equal(4, list.Count);
        }

        [Fact]
        public void ShouldReturnNumberOrItems()
        {
            LinkedList<int> list = new LinkedList<int>() { 9, 2, 7, 5 };
            int k = 0;
            foreach (int value in list) k+= value;
            Assert.Equal(23, k);
        }
    }
}
