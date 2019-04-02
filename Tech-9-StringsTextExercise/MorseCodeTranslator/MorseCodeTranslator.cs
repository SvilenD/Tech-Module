using System;

namespace MorseCodeTranslator
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();

            string decoded = string.Empty;
            for (int i = 0; i < input.Length; i++)
            {
                string word = input[i];

                switch (word)
                {
                    case ".-": decoded += 'A'; break;
                    case "-...": decoded += 'B'; break;
                    case "-.-.": decoded += 'C'; break;
                    case "-..": decoded += 'D'; break;
                    case ".": decoded += 'E'; break;
                    case "..-.": decoded += 'F'; break;
                    case "--.": decoded += 'G'; break;
                    case "....": decoded += 'H'; break;
                    case "..": decoded += 'I'; break;
                    case ".---": decoded += 'J'; break;
                    case "-.-": decoded += 'K'; break;
                    case ".-..": decoded += 'L'; break;
                    case "--": decoded += 'M'; break;
                    case "-.": decoded += 'N'; break;
                    case "---": decoded += 'O'; break;
                    case ".--.": decoded += 'P'; break;
                    case "--.-": decoded += 'Q'; break;
                    case ".-.": decoded += 'R'; break;
                    case "...": decoded += 'S'; break;
                    case "-": decoded += 'T'; break;
                    case "..-": decoded += 'U'; break;
                    case "...-": decoded += 'V'; break;
                    case ".--": decoded += 'W'; break;
                    case "-..-": decoded += 'X'; break;
                    case "-.--": decoded += 'Y'; break;
                    case "--..": decoded += 'Z'; break;
                    case "|": decoded += ' '; break;
                }
            }
            Console.WriteLine(decoded);
        }
    }
}

