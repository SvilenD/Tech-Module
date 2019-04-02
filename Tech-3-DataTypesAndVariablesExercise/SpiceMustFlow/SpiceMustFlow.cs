using System;

namespace SpiceMustFlow
{
    class Program
    {
        static void Main(string[] args)
        {
            int startingYield = int.Parse(Console.ReadLine());

            int extracted = 0;
            int daysCount = 0;

            while (startingYield >= 100)
            {
                extracted += startingYield - 26;
                startingYield -= 10;
                daysCount++;
            }
            Console.WriteLine(daysCount);
            if (extracted > 26)
            {
            Console.WriteLine(extracted - 26);
            }
            else
            {
                Console.WriteLine(extracted);
            }
        }
    }
}
