using System;
using System.Collections.Generic;
using System.Linq;


namespace AppendLists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine()
                .Split('|')
                .Reverse()
                .ToList(); //1| 4 5 6 7  |  8 9

            List<string> rearranged = new List<string>();
            for (int i = 0; i < input.Count; i++)
            {
                string[] splitted = input[i].Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
                string merged = string.Join(" ", splitted);
                rearranged.Add(merged);
            }

            Console.WriteLine(string.Join(" ", rearranged));
        }
    }
}
