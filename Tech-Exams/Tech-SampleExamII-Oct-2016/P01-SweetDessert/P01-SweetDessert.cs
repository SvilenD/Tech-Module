using System;

namespace P01_SweetDessert
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal cashAvailable = decimal.Parse(Console.ReadLine());
            int guestsNum = int.Parse(Console.ReadLine());
            decimal bananasPrice = decimal.Parse(Console.ReadLine());
            decimal eggsPrice = decimal.Parse(Console.ReadLine());
            decimal berriesPrice = decimal.Parse(Console.ReadLine());

            decimal portionsCount = Math.Ceiling(guestsNum / 6m);
            decimal totalCost = portionsCount * (bananasPrice * 2 + eggsPrice * 4 + berriesPrice * 0.2m);

            if (cashAvailable >= totalCost)
            {
                Console.WriteLine($"Ivancho has enough money - it would cost {totalCost:F2}lv.");
            }
            else
            {
                decimal neededMoney = totalCost - cashAvailable;
                Console.WriteLine($"Ivancho will have to withdraw money - he will need {neededMoney:F2}lv more.");
            }
        }
    }
}
