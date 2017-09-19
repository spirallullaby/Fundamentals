using System;
using System.Linq;

namespace PracticeFundamentals.DataStructures
{
    class HashTable<TKey, TValue>
    {
        //selected by random
        int modulusValue;
        LinkedList<Tuple<TKey,TValue>>[] data;
        public HashTable(int length)
        {
            modulusValue = length;
            data = new LinkedList<Tuple<TKey, TValue>>[length];
        }
        public void Add(TKey key, TValue value)
        {
            var hashedIndex = Hash(key) % (UInt64)modulusValue;
            if(data[hashedIndex] == null)
            {
                data[hashedIndex] = new LinkedList<Tuple<TKey, TValue>>();
            }
            data[hashedIndex].AddData(
                new LinkedListNode<Tuple<TKey, TValue>>()
            {
                Data = Tuple.Create(key, value),
            });
        }
        public TValue GetValue(TKey key)
        {
            var hashedIndex = Hash(key) % (UInt64)modulusValue;
            var dataList = data[hashedIndex];
            var currentNode = dataList.Head;
            while (currentNode!=null)
            {
                if (currentNode.Data.Item1.Equals(key))
                    return currentNode.Data.Item2;
                currentNode = currentNode.NextNode;
            }
            return default(TValue);
        }
        private UInt64 Hash(TKey key)
        {
            var mask = 121212;
            UInt64 hash = 1;
            var stringedKey = ((object)key).ToString();
            for (int i = 0; i < stringedKey.Length; i++)
            {
                hash *= (UInt64)Math.Pow((int)stringedKey[i], i);
            }
            return hash;
        }
    }
}
