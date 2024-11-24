using System;
using System.Collections.Generic;

namespace ConsoleApp3
{
    internal class CountCharsInString // Count Chars In a String
    {
        public static void Execute()
        {
            // Read the input string
            string input = Console.ReadLine();

            // Dictionary to store character counts
            Dictionary<char, int> charCounts = new Dictionary<char, int>();

            // Iterate through the string
            foreach (char ch in input)
            {
                if (ch != ' ') // Ignore spaces
                {
                    if (!charCounts.ContainsKey(ch))
                    {
                        charCounts[ch] = 0;
                    }
                    charCounts[ch]++;
                }
            }

            // Print the result in the desired format
            foreach (var entry in charCounts)
            {
                Console.WriteLine($"{entry.Key} -> {entry.Value}");
            }
        }
    }
}
