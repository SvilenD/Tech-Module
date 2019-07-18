using System;

namespace P01_GoogleSeaches
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int users = int.Parse(Console.ReadLine());
            double moneyPerSearch = double.Parse(Console.ReadLine());

            double totalMoney = 0;
            for (int i = 1; i <= users; i++)
            {
                string input = Console.ReadLine();

                double numOfWords = double.Parse(input);

                if (numOfWords > 5 || numOfWords < 0)
                {
                    continue;
                }

                double moneyPerUser = days * moneyPerSearch;

                if (numOfWords == 1)
                {
                    moneyPerUser *= 2;
                }

                if (i % 3 == 0)
                {
                    moneyPerUser *= 3;
                }

                totalMoney += moneyPerUser;
            }

            Console.WriteLine($"Total money earned for {days} days: {totalMoney:f2}");
        }
    }
}