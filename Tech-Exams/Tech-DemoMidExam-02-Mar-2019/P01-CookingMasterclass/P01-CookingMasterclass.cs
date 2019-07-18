using System;

namespace P01_CookingMasterclass
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal budget = decimal.Parse(Console.ReadLine());
            int students = int.Parse(Console.ReadLine());
            decimal flourPrice = decimal.Parse(Console.ReadLine());
            decimal eggPrice = decimal.Parse(Console.ReadLine());
            decimal apronPrice = decimal.Parse(Console.ReadLine());

            int aprons = (int)Math.Ceiling(students * 1.2);
            int flour = students - students / 5;
            decimal totalCost = flour * flourPrice + students * 10 * eggPrice + aprons * apronPrice;

            if (budget >= totalCost)
            {
                Console.WriteLine($"Items purchased for {totalCost:f2}$.");
            }
            else
            {
                Console.WriteLine($"{(totalCost - budget):f2}$ more needed.");
            }
        }
    }
}