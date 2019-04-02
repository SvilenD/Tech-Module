using System;

namespace ExchangeValues
{
    class ExchangeValues
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            int temp = a;
            a = b;
            b = temp;

            Console.WriteLine(a + Environment.NewLine + b);
        }
    }
}
