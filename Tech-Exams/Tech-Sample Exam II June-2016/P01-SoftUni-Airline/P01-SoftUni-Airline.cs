using System;

namespace P01_SoftUni_Airline
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal flightCount = decimal.Parse(Console.ReadLine());

            decimal total = 0;
            for (int i = 0; i < flightCount; i++)
            {
                int adultPassCount = int.Parse(Console.ReadLine());
                decimal adultTicketPrice = decimal.Parse(Console.ReadLine());
                int youngPassCount = int.Parse(Console.ReadLine());
                decimal youngTicketPrice = decimal.Parse(Console.ReadLine());
                decimal fuelPricePerHour = decimal.Parse(Console.ReadLine());
                decimal consumptionPerHour = decimal.Parse(Console.ReadLine());
                decimal flightDuration = decimal.Parse(Console.ReadLine());

                decimal profit = adultTicketPrice * adultPassCount + youngTicketPrice * youngPassCount;
                profit -= flightDuration * fuelPricePerHour * consumptionPerHour;

                if (profit >= 0)
                {
                    Console.WriteLine($"You are ahead with {profit:f3}$.");
                }
                else
                {
                    Console.WriteLine($"We've got to sell more tickets! We've lost {profit:f3}$.");
                }

                total += profit;
            }
            Console.WriteLine($"Overall profit -> {total:f3}$.");
            Console.WriteLine($"Average profit -> {(total/flightCount):f3}$.");
        }
    }
}