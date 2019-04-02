using System;
using System.Collections.Generic;

namespace MinerTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> resourses = new Dictionary<string, int>();

            while (true)
            {
                string type = Console.ReadLine();
                if (type == "stop")
                {
                    break;
                }
                int quantity = int.Parse(Console.ReadLine());

                if (!resourses.ContainsKey(type))
                {
                    resourses.Add(type, 0);
                }
                resourses[type] += quantity;
            }

            foreach (var kvp in resourses)
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value}");

            }
        }
    }
}
