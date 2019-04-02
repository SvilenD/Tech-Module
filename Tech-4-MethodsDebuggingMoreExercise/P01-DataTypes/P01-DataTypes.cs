using System;

namespace P01_DataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            string input = Console.ReadLine();

            PrintResult(type, input);
        }

        static void PrintResult(string type, string input)
        {
            switch (type)
            {
                case "int": int result = 2 * int.Parse(input);
                    Console.WriteLine(result);
                    break;
                case "real": double resultF2 = 1.5 * double.Parse(input);
                    Console.WriteLine($"{resultF2:f2}");
                    break;
                case "string": string output = "$"+input+"$";
                    Console.WriteLine(output);
                    break;
                default:
                    break;
            }
        }
    }
}
