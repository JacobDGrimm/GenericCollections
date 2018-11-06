using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            ListExample(arr);

            LinkedExample(arr);

            string[] newarr = new string[] { "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            QueueExample(newarr);

            Console.ReadLine();
        }

        static void ListExample(int[] arr)
        {
            List<int> example = new List<int>();

            foreach (var i in arr)
                {
                example.Add(i);
            }

            Console.WriteLine("Check out this list I made");
            
            foreach (var num in example)
            {
                Console.WriteLine(num);
            }
        }

        static void LinkedExample(int[] arr)
        {
            LinkedList<int> linkExample = new LinkedList<int>();

            linkExample.AddFirst(0);

            foreach (var i in arr)
            {
                linkExample.AddLast(i);
            }

            Console.WriteLine("This one is a linked list");

            foreach (var item in linkExample)
            {
                Console.WriteLine(item);
            }
        }

        static void QueueExample(string[] arr)
        {
            Queue<string> queueExample = new Queue<string>();

            foreach (var item in arr)
            {
                queueExample.Enqueue(item);
            }

            Console.WriteLine("Queue time!");

            foreach (var item in queueExample)
            {
                Console.Write(item + " ");
            }
        }
    }

}
