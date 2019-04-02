using System;
using System.Collections.Generic;
using System.Linq;


namespace SortNums
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[3];
 
            for (int i = 0; i < 3; i++)
            {
                int num = int.Parse(Console.ReadLine());
                nums[i] = num;
            }

            nums = nums.OrderByDescending(x=>x).ToArray();

            foreach (var num in nums)
            {
                Console.WriteLine(num);
            }
        }
    }
}
