using System;
using System.Collections.Generic;
using System.Linq;

namespace RemoveNegReverse2
{
    class RemoveNegReverse2
    {
        static void Main(string[] args)
        {
            List<int> numList = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            for (int i = 0; i < numList.Count; i++)
            {
                if (numList[i] < 0)
                {
                    numList.RemoveAt(i);
                    i--;
                }
            }
            numList.Reverse();
            if (numList.Count != 0)
            {
                Console.WriteLine(string.Join(" ", numList));
            }
            else Console.WriteLine("empty");
        }
    }
}
