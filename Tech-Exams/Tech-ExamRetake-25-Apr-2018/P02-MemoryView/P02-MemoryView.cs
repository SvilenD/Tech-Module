using System;
using System.Collections.Generic;
using System.Linq;

namespace P02_MemoryView
{
    class Program
    {
        static void Main(string[] args)
        {
            var nums = new List<int>();
            while (true)
            {
                var input = Console.ReadLine();
                if (input == "Visual Studio crash")
                {
                    break;
                }
                nums.AddRange(input
                    .Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToList());
            }
            nums.RemoveAll(x => x == 0);
            while (nums.Count > 0)
            {
                int index = nums.IndexOf(32763);
                if (index < 0)
                {
                    break;
                }
                nums.RemoveRange(0, index + 1);
                int length = nums[0];
                nums.Remove(length);
                if (nums.Count < length)
                {
                    break;
                }
                string output = string.Empty;
                for (int i = 0; i < length; i++)
                {
                    output += (char)(nums[i]);
                }
                Console.WriteLine(output);
                nums.RemoveRange(0, length);
            }
        }
    }
}

