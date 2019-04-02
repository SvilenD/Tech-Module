using System;

namespace BlankReceiptCustom
{
    class BlankReceiptCustom
    {
        static void Main(string[] args)
        {
            char input = char.Parse(Console.ReadLine());
            int count = int.Parse(Console.ReadLine());

            PrintReceipt(input, count);
        }

        static void PrintReceipt(char symbol, int number)
        {
            PrintHeader(symbol, number);
            PrintBody(symbol, number);
        }

        static void PrintHeader(char symbol, int num)
        {
            Console.WriteLine("CASH RECEPT: ");
            Console.WriteLine(new string(symbol, (num + 6)));
        }
        static void PrintBody(char symbol, int numb)
        {
            Console.WriteLine($"Charged to " + new string(symbol, ((numb /3) + 1)));
            Console.WriteLine($"Received by "+ new string(symbol, numb /3));
        }
    }
}