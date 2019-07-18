using System; 
using System.Collections.Generic;
using System.Text;

namespace P02_ActivationKeys
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split('&');
            var result = new List<StringBuilder>();
            for (int i = 0; i < input.Length; i++)
            {
                var key = input[i];
                var output = new StringBuilder();
                int divider = 0;
                if (key.Length == 16)
                {
                    divider = 4;
                    output = AddSymbols(key, divider);
                }
                else if (key.Length == 25)
                {
                    divider = 5;
                    output = AddSymbols(key, divider);
                }
                if (output.Length == 19 || output.Length == 29)
                {
                    result.Add(output);
                }
            }
            Console.WriteLine(string.Join(", ", result));
        }

        static StringBuilder AddSymbols(string key, int divider)
        {
            var output = new StringBuilder();
            int count = 0;
            for (int index = 0; index < key.Length; index++)
            {
                var symbol = key[index];
                count++;
                if (!char.IsLetterOrDigit(symbol))
                {
                    return new StringBuilder();
                }
                else if (char.IsDigit(symbol))
                {
                    int num = 9 - int.Parse(symbol.ToString());
                    output.Append(num);
                }
                else
                {
                    output.Append(symbol.ToString().ToUpper());
                }
                if (count % divider == 0 && count != key.Length)
                {
                    output.Append("-");
                }
            }
            return output;
        }
    }
}