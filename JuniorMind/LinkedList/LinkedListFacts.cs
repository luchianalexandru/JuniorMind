using System;
using Xunit;

namespace LinkedList
{
    public class LinkedListFacts
    {
        [Fact]
        public void ShouldCount0ItemsInTheList()
        {
            var list = new LinkedList<int>();
            Assert.Equal(0, list.Count);
        }

        [Fact]
        public void ShouldAddItemAtTheEndOfTheList()
        {
            var list = new LinkedList<int> { 2, 3, 4 };
            list.Add(5);
            Assert.Equal(new int[] { 2, 3, 4, 5},  list);

        }

        [Fact]
        public void ShouldClearTheList()
        {
            var list = new LinkedList<int>();
            list.Add(2);
            Assert.Equal(1, list.Count);
            list.Clear();
            Assert.Equal(0, list.Count);

        }

        [Fact]
        public void ShouldAddItemAsFirst()
        {
            var list = new LinkedList<int>() { 9, 2, 7 };
            list.AddFirst(5);
            Assert.Equal(4, list.Count);
        }

        [Fact]
        public void ShouldReturnNumberOfItems()
        {
            var list = new LinkedList<int>() { 9, 2, 7, 5 };            
            Assert.Equal(4, list.Count);
        }
    }
}
