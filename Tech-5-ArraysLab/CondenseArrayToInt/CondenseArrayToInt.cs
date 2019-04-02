using System;
using System.Linq;

namespace CondenseArrayToInt
{
    class CondenseArrayToInt
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine()
                .Split()
                .Select(int.Parse).
                ToArray();

            while (true)
            {
                if (array.Length == 1)
                {
                    Console.WriteLine($"{array[0]}");
                    break;
                }
                int[] condensed = new int[array.Length - 1];

                for (int i = 0; i < array.Length -1; i++)
                {
                    condensed[i] = array[i] + array[i + 1];
                }
                array = condensed;
            }
        }
    }
}