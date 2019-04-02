using System;

namespace IntervalOfNumbers
{
    class IntervalOfNumbers
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());

            int startNum = Math.Min(num1, num2);
            int endNum = Math.Max(num1, num2);

            for (int index = startNum; index <= endNum; index++)
            {
                Console.WriteLine(index);
            }
        }
    }
}
