using System;
using System.Collections.Generic;
using System.Linq;

namespace CountNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            numbers.Sort();

            List<int> counters = new List<int>();

            int count = 1;
            for (int index = 0; index < numbers.Count-1; index++)
            {
                if (numbers[index] == numbers[index + 1])
                {
                    count++;
                    numbers.RemoveAt(index);
                    index--;
                }
                else
                {
                    counters.Add(count);
                    count = 1;
                }
            }
            counters.Add(count);

            for (int i = 0; i < numbers.Count; i++)
            {
            Console.WriteLine("{0} -> {1}", numbers[i], counters[i]);
            }
        }
    }
}