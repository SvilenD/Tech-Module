using System;
using System.Collections.Generic;
using System.Linq;

namespace Largest3Nums
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numsList = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToList();

            int[] result = numsList.OrderByDescending(x => x).Take(3).ToArray();

            Console.WriteLine(string.Join(" ", result));
        }
    }
}