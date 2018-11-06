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

            StackExample(newarr);

            DictionaryExample();

            SortedExample();

            Console.ReadLine();
        }

        static void ListExample(int[] arr)
        {
            List<int> example = new List<int>();

            foreach (var i in arr)
                {
                example.Add(i);
            }

            Console.WriteLine("\nCheck out this list I made");
            
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

            Console.WriteLine("\nThis one is a linked list");

            foreach (var item in linkExample)
            {
                Console.WriteLine(item);
            }
        }

        static void QueueExample(string[] arr)
        {
            Queue<string> queueExample = new Queue<string>();

            queueExample.Enqueue("queue test");

            foreach (var item in arr)
            {
                queueExample.Enqueue(item);
            }

            Console.WriteLine("\nQueue time!");

            foreach (var item in queueExample)
            {
                Console.Write(item + " ");
            }
        }

        static void StackExample(string[] arr)
        {
            Stack<string> stackExample = new Stack<string>();

            stackExample.Push("stack test");

            foreach (var item in arr)
            {
                stackExample.Push(item);
            }

            Console.WriteLine("\n\nThis one is a stack");

            foreach (var item in stackExample)
            {
                Console.Write(item + " ");
            }
        }

        static void DictionaryExample()
        {
            Dictionary<string, string> animalSounds = new Dictionary<string, string>();

            animalSounds.Add("bark", "dog");
            animalSounds.Add("meow", "cat");
            animalSounds.Add("moo", "cow");
            animalSounds.Add("bray", "donkey");
            animalSounds.Add("wickitwickitwickitwickow", "fox");

            Console.WriteLine("\n\nThis is an animal noise dictionary");

            foreach (var sound in animalSounds)
            {
                Console.WriteLine(sound);
            }
        }

        static void SortedExample()
        {
            SortedList<int, string> sorted = new SortedList<int, string>();

            sorted.Add(3, "third");
            sorted.Add(5, "fifth");
            sorted.Add(1, "first");
            sorted.Add(2, "second");
            sorted.Add(4, "fourth");

            Console.WriteLine("\n\nThis is the sorted list");

            for (int i = 1; i <= sorted.Count; i++)
            {
                Console.WriteLine(sorted[i]);
            }
        }
    }

}
