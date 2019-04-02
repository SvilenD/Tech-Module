using System;

namespace MultiplicationTable
{
    class MultiplicationTable
    {
        static void Main(string[] args)
        {
            byte num = byte.Parse(Console.ReadLine());
            for (int count = 1; count <= 10; count++)
            {
                int result = num * count;
                Console.WriteLine($"{num} X {count} = {result}");
            }
        }
    }
}