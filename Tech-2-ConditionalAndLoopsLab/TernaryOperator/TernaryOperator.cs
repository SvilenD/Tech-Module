using System;

namespace TernaryOperator
{
    class TernaryOperator
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            string output = num % 2 == 0 ? "Even" : "Odd";
            Console.WriteLine(output);
        }
    }
}
