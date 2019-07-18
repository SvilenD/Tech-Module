using System;

namespace P01_SpringVacationTrip
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            decimal budget = decimal.Parse(Console.ReadLine()); //all
            int people = int.Parse(Console.ReadLine());
            decimal fuelPrice = decimal.Parse(Console.ReadLine());
            decimal foodExpenses = decimal.Parse(Console.ReadLine()); //1
            decimal roomPrice = decimal.Parse(Console.ReadLine()); //1

            if (people > 10)
            {
                roomPrice *= 0.75m;
            }
            decimal expenses = days * people * (foodExpenses + roomPrice);

            for (int i = 1; i <= days; i++)
            {
                decimal distance = decimal.Parse(Console.ReadLine());
                expenses += distance * fuelPrice;
                if (i % 7 == 0)
                {
                    expenses -= expenses / (people * 1.0m);
                }
                if (i % 3 == 0 || i % 5 == 0)
                {
                    expenses += expenses * 0.4m;
                }
                if (expenses > budget)
                {
                    Console.WriteLine($"Not enough money to continue the trip. You need {(expenses - budget):f2}$ more.");
                    return;
                }
            }
            budget -= expenses;
            Console.WriteLine($"You have reached the destination. You have {budget:f2}$ budget left.");
        }
    }
}
