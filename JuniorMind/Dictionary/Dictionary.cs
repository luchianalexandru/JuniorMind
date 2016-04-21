using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary
{
    class Dictionary<TKey, TValue> : IDictionary<TKey, TValue>
    {

        private int?[] buckets;
        private Entry[] entries;
        private int counter;

        private struct Entry
        {
            public TKey Key;
            public TValue Value;
            public int? previous;
            public Entry(TKey key, TValue value, int? previous)
            {
                this.Key = key;
                this.Value = value;
                this.previous = previous;
            }
        }

        public Dictionary(int capacity = 10)
        {
            this.buckets = new int?[capacity];
            this.entries = new Entry[capacity * 2];
            this.buckets = this.buckets.DefaultIfEmpty(-1).ToArray();
            this.counter = 0;
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
                throw new NotImplementedException();
            }
        }

        public ICollection<TKey> Keys
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public ICollection<TValue> Values
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public TValue this[TKey key]
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public void Add(KeyValuePair<TKey, TValue> item)
        {
            throw new NotImplementedException();
        }

        public void Clear()
        {
            throw new NotImplementedException();
        }

        public bool Contains(KeyValuePair<TKey, TValue> item)
        {
            throw new NotImplementedException();
        }

        public void CopyTo(KeyValuePair<TKey, TValue>[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }

        public IEnumerator<KeyValuePair<TKey, TValue>> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public bool Remove(KeyValuePair<TKey, TValue> item)
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public bool ContainsKey(TKey key)
        {
            throw new NotImplementedException();
        }

        public void Add(TKey key, TValue value)
        {
            var hash = GetHashCode(key);
            entries[counter] = new Entry() { Key = key, Value = value, previous = buckets[hash] };
            buckets[hash] = counter;
            counter += 1;
        }

        private int GetHashCode(TKey key)
        {
            return Math.Abs(key.GetHashCode() % buckets.Length);
        }

        public bool Remove(TKey key)
        {
            throw new NotImplementedException();
        }

        public bool TryGetValue(TKey key, out TValue value)
        {
            throw new NotImplementedException();
        }
    }
}
