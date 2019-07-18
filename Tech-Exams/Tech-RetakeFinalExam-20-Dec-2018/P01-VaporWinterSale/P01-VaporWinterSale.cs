using System;
using System.Collections.Generic;
using System.Linq;

namespace P01_VaporWinterSale
{
    class Program
    {
        static void Main(string[] args)
        {
            var games = new Dictionary<string, decimal>();
            var gamesWithDLC = new Dictionary<string, decimal>();

            var input = Console.ReadLine().Split(", ");
            for (int i = 0; i < input.Length; i++)
            {
                var currentGame = input[i];

                if (currentGame.Contains('-'))
                {
                    var gameSplit = currentGame.Split('-');
                    var name = gameSplit[0];
                    var price = decimal.Parse(gameSplit[1]);
                        
                    if (!games.ContainsKey(name) && !gamesWithDLC.ContainsKey(name))
                    {
                        games.Add(name, price);
                    }
                }
                else if (currentGame.Contains(':'))
                {
                    var gameSplit = currentGame.Split(':');
                    var name = gameSplit[0];
                    var DLC = gameSplit[1];

                    if (games.ContainsKey(name) && !gamesWithDLC.ContainsKey(name))
                    {
                        decimal price = games.First(x=>x.Key == name).Value;
                        price *= 1.2m; 
                        gamesWithDLC.Add($"{name} - {DLC}", price);
                        games.Remove(name);
                    }
                }
            }
            foreach (var game in gamesWithDLC.OrderBy(x=>x.Value))
            {
                Console.WriteLine($"{game.Key} - {(game.Value * 0.5m):f2}");
            }

            foreach (var game in games.OrderByDescending(x => x.Value))
            {
                Console.WriteLine($"{game.Key} - {(game.Value * 0.8m):f2}");
            }
        }
    }
}