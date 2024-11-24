using System;
using System.Collections.Generic;

namespace ConsoleApp3
{
    internal class Task6MinerTask // Miners Task
    {
        public static void Execute()
        {
            Dictionary<string, long> resources = new Dictionary<string, long>();

            while (true)
            {
                Console.WriteLine("Enter resourse or 'stop':");
                string resource = Console.ReadLine();

                if (resource == "stop")
                {
                    break;
                }
                 
                Console.WriteLine("Enter quantity:");
                long quantity = long.Parse(Console.ReadLine());

                if (!resources.ContainsKey(resource))
                {
                    resources[resource] = 0;
                }

                resources[resource] += quantity;
            }

            foreach (var entry in resources)
            {
                Console.WriteLine($"{entry.Key} -> {entry.Value}");
            }
        }
    }
}
