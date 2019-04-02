using System;

namespace MaxNum
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());
            int thirdNum = int.Parse(Console.ReadLine());

            int maxNum = GetMaxNum(firstNum, secondNum);
            maxNum = GetMaxNum(maxNum, thirdNum);
            Console.WriteLine(maxNum);
        }

        static int GetMaxNum(int a, int b)
        {
            int max = 0;
            if (a > b)  max = a;
            else        max = b;

            return max; 
        }
    }
}
