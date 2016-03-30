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
            LinkedList<int> list = new LinkedList<int>();
            list.Add(2);
            Assert.Equal(1, list.Count);

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

    }
}
