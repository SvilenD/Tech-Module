using System;

namespace P02_FirstBit
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            int numberRightShifted = number >> 1; // first bit is getting at 0psn

            Console.WriteLine(numberRightShifted & 1); //bit at 0 psn & 1 (0&1 = 0; 1&1 = 1)
        }
    }
}
