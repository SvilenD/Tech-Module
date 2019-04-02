using System;
using System.Text;

namespace Reverse_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder result = new StringBuilder();

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "end")
                {
                    break;
                }
                result.Append(input + " = ");
                for (int i = 0; i < input.Length; i++)
                {
                    result.Append(input[input.Length - 1 - i]);
                }
                result.AppendLine();
            }
            Console.WriteLine(result);
        }
    }
}