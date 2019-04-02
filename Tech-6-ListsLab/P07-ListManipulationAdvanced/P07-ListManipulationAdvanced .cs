using System;
using System.Collections.Generic;
using System.Linq;

namespace P07_ListManipulationAdvanced
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            bool changes = false;
            while (true)
            {
                string[] input = Console.ReadLine().Split();

                if (input[0] == "end")
                {
                    break;
                }

                int number = 0;
                int index = 0;

                switch (input[0])
                {
                    case "Add":
                        number = int.Parse(input[1]);
                        list.Add(number);
                        changes = true;
                        break;

                    case "Remove":
                        number = int.Parse(input[1]);
                        list.Remove(number);
                        changes = true;
                        break;

                    case "RemoveAt":
                        index = int.Parse(input[1]);
                        list.RemoveAt(index);
                        changes = true;
                        break;

                    case "Insert":
                        number = int.Parse(input[1]);
                        index = int.Parse(input[2]);
                        list.Insert(index, number);
                        changes = true;
                        break;

                    case "Contains":
                        number = int.Parse(input[1]);
                        if (list.Contains(number)) Console.WriteLine("Yes");
                        else Console.WriteLine("No such number");
                        break;

                    case "PrintEven":
                        Console.WriteLine(string.Join(" ", list.Where(x=>x % 2 ==0)));
                        break;

                    case "PrintOdd":
                        Console.WriteLine(string.Join(" ", list.Where(x => x % 2 != 0)));
                        break;

                    case "GetSum":
                        Console.WriteLine(list.Sum());
                        break;

                    case "Filter":
                        number = int.Parse(input[2]);
                        if (input[1] == "<") Console.WriteLine(string.Join(" ", list.Where(x => x < number)));
                        else if (input[1] == ">") Console.WriteLine(string.Join(" ", list.Where(x => x > number)));
                        else if (input[1] == ">=") Console.WriteLine(string.Join(" ", list.Where(x => x >= number)));
                        else if (input[1] == "<=") Console.WriteLine(string.Join(" ", list.Where(x => x <= number)));
                        break;
                }
            }
            if (changes)
            {
                Console.WriteLine(string.Join(" ", list));
            }
        }
    }
}