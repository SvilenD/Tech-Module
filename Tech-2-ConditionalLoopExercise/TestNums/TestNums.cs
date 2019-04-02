using System;

namespace TestNums
{
    class TestNums
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int maxSum = int.Parse(Console.ReadLine());

            int count = 0;
            int sum1 = 0;
            int sum2 = 0;

            for (int index1 = num1; index1 >= 1; index1--)
            {
                for (int index2 = 1; index2 <= num2; index2++)
                {
                    sum1 = 3 * index1 * index2;
                    sum2 += sum1;
                    count++;
                    if (sum2 >= maxSum)
                    {
                        Console.WriteLine($"{count} combinations");
                        Console.WriteLine($"Sum: {sum2} >= {maxSum}");
                        return;
                    }
                }
            }
            Console.WriteLine($"{count} combinations");
            Console.WriteLine("Sum: " + sum2);
        }
    }
}