using System;
using System.Collections.Generic;
using System.Linq;

namespace P07_StoreBoxes
{
    class Item
    {
        public Item(string name, decimal price)
        {
            this.ItemName = name;
            this.ItemPrice = price;
        }
        public string ItemName { get; set; }

        public decimal ItemPrice { get; set; }
    }

    class Box
    {
        public Box(ulong serialNum, Item item, int quantity)
        {
            this.SerialNum = serialNum;
            this.Item = item;
            this.Quantity = quantity;
            this.Price = quantity * item.ItemPrice; 
        }

        public ulong SerialNum { get; set; }

        public Item Item { get; set; }

        public int Quantity { get; set; }

        public decimal Price { get; set; }
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
                ulong serialNum = ulong.Parse(input[0]);
                string name = input[1];
                int quantity = int.Parse(input[2]);
                decimal price = decimal.Parse(input[3]);

                var item = new Item(name, price);
                var box = new Box(serialNum, item, quantity);
                boxes.Add(box);
            }

            boxes = boxes.OrderByDescending(x => x.Price).ToList();

            foreach (var box in boxes)
            {
                Console.WriteLine($"{box.SerialNum}");
                Console.WriteLine($"-- {box.Item.ItemName} - ${box.Item.ItemPrice:F2}: {box.Quantity}");
                Console.WriteLine($"-- ${box.Price:F2}");
            }
        }
    }
}