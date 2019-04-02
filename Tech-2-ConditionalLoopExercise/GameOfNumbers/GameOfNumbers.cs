using System;

namespace GameOfNumbers
{
    class GameOfNumbers
    {
        static void Main(string[] args)
        {
            int startN = int.Parse(Console.ReadLine());
            int endM = int.Parse(Console.ReadLine());
            int magicNum = int.Parse(Console.ReadLine());

            int count = 0;
            string result = string.Empty;

            for (int N = startN; N <= endM; N++)
            {
                for (int M = startN; M <= endM; M++)
                {
                    count++;
                    if ((N + M) == magicNum)
                    {
                        result = N + " + " + M + " = " + magicNum;
                    }
                }
            }
            if (result != string.Empty) Console.WriteLine($"Number found! {result}");
            else Console.WriteLine($"{count} combinations - neither equals {magicNum}");
        }
    }
}