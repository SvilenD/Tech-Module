using System;
using System.Collections.Generic;
using System.Linq;

namespace SearchForNum2 //Liovan, .Take не работи!!! тестовете в judge ги минава!?!
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> lineOfDigits = Console.ReadLine().Split().Select(int.Parse).ToList();

            List<int> lineOfCommands = Console.ReadLine().Split().Select(int.Parse).ToList();

            int takeThisMuchDigits = lineOfCommands[0];

            int removeThisMuchDigits = lineOfCommands[1];

            int numToFind = lineOfCommands[2];

            lineOfDigits.Take(takeThisMuchDigits);
            lineOfDigits.RemoveRange(0, removeThisMuchDigits);

            if (lineOfDigits.Contains(numToFind))
            {
                Console.WriteLine("YES!");
            }
            else
            {
                Console.WriteLine("NO!");
            }
        }
    }
}