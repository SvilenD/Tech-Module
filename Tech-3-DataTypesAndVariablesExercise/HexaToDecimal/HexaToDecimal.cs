using System;

namespace HexaToDecimal
{
    class HexaToDecimal
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            int result = Convert.ToInt32(input, 16);
            Console.WriteLine(result);
        }
    }
}
