using System;
using System.Linq;

namespace ReverseArray2
{
    class ReverseArray2
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());

            int[] nums = new int[length];

            for (int index = 0; index < length; index++)
            {
                nums[index] = int.Parse(Console.ReadLine());
            }

            nums = nums.Reverse().ToArray(); 
            Console.WriteLine(string.Join(" ", nums));
        }
    }
}
