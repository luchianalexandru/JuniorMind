﻿using System;
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
            if (counter == 0)
            {
                node.value = item;
                node.next = guard;
                node.previous = guard;
                guard.next = node;
                guard.previous = node;
            }
            else
            {
                while(guard.next != guard)
                {
                    guard = guard.next;
                }
                guard.next = node;
                guard.previous = node;
                node.next = guard;
                node.previous = guard;
            }
            counter++;
        }
    
    }
}
