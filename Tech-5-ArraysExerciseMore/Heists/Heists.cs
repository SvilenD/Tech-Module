using System;
using System.Linq;

namespace Heists
{
    class Heists
    {
        static void Main(string[] args)
        {
            int[] prices = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();
            int jewelPrice = prices[0];
            int goldPrice = prices[1];

            string[] input = Console.ReadLine().Split(' ');

            int jewels = 0;
            int gold = 0;
            long money = 0;

            while (true)
            {
                
                if (input[0] == "Jail" && input[1] == "Time")
                {
                    break;
                }
                jewels += input[0].Count(x => x == '%');
                gold += input[0].Count(x => x == '$');
                money -= long.Parse(input[1]);
                input = Console.ReadLine().Split(' ');
            }
            money += jewels * jewelPrice + gold * goldPrice;

            if (money >= 0)
            {
                Console.WriteLine($"Heists will continue. Total earnings: {money}.");
            }
            else Console.WriteLine($"Have to find another job. Lost: {Math.Abs(money)}.");
        }
    }
}