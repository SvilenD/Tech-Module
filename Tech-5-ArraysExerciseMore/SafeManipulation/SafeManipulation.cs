using System;
using System.Linq;

namespace ManipulateArray
{
    class ManipulateArray
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            string[] command = Console.ReadLine().Split();
            while (command[0] != "END")
            {
                switch (command[0])
                {
                    case "Distinct": input = input.Distinct().ToArray(); break;
                    case "Reverse": input = input.Reverse().ToArray(); break;
                    case "Replace":
                        try
                        {
                            input[int.Parse(command[1])] = command[2]; break;
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("Invalid input!"); break;
                        }
                    case "END": break;
                    default: Console.WriteLine("Invalid input!"); break;
                }
                command = Console.ReadLine().Split();
            }
            Console.WriteLine(string.Join(", ", input));
        }
    }
}