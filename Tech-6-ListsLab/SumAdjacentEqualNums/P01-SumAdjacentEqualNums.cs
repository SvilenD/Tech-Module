﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace SumAdjacentEqualNums
{
    class SumAdjacentEqualNums
    {
        static void Main(string[] args)
        {
            List<double> input = Console.ReadLine()
                .Split(' ')
                .Select(double.Parse)
                .ToList();

            for (int i = 0; i < input.Count - 1; i++)
            {
                if (input[i] == input[i + 1])
                {
                    input[i] += input[i + 1];
                    input.RemoveAt(i + 1);
                    i = -1;
                }
            }
            Console.WriteLine(string.Join(" ", input));
        }
    }
}