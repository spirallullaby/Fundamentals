using PracticeFundamentals.DataStructures;
using System;

namespace PracticeFundamentals
{
    class Program
    {
        static void Main(string[] args)
        {
            //TestQueue();
            //TestStack();
            //TestSortedBinaryTree();
            //TestMaxMatrixFinder();
            //TestQuickSort();
            //TestSelectionSort();
            //TestLinkedList();
            //TestBubbleSort();
            //TestInsertionSort();
            //TestMergeSort();
            TestHashTable();
        }

        private static void TestSortedBinaryTree()
        {
            var tree = new SortedBinaryTree(1);
            var items = new[] { 1, 2, 3, 4, 5, 6, 7 };
            tree.AddItems(items);
            tree.DrawTree();
            Console.ReadLine();
        }

        private static void TestQueue()
        {
            var queue = new Queue<string>();
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

        private static void TestMaxMatrixFinder()
        {
            Console.WriteLine("Test matrix 1");
            Exercises.MaxMatrixFinder.PrintMaxMatrixes(Exercises.MaxMatrixFinder.testMatrix);
            Console.WriteLine("Test matrix 2");
            Exercises.MaxMatrixFinder.PrintMaxMatrixes(Exercises.MaxMatrixFinder.testMatrix1);
            Console.WriteLine("Test matrix 3");
            Exercises.MaxMatrixFinder.PrintMaxMatrixes(Exercises.MaxMatrixFinder.testMatrix2);

            Console.ReadLine();
        }

        private static void TestLinkedList()
        {
            var ll = new LinkedList<string>();
            var first = new LinkedListNode<string> { Data = "first" };
            var second = new LinkedListNode<string> { Data = "second" };
            var third = new LinkedListNode<string> { Data = "third" };
            ll.AddData(first);
            ll.AddData(second);
            ll.AddData(third);
            Console.WriteLine(ll);
            ll.RemoveData(first);
            first = new LinkedListNode<string> { Data = "first" };
            Console.WriteLine(ll);
            ll.AddData(first);
            third = new LinkedListNode<string> { Data = "third" };
            ll.RemoveData(third);
            Console.WriteLine(ll);
            Console.ReadLine();
        }

        private static void TestQuickSort()
        {
            Console.WriteLine(string.Join(", ", Sorting.QuickSort.Quicksort(Sorting.SortTestData.TestCase1)));
            Console.WriteLine(string.Join(", ", Sorting.QuickSort.Quicksort(Sorting.SortTestData.TestCase2)));
            Console.WriteLine(string.Join(", ", Sorting.QuickSort.Quicksort(Sorting.SortTestData.TestCase3)));
            Console.ReadLine();
        }

        private static void TestSelectionSort()
        {
            Console.WriteLine(string.Join(", ", Sorting.SelectionSort.Selectionsort(Sorting.SortTestData.TestCase1)));
            Console.WriteLine(string.Join(", ", Sorting.SelectionSort.Selectionsort(Sorting.SortTestData.TestCase2)));
            Console.WriteLine(string.Join(", ", Sorting.SelectionSort.Selectionsort(Sorting.SortTestData.TestCase3)));
            Console.WriteLine(string.Join(", ", Sorting.SelectionSort.Selectionsort(Sorting.SortTestData.TestCase4)));
            Console.WriteLine(string.Join(", ", Sorting.SelectionSort.Selectionsort(Sorting.SortTestData.TestCase5)));
            Console.ReadLine();
        }

        private static void TestBubbleSort()
        {
            Console.WriteLine(string.Join(", ", Sorting.BubbleSort.Bubblesort(Sorting.SortTestData.TestCase1)));
            Console.WriteLine(string.Join(", ", Sorting.BubbleSort.Bubblesort(Sorting.SortTestData.TestCase2)));
            Console.WriteLine(string.Join(", ", Sorting.BubbleSort.Bubblesort(Sorting.SortTestData.TestCase3)));
            Console.WriteLine(string.Join(", ", Sorting.BubbleSort.Bubblesort(Sorting.SortTestData.TestCase4)));
            Console.WriteLine(string.Join(", ", Sorting.BubbleSort.Bubblesort(Sorting.SortTestData.TestCase5)));
            Console.ReadLine();
        }

        private static void TestInsertionSort()
        {
            Console.WriteLine(string.Join(", ", Sorting.InsertionSort.Insertionsort(Sorting.SortTestData.TestCase1)));
            Console.WriteLine(string.Join(", ", Sorting.InsertionSort.Insertionsort(Sorting.SortTestData.TestCase2)));
            Console.WriteLine(string.Join(", ", Sorting.InsertionSort.Insertionsort(Sorting.SortTestData.TestCase3)));
            Console.WriteLine(string.Join(", ", Sorting.InsertionSort.Insertionsort(Sorting.SortTestData.TestCase4)));
            Console.WriteLine(string.Join(", ", Sorting.InsertionSort.Insertionsort(Sorting.SortTestData.TestCase5)));
            Console.ReadLine();
        }

        private static void TestMergeSort()
        {
            Console.WriteLine(string.Join(", ", Sorting.MergeSort.Mergesort(Sorting.SortTestData.TestCase1)));
            Console.WriteLine(string.Join(", ", Sorting.MergeSort.Mergesort(Sorting.SortTestData.TestCase2)));
            Console.WriteLine(string.Join(", ", Sorting.MergeSort.Mergesort(Sorting.SortTestData.TestCase3)));
            Console.WriteLine(string.Join(", ", Sorting.MergeSort.Mergesort(Sorting.SortTestData.TestCase4)));
            Console.WriteLine(string.Join(", ", Sorting.MergeSort.Mergesort(Sorting.SortTestData.TestCase5)));
            Console.ReadLine();
        }

        private static void TestHashTable()
        {
            var ht = new HashTable<string, int>(5);
            ht.Add("one", 1);
            ht.Add("two", 2);
            ht.Add("three", 3);
            ht.Add("four", 4);
            ht.Add("five", 5);
            Console.WriteLine(ht.GetValue("one"));
            Console.WriteLine(ht.GetValue("two"));
            Console.WriteLine(ht.GetValue("three"));
            Console.WriteLine(ht.GetValue("four"));
            Console.WriteLine(ht.GetValue("five"));
            Console.ReadLine();
        }
    }
}
