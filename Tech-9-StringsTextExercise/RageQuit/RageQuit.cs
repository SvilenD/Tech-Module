using System;
using System.Collections.Generic;
using System.Text;


namespace RageQuit
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string replacement = string.Empty;

            StringBuilder stringBuilder = new StringBuilder();
            List<char> charList = new List<char>();

            for (int i = 0; i < input.Length; i++)
            {
                string digitString = string.Empty;

                if (char.IsDigit(input[i]))
                {
                    for (int j = i; j < input.Length; j++)
                    {
                        if (char.IsDigit(input[j]))
                        {
                            digitString += input[i];
                            i++;
                        }
                        else
                        {
                            i--;
                            break;
                        }
                    }

                    int digit = int.Parse(digitString);

                    replacement = replacement.ToUpper();

                    for (int j = 0; j < digit; j++)
                    {
                        stringBuilder.Append(replacement);
                    }

                    if (digit > 0)
                    {
                        for (int index = 0; index < replacement.Length; index++)
                        {
                            if (!charList.Contains(replacement[index]))
                            {
                                charList.Add(replacement[index]);
                            }
                        }
                    }

                    replacement = "";
                }
                else
                {
                    replacement += input[i];
                }
            }

            Console.WriteLine("Unique symbols used: {0}", charList.Count);
            Console.WriteLine(stringBuilder);
        }
    }
}