using System;
using System.Collections;
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

        public int Count
        {
            get
            {
                return counter;
            }
        }

        public void Add(T item)
        {
            Node node = new Node();

            node.value = item;
            node.next = guard;
            node.previous = guard.previous;
            guard.previous = node;
            counter++;
        }

        public void Clear()
        {
            counter = 0;
            guard.next = guard;
            guard.previous = guard;
        }

        public void AddFirst(T item)
        {
            Node node = new Node
            {
                value = item,
                next = guard.next,
                previous = guard
            };
            node.previous = node;
            guard.next = node;
            counter++;
        }
    
    }
}
