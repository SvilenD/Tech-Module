using System;

namespace Hotel
{
    class Hotel
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int nights = int.Parse(Console.ReadLine());

            double studioPrice = 0;
            double doublePrice = 0;
            double masterSuitPrice = 0;
            if (month == "May" || month == "October")
            {
                if (month == "October" && nights > 7)
                {
                    studioPrice = 50 * (nights - 1);
                    doublePrice = 65 * nights;
                    masterSuitPrice = 75 * nights;
                }
                else
                {
                    studioPrice = 50 * nights;
                    doublePrice = 65 * nights;
                    masterSuitPrice = 75 * nights;
                }
                if (nights > 7)
                {
                    studioPrice *= 0.95;
                }
            }
            else if (month == "June" || month == "September")
            {
                if (month == "September" && nights > 7)
                {
                    studioPrice = 60 * (nights - 1);
                    doublePrice = 72 * nights;
                    masterSuitPrice = 82 * nights;
                }
                else
                {
                    studioPrice = 60 * nights;
                    doublePrice = 72 * nights;
                    masterSuitPrice = 82 * nights;
                }
                if (nights > 14)
                {
                    doublePrice *= 0.90;
                }
            }
            else if (month == "July" || month == "August" || month == "December")
            {
                studioPrice = 68 * nights; doublePrice = 77 * nights; masterSuitPrice = 89 * nights;
                if (nights > 14)
                {
                    masterSuitPrice *= 0.85;
                }
            }
            Console.WriteLine($"Studio: {studioPrice:f2} lv.");
            Console.WriteLine($"Double: {doublePrice:f2} lv.");
            Console.WriteLine($"Suite: {masterSuitPrice:f2} lv.");
        }
    }
}