using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace P04_CubicMessages // da si ebe maikata i regex i validacii, dobre che e dadeno reshenieto
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                StringBuilder encrypted = new StringBuilder();

                string input = Console.ReadLine();

                if (input == "Over!")
                {
                    break;
                }
                int length = int.Parse(Console.ReadLine());

                string message = string.Empty;
                Regex pattern = new Regex(@"(^[0-9]+)([a-zA-Z]+)([^a-zA-Z]*)$");
                Match match = pattern.Match(input);

                if (match.Groups[2].Length == length)
                {
                    List<int> indexes = GetIndexes(match);

                    message = match.Groups[2].ToString();

                    for (int i = 0; i < indexes.Count; i++)
                    {
                        if (indexes[i] >= 0 && indexes[i] < message.Length)
                        {
                            int num = indexes[i];
                            encrypted.Append(message[num]);
                        }
                        else
                        {
                            encrypted.Append(' ');
                        }
                    }
                    Console.WriteLine($"{message} == {encrypted}");
                }
            }
        }

        private static List<int> GetIndexes(Match match)
        {
            List<int> indexes = new List<int>();

            string left = match.Groups[1].ToString();
            for (int i = 0; i < left.Length; i++)
            {
                if (Char.IsDigit(left[i]))
                {
                    indexes.Add(int.Parse(left[i].ToString()));
                }
            }

            string right = match.Groups[3].ToString();
            for (int i = 0; i < right.Length; i++)
            {
                if (Char.IsDigit(right[i]))
                {
                    indexes.Add(int.Parse(right[i].ToString()));
                }
            }

            return indexes;
        }
    }
}