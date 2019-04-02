using System;

namespace DrawFilledSquare
{
    class DrawFilledSquare
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());

            PrintSquare(input);
        }

        static void PrintSquare(int num)
        {
            PrintTopBottom(num);
            PrintMiddleRow(num);
            PrintTopBottom(num);
        }

        static void PrintMiddleRow(int num)
        {
            for (int row = 1; row <= num - 2; row++)
            {
                Console.Write('-');
                for (int column = 0; column < num - 1; column++)
                {
                    Console.Write(@"\/");
                }
                Console.WriteLine("-");
            }
        }

        static void PrintTopBottom(int num)
        {
            Console.WriteLine(new string('-', num * 2));
        }
    }
}