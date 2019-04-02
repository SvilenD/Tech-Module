using System;
using System.Collections.Generic;

namespace PrimesInRange
{
    class PrimesInRange
    {
        static void Main(string[] args)
        {
            int startNum = int.Parse(Console.ReadLine());
            int endNum = int.Parse(Console.ReadLine());

            List<int> primes = GetPrimesInRange(startNum, endNum);
            for (int i = 0; i < primes.Count - 1; i++)          //foreach не става заради запетайте след числото
            {
                int result = primes[i];
                Console.Write($"{result}, ");
            }
            Console.WriteLine(primes[primes.Count-1]);
        }

        static List<int> GetPrimesInRange(int start, int end)
        {
            List<int> primes = new List<int>();
            for (int num = start; num <= end; num++)
            {
                bool prime = true;
                for (int divisor = 2; divisor <= Math.Sqrt(num); divisor++)
                {
                    if (num % divisor == 0)
                    {
                        prime = false;
                    }
                }
                if (prime && num > 1)
                {
                    primes.Add(num);
                }

            }
            return primes;
        }
    }
}
