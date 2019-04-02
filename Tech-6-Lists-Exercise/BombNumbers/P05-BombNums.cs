using System;
using System.Collections.Generic;
using System.Linq;

namespace BombNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> inputNums = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            int[] bombParameter = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();
            int bombNumber = bombParameter[0];
            int powerOfBomb = bombParameter[1];

            while (inputNums.Exists(num => num == bombNumber))
            {
                int bombIndex = inputNums.FindIndex(x => x == bombNumber);
                int firstToRemove = bombIndex - powerOfBomb;

                int lastToRemove = bombIndex + powerOfBomb;
                if (bombIndex - powerOfBomb < 0)
                {
                    firstToRemove = 0;
                }
                if (lastToRemove >= inputNums.Count)
                {
                    lastToRemove = inputNums.Count - 1;
                }

                //for (int i = lastToRemove; i >= firstToRemove; i--)
                //{
                //    inputNums.RemoveAt(i);
                //}
                int count = lastToRemove - firstToRemove;
                inputNums.RemoveRange(firstToRemove, count + 1);
            }

            int sum = inputNums.Sum();
            Console.WriteLine(sum);
        }
    }
}