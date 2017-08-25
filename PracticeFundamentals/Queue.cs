using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeFundamentals
{
    class LinkedListNode
    {
        public string Data
        {
            get; set;
        }
        public LinkedListNode NextNode
        {
            get; set;
        }
    }
    class Queue
    {
        LinkedListNode head;
        LinkedListNode tail;
        public int Count
        {
            private set;
            get;
        } = 0;
        public void Enqueue(string data)
        {
            var newNode = new LinkedListNode()
            {
                Data = data,
            };
            if (Count == 0)
            {
                head = newNode;
            }
            else
            {
                tail.NextNode = newNode;
            }
            tail = newNode;
            Count++;
        }
        public string Dequeue()
        {
            var result = head.Data;
            head = head.NextNode;
            Count--;
            return result;
        }
    }
}
