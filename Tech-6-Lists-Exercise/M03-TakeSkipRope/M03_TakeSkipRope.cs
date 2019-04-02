using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace M03_TakeSkipRope
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            var numbers = new List<int>();
            var symbols = new List<char>();

            for (int i = 0; i < input.Length; i++)
            {
                if (char.IsDigit(input[i]))
                {
                    numbers.Add(int.Parse(input[i].ToString()));
                }
                else
                {
                    symbols.Add(input[i]);
                }
            }
            var takeList = new List<int>(); //even indexes from numbers
            var skipList = new List<int>(); //odd indexes

            for (int i = 0; i < numbers.Count; i++)
            {
                if (i % 2 == 0)
                {
                    takeList.Add(numbers[i]);
                }
                else
                {
                    skipList.Add(numbers[i]);
                }
            }

            var result = new List<char>();
            for (int i = 0; i < takeList.Count; i++)
            {
                result.AddRange(symbols.Take(takeList[i]));
                if (i == takeList.Count - 1)
                {
                    break;
                }
                symbols.RemoveRange(0, takeList[i] + skipList[i]);
            }
            Console.WriteLine(string.Join("", result));
        }
    }
}
