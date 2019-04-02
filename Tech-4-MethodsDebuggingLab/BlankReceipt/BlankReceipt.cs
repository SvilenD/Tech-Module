using System;

namespace BlankReceipt
{
    class BlankReceipt // на C# .Net Core не минава теста в judge
    {
        static void Main(string[] args)
        {
            PrintReceipt();
        }
        static void PrintReceipt()
        {
            PrintHeader();
            PrintBody();
            PrintFooter();
        }

        static void PrintHeader()
        {
            Console.WriteLine("CASH RECEIPT");
            Console.WriteLine("------------------------------"); 
        }

        static void PrintBody()
        {
            Console.WriteLine("Charged to____________________");
            Console.WriteLine("Received by___________________");
        }

        static void PrintFooter()
        {
            Console.WriteLine("------------------------------");
            Console.WriteLine('\u00A9' + " SoftUni"); //  '\u00A9' вместо ©
        }
    }
}