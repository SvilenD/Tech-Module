using System;
using System.Collections.Generic;
using System.Linq;

namespace P04_ListOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            while (true)
            {
                string[] input = Console.ReadLine().Split();

                if (input[0].ToLower() == "end")
                {
                    break;
                }
                string command = input[0];
                switch (command)
                {
                    case "Add": int num = int.Parse(input[1]);
                        numbers.Add(num);
                        break;
                    case "Insert": InsertNumber(numbers, input);
                        break;
                    case "Remove": RemoveNumber(numbers, input);
                        break;
                    case "Shift": ShiftNumbers(numbers, input);
                        break;
                }
            }
                Console.WriteLine(string.Join(" ", numbers));
        }

        private static void ShiftNumbers(List<int> numbers, string[] input)
        {
            int count = int.Parse(input[2]);
            if (input[1] == "left")
            {
                for (int i = 0; i < count; i++)
                {
                    numbers.Add(numbers[0]);
                    numbers.RemoveAt(0);
                }
            }
            else //right
            {
                for (int i = 0; i < count; i++)
                {
                    numbers.Insert(0, numbers[numbers.Count - 1]);
                    numbers.RemoveAt(numbers.Count - 1);
                }
            }
        }

        private static void InsertNumber(List<int> numbers, string[] input)
        {
            int num = int.Parse(input[1]);
            int index = int.Parse(input[2]);
            if (index > numbers.Count || index < 0)
            {
                Console.WriteLine("Invalid index");
            }
            else
            {
                numbers.Insert(index, num);
            }
        }

        private static void RemoveNumber(List<int> numbers, string[] input)
        {
            int index = int.Parse(input[1]);
            if (index > numbers.Count || index < 0)
            {
                Console.WriteLine("Invalid index");
            }
            else
            {
                numbers.RemoveAt(index);
            }
        }
    }
}
