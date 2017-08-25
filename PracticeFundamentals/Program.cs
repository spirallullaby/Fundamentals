using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeFundamentals
{
    class Program
    {
        static void Main(string[] args)
        {
            TestQueue();
            TestStack();
        }

        private static void TestQueue()
        {
            var queue = new Queue();
            queue.Enqueue("First");
            queue.Enqueue("Second");
            queue.Enqueue("Third");
            queue.Enqueue("Fourth");
            var count = queue.Count;
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine(queue.Dequeue());
            }
            Console.ReadLine();
        }

        private static void TestStack()
        {
            var stack = new Stack();
            stack.Push("1");
            stack.Push("2");
            stack.Push("3");
            stack.Push("4");
            var cnt = stack.Count;
            for (int i = 0; i < cnt; i++)
            {
                Console.WriteLine(stack.Pop());
            }
            Console.ReadLine();
        }
    }
}
