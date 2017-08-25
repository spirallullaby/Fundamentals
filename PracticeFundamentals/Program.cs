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
    }
}
