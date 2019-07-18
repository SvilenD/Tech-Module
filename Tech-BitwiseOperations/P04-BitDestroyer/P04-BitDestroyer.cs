using System;

namespace P04_BitDestroyer // set bit at psn = 0
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int psn = int.Parse(Console.ReadLine());

            int numWith1AtPsn = 1 << psn; // shifting 1 << times left

            int newNum = number ^ numWith1AtPsn;
            Console.WriteLine(newNum);
        }
    }
}
