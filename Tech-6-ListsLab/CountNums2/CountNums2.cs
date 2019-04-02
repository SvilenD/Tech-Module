using System;
using System.Collections.Generic;
using System.Linq;

namespace CountNums2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbersList = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            numbersList.Sort();

            int maxNum = numbersList.Max(); //намирам най-голямото число от Листа

            int[] counters = new int[maxNum +1]; // правя масив от 0 до най-голямото число

            for (int i = 0; i < numbersList.Count; i++) // за всяка позиция(=числото в Листа) запазвам колко пъти го има в листа; 
            {
                int index = numbersList[i];
                counters[index]++;
            }

            for (int i = 0; i < counters.Length; i++)
            {
                if (counters[i] != 0)
                {
                    Console.WriteLine($"{i} - > {counters[i]}");
                }
            }
        }
    }
}
