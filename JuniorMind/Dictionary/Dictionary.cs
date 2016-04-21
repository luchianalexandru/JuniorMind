﻿using System;
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
                return entries[GetValueOfKey(key)].Value;
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
            counter = default(int);
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
            return (GetValueOfKey(key) > 0) ? true : false;
        }

        public int GetValueOfKey(TKey key)
        {
            int keyValue = 0;
            if (buckets[GetHashCode(key)].HasValue)
            {
                for (var current = buckets[GetHashCode(key)]; current >= 0; current = entries[current.Value].previous)
                {
                    if (entries[current.Value].Key.Equals(key)) keyValue = current.Value;
                }
            }
            return keyValue;
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
            int counter = GetValueOfKey(key);

            if (counter < 0)
                return false;

            while (counter >= 0 && counter < entries.Length - 1)
            {
                entries[counter] = entries[counter + 1];
                counter++;
            }

            Array.Resize(ref entries, entries.Length - 1);
            return true;
        }

        public bool TryGetValue(TKey key, out TValue value)
        {
            throw new NotImplementedException();
        }
    }
}
