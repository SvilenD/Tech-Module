using System;
using System.Collections.Generic;
using System.Linq;

namespace MaxSeqEqualNums
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numsList = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            int count = 1;
            int maxCount = 1;
            int number = numsList[0];
            for (int i = 0; i < numsList.Count - 1; i++)
            {
                if (numsList[i] == numsList[i + 1])
                {
                    count++;
                    if (count > maxCount)
                    {
                        maxCount = count;
                        number = numsList[i];
                    }
                }
                else count = 1;
            }
            for (int i = 0; i < maxCount; i++)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine();
        }
    }
}