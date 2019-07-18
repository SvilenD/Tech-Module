using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int partySize = int.Parse(Console.ReadLine());
            int days = int.Parse(Console.ReadLine());

            int totalCoins = 0;
            for (int i = 1; i <= days; i++)
            {
                if (i % 10 == 0)
                {
                    partySize -= 2;
                }
                if (i % 15 == 0)
                {
                    partySize += 5;
                }
                totalCoins += 50;
                totalCoins -= partySize * 2;

                if (i % 3 == 0)
                {
                    totalCoins -= partySize * 3;
                }
                if (i % 5 == 0)
                {
                    totalCoins += 20 * partySize;
                    if (i % 3 == 0)
                    {
                        totalCoins -= 2 * partySize;
                    }
                }
            }
            int coins = totalCoins / partySize;
            Console.WriteLine($"{partySize} companions received {coins} coins each.");
        }
    }
}
