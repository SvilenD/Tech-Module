using System;

namespace NumsTriangle
{
    class NumsTriangle
    {
        static void Main(string[] args)
        {
            byte num = byte.Parse(Console.ReadLine());
            for (int i = 1; i <= num; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write(i+" ");
                }
                Console.WriteLine();
            }
        }
    }
}
