using System;

namespace P03_p_thBit
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int position = int.Parse(Console.ReadLine());

            int shifted = number >> position;

            int lastBit = shifted & 1;
            Console.WriteLine(lastBit);
        }
    }
}
