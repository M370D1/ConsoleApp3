using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp3
{
    internal class Task4CardsGame // Card Games
    {
        public static void Execute()
        {
            Console.WriteLine("Enter integers for both players decks (space-separated" +
                "\nDeck of Player One: ");
            Queue<int> firstPlayer = new Queue<int>(Console.ReadLine().Split().Select(int.Parse));
            Console.WriteLine("Deck of Player Two: ");
            Queue<int> secondPlayer = new Queue<int>(Console.ReadLine().Split().Select(int.Parse));

            List<int> player1WinningPile = new List<int>();
            List<int> player2WinningPile = new List<int>();

            while (firstPlayer.Count > 0 && secondPlayer.Count > 0)
            {
                int firstCard = firstPlayer.Dequeue();
                int secondCard = secondPlayer.Dequeue();

                if (firstCard > secondCard)
                {
                    player1WinningPile.Add(firstCard);
                    player1WinningPile.Add(secondCard);
                }
                else if (secondCard > firstCard)
                {
                    player2WinningPile.Add(firstCard);
                    player2WinningPile.Add(secondCard);
                }
            }

            int player1TotalPoints = player1WinningPile.Sum();
            int player2TotalPoints = player2WinningPile.Sum();

            if (player1TotalPoints > player2TotalPoints)
            {
                Console.WriteLine($"First player wins! Sum: {player1TotalPoints}");
            }
            else if (player2TotalPoints > player1TotalPoints)
            {
                Console.WriteLine($"Second player wins! Sum: {player2TotalPoints}");
            }
            else
            {
                Console.WriteLine("It's a draw!");
            }
        }
    }
}