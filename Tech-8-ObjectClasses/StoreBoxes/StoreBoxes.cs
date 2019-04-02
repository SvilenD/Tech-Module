using System;
using System.Collections.Generic;
using System.Linq;

namespace StoreBoxes
{
    public class Item
    {
        public Item(string itemName, decimal itemPrice)
        {
            Name = itemName;
            Price = itemPrice;
        }

        public string Name { get; set; }
        public decimal Price { get; set; }
    }

    public class Box
    {
        public Box(string serialNumber, Item item, int itemQuantity)
        {
            SerialNumber = serialNumber;
            Item = item;
            Quantity = itemQuantity;
            PriceBox = Quantity * Item.Price;
        }

        public string SerialNumber { get; set; }
        public Item Item { get; set; }
        public int Quantity { get; set; }
        public decimal PriceBox { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Box> boxes = new List<Box>();

            while (true)
            {
                string[] input = Console.ReadLine().Split();

                if (input[0] == "end")
                {
                    break;
                }

                string serialNumber = input[0];
                string itemName = input[1];
                int itemQuantity = int.Parse(input[2]);
                decimal itemPrice = decimal.Parse(input[3]);

                var item = new Item(itemName, itemPrice);
                var box = new Box(serialNumber, item, itemQuantity);
                
                boxes.Add(box);
            }

            List<Box> sortedBoxes = boxes.OrderByDescending(x => x.PriceBox).ToList();

            foreach (var box in sortedBoxes)
            {
                Console.WriteLine($"{box.SerialNumber}");
                Console.WriteLine($"-- {box.Item.Name} - ${box.Item.Price:F2}: {box.Quantity}");
                Console.WriteLine($"-- ${box.PriceBox:F2}");
            }
        }
    }
}