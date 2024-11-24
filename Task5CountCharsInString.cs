using System;
using System.Collections.Generic;

namespace ConsoleApp3
{
    internal class Task5CoauntCharsInString // Count Chars In a String
    {
        public static void Execute()
        {
            Console.WriteLine("Enter string:");
            string input = Console.ReadLine();

            Dictionary<char, int> charCounts = new Dictionary<char, int>();

            foreach (char ch in input)
            {
                if (ch != ' ') 
                {
                    if (!charCounts.ContainsKey(ch))
                    {
                        charCounts[ch] = 0;
                    }
                    charCounts[ch]++;
                }
            }

            foreach (var entry in charCounts)
            {
                Console.WriteLine($"{entry.Key} -> {entry.Value}");
            }
        }
    }
}
