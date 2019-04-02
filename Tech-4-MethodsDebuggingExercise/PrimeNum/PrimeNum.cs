using System;

namespace PrimeNum
{
    class PrimeNum
    {
        static void Main(string[] args)
        {   
            ulong num = ulong.Parse(Console.ReadLine());

            Console.WriteLine(PrimeChecker(num));
        }

        static bool PrimeChecker(ulong num)
        {
            bool isPrime = true;
            if (num == 0 || num == 1)
            {
                isPrime = false;
            }
            else
            {
                for (uint index = 2; index <= Math.Sqrt(num); index++)
                {
                    if (num % index == 0)
                    {
                        isPrime = false;
                    }
                }
            }

            return isPrime;
        }
    }
}
