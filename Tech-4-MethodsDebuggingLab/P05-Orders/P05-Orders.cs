using System;

namespace P05_Orders
{
    class Program
    {
        static double price = 0;
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());

            CalculatePrice(product, quantity);
            Console.WriteLine($"{price:f2}");
        }

        static void CalculatePrice(string product, int quantity)
        {
            switch (product)
            {
                case "coffee": price = 1.5 * quantity;
                    break;
                case "water": price = 1 * quantity;
                    break;
                case "coke": price = 1.4 * quantity;
                    break;
                case "snacks": price = 2 * quantity;
                    break;
            }
        }
    }
}
