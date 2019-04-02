using System;
using System.Collections.Generic;

namespace P04_ListOfProducts
{
    class Program
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());

            var list = new List<string>();
            for (int i = 0; i < length; i++)
            {
                list.Add(Console.ReadLine());
            }
            list.Sort();

            int count = 1;
            foreach (var item in list)
            {
                Console.WriteLine($"{count}.{item}");
                count++;
            }
        }
    }
}