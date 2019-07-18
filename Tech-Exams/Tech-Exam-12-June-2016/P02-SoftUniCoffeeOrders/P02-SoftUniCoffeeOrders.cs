using System;
using System.Collections.Generic;
using System.Linq;

namespace P02_SoftUniCoffeeOrders
{
    class Program
    {
        static void Main(string[] args)
        {
            int ordersCount = int.Parse(Console.ReadLine());

            List<string> priceList = new List<string>();

            decimal totalPrice = 0;
            for (int index = 0; index < ordersCount; index++)
            {
                decimal capsulePrice = decimal.Parse(Console.ReadLine());

                int[] orderDate = Console.ReadLine().Split('/').Select(int.Parse).ToArray();

                int capsulesCount = int.Parse(Console.ReadLine());

                int daysInMonth = DateTime.DaysInMonth(orderDate[2], orderDate[1]);

                decimal coffeePrice = (capsulePrice * daysInMonth * capsulesCount); //capsulePrice трябва да е първо във формулата, 
                                                                                    //защото иначе умножава инт по инт и инта се препълва

                priceList.Add($"The price for the coffee is: ${coffeePrice:F2}");

                totalPrice += coffeePrice;
            }

            foreach (var price in priceList)
            {
                Console.WriteLine(price);
            }

            Console.WriteLine($"Total: ${totalPrice:F2}");
        }
    }
}