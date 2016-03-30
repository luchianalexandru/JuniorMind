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
            Assert.Equal(0, list.Count());
        }
    }
}
