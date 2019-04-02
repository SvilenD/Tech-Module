using System;
using System.Collections.Generic;
using System.Linq;

namespace M04_MixedUpLists
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstNumsList = Console.ReadLine().Split().Select(int.Parse).ToList();
            var secondNumsList = Console.ReadLine().Split().Select(int.Parse).ToList();

            var mixedList = new List<int>();

            int length = Math.Min(firstNumsList.Count, secondNumsList.Count);

            for (int i = 0; i < length; i++)
            {
                mixedList.Add(firstNumsList[0]);
                firstNumsList.RemoveAt(0);
                mixedList.Add(secondNumsList.Last());
                secondNumsList.RemoveAt(secondNumsList.Count - 1);
            }

            int startNum = 0;
            int endNum = 0;
            if (firstNumsList.Count > 0)
            {
                startNum = firstNumsList[0];
                endNum = firstNumsList[1];
            }
            else
            {
                startNum = secondNumsList[0];
                endNum = secondNumsList[1];
            }

            int minNum = Math.Min(startNum, endNum);
            int maxNum = Math.Max(startNum, endNum);

            mixedList.Sort();
            Console.WriteLine(string.Join(" ", mixedList.Where(x => x > minNum && x < maxNum)));
        }
    }
}