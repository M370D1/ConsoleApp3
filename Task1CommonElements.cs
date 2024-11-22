using System;
using System.Linq;

namespace ConsoleApp3
{
    internal class Task1CommonElements // Comon Elements
    {
        public static void Execute()
        {
            Console.WriteLine("Enter elements of the first array separated by spaces:");
            string[] array1 = Console.ReadLine().Split(' ');

            Console.WriteLine("Enter elements of the second array separated by spaces:");
            string[] array2 = Console.ReadLine().Split(' ');

            var commonElements = array2.Where(element => array1.Contains(element)).ToArray();

            Console.WriteLine("Common elements in both arrays are:");
            if (commonElements.Length > 0)
            {
                foreach (var item in commonElements)
                {
                    Console.WriteLine(item);
                }
            }
            else
            {
                Console.WriteLine("No common elements found.");
            }
        }
    }
}
