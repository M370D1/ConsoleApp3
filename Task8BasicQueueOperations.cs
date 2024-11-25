using System;
using System.Linq;

namespace ConsoleApp3
{
    internal class Task8BasicQueueOperations // Basic Queue Operations
    {
        public static void Execute()
        {
            Console.WriteLine("Enter space-separated nteger N representing the number of elements to enqueue (add)," +
                " an integer S representing the number of elements to dequeue (remove) from the " +
                "queue and finally an integer X, an element that you should look for in the queue.");
            string[] input = Console.ReadLine().Split();
            int n = int.Parse(input[0]); // Number of elements to enqueue
            int s = int.Parse(input[1]); // Number of elements to dequeue
            int x = int.Parse(input[2]); // Element to search for

            Console.WriteLine("Enter queue of integers separated by space");
            int[] elements = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Queue<int> queue = new Queue<int>();

            for (int i = 0; i < n; i++)
            {
                if (i < elements.Length)
                    queue.Enqueue(elements[i]);
            }

            for (int i = 0; i < s; i++)
            {
                if (queue.Count > 0)
                    queue.Dequeue();
            }

            if (queue.Contains(x))
            {
                Console.WriteLine("true");
            }
            else if (queue.Count > 0)
            {
                Console.WriteLine(queue.Min());
            }
            else
            {
                Console.WriteLine(0);
            }
        }
    }
}
