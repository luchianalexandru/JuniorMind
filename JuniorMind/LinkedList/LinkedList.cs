using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public class LinkedList<T>
    {
        private class Node
        {
            public T value;
            public Node previous;
            public Node next;
        }

        private int counter;
        Node guard = new Node();

        public int Count()
        {
            return counter;
        }

    }
}
