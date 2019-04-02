using System;

namespace FastPrimeCheckerRefractor
{
    class FastPrimeChecker
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            for (int index = 2; index <= num; index++)
            {
                bool prime = true;
                for (int divisor = 2; divisor <= Math.Sqrt(index); divisor++)
                {
                    if (index % divisor == 0)
                    {
                        prime = false;
                        break;
                    }
                }
                Console.WriteLine($"{index} -> {prime}");
            }
        }
    }
}