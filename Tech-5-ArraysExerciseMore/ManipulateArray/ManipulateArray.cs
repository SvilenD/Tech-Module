using System;
using System.Linq;

namespace ManipulateArray
{
    class ManipulateArray
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] command = Console.ReadLine().Split();
                switch (command[0])
                {
                    case "Distinct": input = input.Distinct().ToArray(); break;
                    case "Reverse": input = input.Reverse().ToArray(); break;
                    case "Replace": input[int.Parse(command[1])] = command[2]; break;
                }
            }
            Console.WriteLine(string.Join(", ", input));
        }
    }
}