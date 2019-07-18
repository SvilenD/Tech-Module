using System;

namespace P01_SantasCookies
{
    class Program
    {
        static int cookieGrams = 25;
        static int cup = 140;
        static int smallSpoon = 10;
        static int bigSpoon = 20;
        static int cookiesPerBox = 5;

        static void Main(string[] args)
        {
            int amountOfBatches = int.Parse(Console.ReadLine());

            int totalBoxes = 0;
            for (int i = 0; i < amountOfBatches; i++)
            {
                int flourGrams = int.Parse(Console.ReadLine());
                int sugarGrams = int.Parse(Console.ReadLine());
                int cocoaGrams = int.Parse(Console.ReadLine());

                int flourCups = flourGrams / cup;
                int sugarSpoons = sugarGrams / bigSpoon;
                int cocoaSpoons = cocoaGrams / smallSpoon;

                int minSpoons = Math.Min(sugarSpoons, cocoaSpoons);
                int totalMin = Math.Min(flourCups, minSpoons);
                int totalCookies = (cup + smallSpoon + bigSpoon) * totalMin / cookieGrams;
                if (totalCookies < 5)
                {
                    Console.WriteLine($"Ingredients are not enough for a box of cookies.");
                }
                else
                {
                    int boxes = totalCookies / cookiesPerBox;
                    Console.WriteLine($"Boxes of cookies: {boxes}");
                    totalBoxes += boxes;
                }
            }
            Console.WriteLine($"Total boxes: {totalBoxes}");
        }
    }
}