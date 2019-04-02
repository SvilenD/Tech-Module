using System;
using System.Linq;

namespace P01_SmallestNum
{
    class Program
    {
        static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            int third = int.Parse(Console.ReadLine());

            int[] nums = { first, second, third };

            PrintSmallestNumber(nums);
        }

        static void PrintSmallestNumber(int[] nums)
        {
            int smallest = nums.Min();
            Console.WriteLine(smallest);
        }
    }
}
