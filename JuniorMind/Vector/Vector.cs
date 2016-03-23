using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vector
{
    class Vector<T> : IList<T>
    {
        private int counter;
        private T[] list = new T[10];

        public Vector()
        {
            counter = 0;
        }

        public T this[int index]
        {
            get
            {
                return list[index];
            }

            set
            {
                list[index] = value;
            }
        }

        public int Count
        {
            get
            {
                return counter;
            }
        }

        public bool IsReadOnly
        {
            get
            {
                return false;
            }
        }

        public void Add(T value)
        {
            if (counter < list.Length)
                list[counter++] = value;
        }

        public void Clear()
        {
            counter = 0;
        }

        public bool Contains(T value)
        {
            for (int i = 0; i < counter; i++)
                if (list[i].Equals(value)) return true;
            return false;
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            int j = arrayIndex;
            for (int i = 0; i < Count; i++)
            {
                array.SetValue(list[j], i);
                j++;
            }
        }


        public IEnumerator<T> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public int IndexOf(T item)
        {
            for (int i = 0; i < counter; i++)
                if (list[i].Equals(item)) return i;
            return -1; 
        }

        public void Insert(int index, T item)
        {
            if ( counter == list.Length )
                Array.Resize(ref list, list.Length * 2);
            for (int i = counter - 1; i > index; i--)
                list[i] = list[i - 1];
            list[index] = item;
            counter++;
        }

        public bool Remove(T item)
        {
            throw new NotImplementedException();
        }

        public void RemoveAt(int index)
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
