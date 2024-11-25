using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp3
{
    internal class Task7BasicStackOperations // Basic Stack Operations
    {
        public static void Execute()
        {
            Console.WriteLine("Enter space ceparated integer N representing the number of elements to push into the" +
                " stack, an integer S representing the number of elements to pop from the stack and" +
                " finally an integer X, an element that you should look for in the stack");
            int[] inputs = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int N = inputs[0]; // Number of elements to push
            int S = inputs[1]; // Number of elements to pop
            int X = inputs[2]; // Element to check for in the stack

            Console.WriteLine("Enter stack of integers separated by space:");
            int[] elements = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Stack<int> stack = new Stack<int>();

            for (int i = 0; i < N; i++)
            {
                stack.Push(elements[i]);
            }

            for (int i = 0; i < S && stack.Count > 0; i++)
            {
                stack.Pop();
            }

            if (stack.Count == 0)
            {
                Console.WriteLine(0);
            }
            else if (stack.Contains(X))
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine(stack.Min());
            }
        }
    }
}
