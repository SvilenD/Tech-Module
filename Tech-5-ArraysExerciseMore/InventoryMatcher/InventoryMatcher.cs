using System;
using System.Linq;

namespace InventoryMatcher
{
    class InventoryMatcher
    {
        static void Main(string[] args)
        {
            string[] productsNames = Console.ReadLine().Split();
            long[] quantities = Console.ReadLine().Split().Select(long.Parse).ToArray();
            decimal[] prices = Console.ReadLine().Split().Select(decimal.Parse).ToArray();

            while (true)
            {
                string product = Console.ReadLine();
                if (product == "done")
                {
                    break;
                }
                int index = Array.IndexOf(productsNames, product);
                Console.WriteLine($"{product} costs: {prices[index]}; Available quantity: {quantities[index]}");
            }
        }
    }
}