using System;
using System.Collections;
using System.Collections.Generic;

namespace PracticeFundamentals.DataStructures
{
    class LinkedList<T>
    {
        int count;
        public LinkedListNode<T> Head
        {
            get; private set;
        }
        LinkedListNode<T> tail;
        
        public void AddData(LinkedListNode<T> newNode)
        {
            if (Head == null)
            {
                Head = newNode;
                tail = newNode;
            }
            tail.NextNode = newNode;
            tail = tail.NextNode;
        }
        public LinkedListNode<T> GetNode(LinkedListNode<T> newNode)
        {
            var currentNode = Head;
            while(currentNode != null)
            {
                if (currentNode.Data.Equals(newNode.Data))
                    break;
                currentNode = currentNode.NextNode;
            }
            return currentNode;
        }
        public void RemoveData(LinkedListNode<T> node)
        {
            var currentNode = Head;
            var prevNode = Head;
            while(currentNode != node && currentNode != null)
            {
                prevNode = currentNode;
                currentNode = currentNode.NextNode;
            }
            if (prevNode == currentNode)
                Head = currentNode.NextNode;
            else
                prevNode.NextNode = currentNode != null ? currentNode.NextNode : null;
        }

        public override string ToString()
        {
            string result = string.Empty;
            if (Head == null)
                return result;
            var currentNode = Head;
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
