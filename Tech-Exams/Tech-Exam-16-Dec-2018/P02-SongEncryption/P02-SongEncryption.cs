using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace P02_SongEncryption
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                var input = Console.ReadLine();
                if (input == "end")
                {
                    break;
                }

                string pattern = @"^([A-Z]{1}[a-z\' ]+):([A-Z ]+)\b";
                Match match = Regex.Match(input, pattern);
                if (match.Success)
                {
                    var encrypted = match.Value;

                    int key = encrypted.IndexOf(':');

                    var result = new StringBuilder();
                    for (int i = 0; i < encrypted.Length; i++)
                    {
                        var symbol = encrypted[i];
                        if (symbol == ':')
                        {
                            result.Append('@');
                        }
                        else if (symbol != ' ' && symbol != '\'')
                        {
                            if (symbol <= 'Z')
                            {
                                symbol += (char)key;
                                if (symbol > 'Z')
                                {
                                    symbol -= (char)26;
                                }
                            }
                            else if (symbol >= 'a')
                            {
                                symbol += (char)key;
                                if (symbol > 'z')
                                {
                                    symbol -= (char)26;
                                }
                            }
                            result.Append(symbol);
                        }
                        else
                        {
                            result.Append(symbol);
                        }
                    }
                    Console.WriteLine($"Successful encryption: {result}");
                }
                else
                {
                    Console.WriteLine("Invalid input!");
                }
            }
        }
    }
}