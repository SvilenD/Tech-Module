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
                string[] product = Console.ReadLine().Split();
                if (product[0] == "done")
                {
                    break;
                }
                long orderedQuantity = long.Parse(product[1]);

                int index = Array.IndexOf(productsNames, product[0]);
                
                try
                {
                    decimal cost = orderedQuantity * prices[index];
                    if (quantities[index] >= orderedQuantity)
                    {
                    quantities[index] -= orderedQuantity;
                    Console.WriteLine($"{product[0]} x {orderedQuantity} costs {cost:f2}");
                    }
                    else Console.WriteLine($"We do not have enough {product[0]}");
                }
                catch (Exception)
                {
                    Console.WriteLine($"We do not have enough {product[0]}");
                }
            }
        }
    }
}