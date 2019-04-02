using System;
using System.Collections.Generic;
using System.Linq;

namespace P06_ListManipulationBasics
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            while (true)
            {
                string[] input = Console.ReadLine().Split();

                if (input[0] =="end")
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
                        break;
                    case "Remove":
                        number = int.Parse(input[1]);
                        list.Remove(number);
                        break;
                    case "RemoveAt":
                        index = int.Parse(input[1]);
                        list.RemoveAt(index);
                        break;
                    case "Insert":
                        number = int.Parse(input[1]);
                        index = int.Parse(input[2]);
                        list.Insert(index, number);
                        break;
                }
            }

            Console.WriteLine(string.Join(" ", list));
        }
    }
}
