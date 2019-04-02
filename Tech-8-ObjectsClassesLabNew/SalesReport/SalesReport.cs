using System;
using System.Collections.Generic;
using System.Linq;

namespace SalesReport
{
    class Sale
    {
        public string Town { get; set; }

        public string Product { get; set; }

        public double Price { get; set; }

        public double Quantity { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());

            var salesList = new List<Sale>();
            var townsList = new List<string>();
            for (int i = 0; i < length; i++)
            {
                var sale = ReadSale();
                salesList.Add(sale);
                if (!townsList.Contains(sale.Town))
                {
                    townsList.Add(sale.Town);
                }
            }
            townsList.Sort();

            for (int i = 0; i < townsList.Count; i++)
            {
                double citySalesSum = 0;
                foreach (var sale in salesList.Where(x=>x.Town == (townsList[i])))
                {
                    citySalesSum += sale.Quantity * sale.Price;
                }
                Console.WriteLine($"{townsList[i]} -> {citySalesSum:f2}");
            }
        }

        static Sale ReadSale()
        {
            var info = Console.ReadLine().Split();
            string town = info[0];
            string product = info[1];
            double price = double.Parse(info[2]);
            double quantity = double.Parse(info[3]);

            var sale = new Sale
            {
                Town = town,
                Product = product,
                Price = price,
                Quantity = quantity
            };
            return sale;
        }
    }
}