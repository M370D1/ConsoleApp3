using System;

namespace ConsoleApp3
{
    internal class Task3Train
    {
        public static void Execute()
        {
            Console.WriteLine("Enter integers to represent passengers for each wagon (space-separated):");
            List<int> wagons = Console.ReadLine().Split().Select(int.Parse).ToList();

            Console.WriteLine("Enter wagons' max capacity:");
            if (!int.TryParse(Console.ReadLine(), out int maxCapacity) || maxCapacity < wagons.Max())
            {
                Console.WriteLine("Error: Max capacity must be greater than or equal to the largest number of passengers in any wagon.");
                return;
            }

            Console.WriteLine("You can enter commands until \"end\":\n" +
                              "1. Add {passengers} – Adds a wagon with the specified number of passengers.\n OR \n" +
                              "2. {passengers} – Tries to fit the passengers into existing wagons starting from the first.");

            string command;
            while ((command = Console.ReadLine()) != "end")
            {
                string[] parts = command.Split();

                if (parts[0] == "Add" && parts.Length == 2 && int.TryParse(parts[1], out int newWagonPassengers))
                {
                    if (newWagonPassengers <= maxCapacity)
                    {
                        wagons.Add(newWagonPassengers);
                    }
                    else
                    {
                        Console.WriteLine($"Error: Number of passengers in the wagon can't be greater than {maxCapacity}.");
                    }
                }
                else if (parts.Length == 1 && int.TryParse(parts[0], out int passengersToFit))
                {
                    bool fitted = false;
                    for (int i = 0; i < wagons.Count; i++)
                    {
                        if (wagons[i] + passengersToFit <= maxCapacity)
                        {
                            wagons[i] += passengersToFit;
                            fitted = true;
                            break;
                        }
                    }

                    if (!fitted)
                    {
                        Console.WriteLine($"Error: Could not fit {passengersToFit} passengers into any wagon.");
                    }
                }
                else
                {
                    Console.WriteLine("Error: Invalid command. Use 'Add {passengers}' or '{passengers}' only.");
                }
            }

            Console.WriteLine("Final state of wagons:");
            Console.WriteLine(string.Join(" ", wagons));
        }
    }
}
