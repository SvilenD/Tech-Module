using System;

namespace SignOfInteger
{
    class SignOfInteger
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            string result = GetIntegerSign(input);
            Console.WriteLine($"The number {input} is {result}.");
        }

        static string GetIntegerSign(int num)
        {
            string result = string.Empty;
            if (num < 0)
            {
                result = "negative";
            }
            else if (num == 0)
            {
                result = "zero";
            }
            else result = "positive";

            return result;
        }
    }
}
