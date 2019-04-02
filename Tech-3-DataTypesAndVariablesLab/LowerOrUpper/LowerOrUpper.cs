using System;

namespace LowerOrUpper
{
    class Program
    {
        static void Main(string[] args)
        {
            var input =Console.ReadLine();

            if (input == input.ToUpper())
            {
                Console.WriteLine("upper-case");
            }
            else
            {
                Console.WriteLine("lower-case");
            }
        }
    }
}
