using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace LinkedList
{
    public class LinkedList<T> : IEnumerable<T>, IEnumerable
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
            Node node = new Node()
            {
                value = item,
                next = guard,   
                previous = guard.previous
            };
            guard.previous = node;
            guard.previous.next = node;
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


        public IEnumerator<T> GetEnumerator()
        {
            for(Node i = guard.next; i!= guard; i = i.next)
            {
                yield return i.value;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
          return this.GetEnumerator();
        }
    }
}
