namespace PracticeFundamentals
{
    public class LinkedNode
    {
        public LinkedNode(string data)
        {
            this.Data = data;
        }
        public LinkedNode Previous;
        public string Data;
    }
    public class Stack
    {
        private LinkedNode tail;
        public int Count = 0;
        public void Push(string data)
        {
            var node = new LinkedNode(data);
            if (tail != null)
                node.Previous = tail;
            tail = node;
            Count++;
        }

        public string Pop()
        {
            var result = tail.Data;
            tail = tail.Previous;
            Count--;
            return result;
        }
    }
}
