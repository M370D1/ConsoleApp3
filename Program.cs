using System;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose a task to execute (1-8):");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Task1CommonElements.Execute();
                    break;
                case "2":
                    Task2MaxSequenceOfEqualElements.Execute();
                    break;
                case"3":
                    Task3Train.Execute();
                    break;
                case "4":
                    Task4CardsGame.Execute();
                    break;
                case "5":   
                    Task5CoauntCharsInString.Execute();
                    break;
                case "6":
                    Task6MinerTask.Execute();
                    break;
                case "7":
                    Task7BasicStackOperations.Execute();
                    break;
                case "8":
                    Task8BasicQueueOperations.Execute();
                    break;
                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }
        }
    }
}
