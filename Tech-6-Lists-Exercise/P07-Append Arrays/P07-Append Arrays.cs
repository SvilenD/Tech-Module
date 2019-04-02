using System;
using System.Collections.Generic;
using System.Linq;

namespace P07_Append_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split('|').Reverse().ToList();

            var result = new List<string>();
            foreach (var item in input)
            {
                var nums = item.Split(' ').ToList();
                foreach (var num in nums)
                {
                    if (num != "") result.Add(num);
                }
            }
            Console.WriteLine(string.Join(" ", result));
        }
    }
}