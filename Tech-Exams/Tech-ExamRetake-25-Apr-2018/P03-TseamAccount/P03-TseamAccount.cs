using System;
using System.Collections.Generic;
using System.Linq;

namespace P03_TseamAccount
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = Console.ReadLine().Split().ToList();

            while (true)
            {
                var input = Console.ReadLine().Split();
                if (input[0] == "Play!")
                {
                    break;
                }

                var command = input[0];
                var game = input[1];
                if (command == "Install" && !list.Contains(game))
                {
                    list.Add(game);
                }
                else if (command == "Uninstall")
                {
                    list.Remove(game);
                }
                else if (command == "Update" && list.Contains(game))
                {
                    list.Remove(game);
                    list.Add(game);
                }
                else if (command == "Expansion")
                {
                    var split = game.Split('-');
                    game = split[0];
                    var expansion = split[1];
                    if (list.Contains(game))
                    {
                        int index = list.IndexOf(game) + 1;
                        game += ":";
                        game = String.Concat(game, expansion);
                        list.Insert(index, game);
                    }
                }
            }
            Console.WriteLine(string.Join(" ", list));
        }
    }
}