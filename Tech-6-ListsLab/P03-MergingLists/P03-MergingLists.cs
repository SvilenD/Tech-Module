using System;
using System.Collections.Generic;
using System.Linq;

namespace P03_MergingLists
{
    class Program
    {
        static void Main(string[] args)
        {
            var first = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            var second = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            var merged = new List<int>();

            int length = Math.Min(first.Count, second.Count);
            for (int i = 0; i < length; i++)
            {
                merged.Add(first[i]);
                merged.Add(second[i]);
            }
            if (first.Count > second.Count)
            {
                int count = first.Count - second.Count;
                merged.AddRange(first.TakeLast(count));
            }
            else if(first.Count < second.Count)
            {
                int count = second.Count - first.Count;
                merged.AddRange(second.TakeLast(count));
            }

            Console.WriteLine(string.Join(" ", merged));
        }
    }
}