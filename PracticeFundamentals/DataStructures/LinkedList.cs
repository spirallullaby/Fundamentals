using System;
using System.Collections;
using System.Collections.Generic;

namespace PracticeFundamentals.DataStructures
{
    class LinkedList<T> : IEnumerable<T>
    {
        int count;
        LinkedListNode<T> head;
        LinkedListNode<T> tail;
        
        public IEnumerator<T> GetEnumerator()
        {
            return this.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            LinkedListNode<T> temp = head;
            for (int i = 0; i < count; i++)
            {
                yield return temp.Data;
                temp = temp.NextNode;
            }
        }
        public void AddData(LinkedListNode<T> newNode)
        {
            if (head == null)
            {
                head = newNode;
                tail = newNode;
            }
            tail.NextNode = newNode;
            tail = tail.NextNode;
        }
        public void GetNode()
        {

        }
        public void RemoveData(LinkedListNode<T> node)
        {
            var currentNode = head;
            var prevNode = head;
            while(currentNode != node && currentNode != null)
            {
                prevNode = currentNode;
                currentNode = currentNode.NextNode;
            }
            if (prevNode == currentNode)
                head = currentNode.NextNode;
            else
                prevNode.NextNode = currentNode != null ? currentNode.NextNode : null;
        }

        public override string ToString()
        {
            string result = string.Empty;
            if (head == null)
                return result;
            var currentNode = head;
            while(currentNode != null)
            {
                result += currentNode.Data + ", ";
                currentNode = currentNode.NextNode;
            }
            result.TrimEnd(", ".ToCharArray());
            return result;
        }
    }
}
