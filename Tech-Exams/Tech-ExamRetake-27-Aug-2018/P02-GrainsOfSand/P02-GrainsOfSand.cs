using System;
using System.Collections.Generic;
using System.Linq;

namespace P02_GrainsOfSand
{
    class Program
    {
        static void Main(string[] args)
        {
            var numsList = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            while (true)
            {
                var input = Console.ReadLine().Split();
                if (input[0] == "Mort")
                {
                    break;
                }
                if (input[0] == "Add")
                {
                    int num = int.Parse(input[1]);
                    numsList.Add(num);
                }
                else if (input[0] == "Remove")
                {
                    int num = int.Parse(input[1]);
                    Remove(numsList, num);
                }
                else if (input[0] == "Replace")
                {
                    ReplaceValue(numsList, input);
                }
                else if (input[0] == "Increase")
                {
                    int value = int.Parse(input[1]);
                    numsList = IncreaseElements(numsList, value);
                }
                else if (input[0] == "Collapse")
                {
                    int value = int.Parse(input[1]);
                    numsList.RemoveAll(x => x < value);
                }
            }

            Console.WriteLine(string.Join(" ", numsList));
        }

        static List<int> IncreaseElements(List<int> numsList, int value)
        {
            int num = 0;
            if (numsList.Any(x => x >= value))
            {
                num = numsList.Find(x => x >= value);
            }
            else
            {
                num = numsList.Last();
            }
            numsList = numsList.Select(x => x + num).ToList();
            return numsList;
        }

        static void Remove(List<int> numsList, int num)
        {
            if (numsList.Contains(num))
            {
                numsList.Remove(num);
            }
            else if (num >= 0 && num < numsList.Count)
            {
                numsList.RemoveAt(num);
            }
        }

        static void ReplaceValue(List<int> numsList, string[] input)
        {
            int value = int.Parse(input[1]);
            int replacement = int.Parse(input[2]);
            if (numsList.Contains(value))
            {
                int index = numsList.IndexOf(value);
                numsList[index] = replacement;
            }
        }
    }
}
