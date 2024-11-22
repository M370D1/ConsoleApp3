using System;

namespace ConsoleApp3
{
    internal class Task2MaxSequenceOfEqualElements // Max Sequence Of Equal Elements
    {
        public static void Execute()
        {
            Console.WriteLine("Enter an array of integers (space-separated):");
            string input = Console.ReadLine();
            int[] arr = Array.ConvertAll(input.Split(' '), int.Parse);

            int maxLength = 1;
            int maxStartIndex = 0;
            int currentLength = 1;
            int currentStartIndex = 0;

            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] == arr[i - 1])
                {
                    currentLength++;  
                }
                else
                {
                    if (currentLength > maxLength)
                    {
                        maxLength = currentLength;
                        maxStartIndex = currentStartIndex;
                    }

                    currentLength = 1;
                    currentStartIndex = i;
                }
            }

            if (currentLength > maxLength)
            {
                maxLength = currentLength;
                maxStartIndex = currentStartIndex;
            }

            Console.WriteLine("Longest sequence of equal elements:");
            for (int i = maxStartIndex; i < maxStartIndex + maxLength; i++)
            {
                Console.Write(arr[i] + " ");
            }
        }
    }
}
