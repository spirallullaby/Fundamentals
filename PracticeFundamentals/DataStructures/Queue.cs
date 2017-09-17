namespace PracticeFundamentals.DataStructures
{  
    class Queue<T>
    {
        LinkedListNode<T> head;
        LinkedListNode<T> tail;
        public int Count
        {
            private set;
            get;
        } = 0;
        public void Enqueue(T data)
        {
            var newNode = new LinkedListNode<T>()
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
        public T Dequeue()
        {
            var result = head.Data;
            head = head.NextNode;
            Count--;
            return result;
        }
    }
}
