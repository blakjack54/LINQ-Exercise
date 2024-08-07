using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQ
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Create and populate the list with video game names
            List<string> videoGames = new List<string>
            {
                "The Legend of Zelda",
                "Super Mario Bros",
                "Minecraft",
                "Fortnite",
                "Call of Duty",
                "Overwatch",
                "World of Warcraft",
                "Red Dead Redemption",
                "Halo"
            };

            // Order the list by the length of the game name using LINQ method syntax
            var orderedGames = videoGames.OrderBy(game => game.Length).ToList();

            // Display the ordered list
            Console.WriteLine("Video games ordered by the length of their names:");
            foreach (var game in orderedGames)
            {
                Console.WriteLine(game);
            }
        }
    }
}