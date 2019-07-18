using System;
using System.Collections.Generic;
using System.Linq;

namespace P04_SantasNewList
{
    class Program
    {
        static void Main(string[] args)
        {
            var kids = new SortedDictionary<string, int>(); //if not Sorted .ThenBy()
            var presents = new Dictionary<string, int>();

            while (true)
            {
                var input = Console.ReadLine().Split("->");
                if (input[0] == "END")
                {
                    break;
                }
                else if (input[0] == "Remove")
                {
                    var name = input[1];
                    if (kids.ContainsKey(name)) ;
                    {
                        kids.Remove(name);
                    }
                }
                else
                {
                    var name = input[0];
                    var gift = input[1];
                    int quantity = int.Parse(input[2]);
                    if (!kids.ContainsKey(name))
                    {
                        kids.Add(name, quantity);
                    }
                    else
                    {
                        kids[name] += quantity;
                    }
                    if (!presents.ContainsKey(gift))
                    {
                        presents.Add(gift, quantity);
                    }
                    else
                    {
                        presents[gift] += quantity;
                    }
                }
            }
            Console.WriteLine("Children:");
            foreach (var kid in kids.OrderByDescending(x => x.Value))
            {
                Console.WriteLine($"{kid.Key} -> {kid.Value}");
            }
            Console.WriteLine("Presents:");
            foreach (var gift in presents)
            {
                Console.WriteLine($"{gift.Key} -> {gift.Value}");
            }
        }
    }
}