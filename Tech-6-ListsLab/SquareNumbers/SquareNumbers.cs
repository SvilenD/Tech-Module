using System;
using System.Collections.Generic;
using System.Linq;

namespace SquareNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numsList = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            numsList = GetSquareNums(numsList);
            numsList.Sort();
            numsList.Reverse();

            Console.WriteLine(string.Join(' ', numsList));
        }

        static List<int> GetSquareNums(List<int> numsList)
        {
            for (int index = 0; index < numsList.Count; index++)
            {
                int temp = (int)(Math.Sqrt(numsList[index]));
                if (!(temp == Math.Sqrt(numsList[index])))
                {
                    numsList.RemoveAt(index);
                    index--;
                }
            }
            return numsList;
        }
    }
}