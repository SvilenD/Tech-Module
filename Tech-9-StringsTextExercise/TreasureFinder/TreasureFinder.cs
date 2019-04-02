using System;
using System.Linq;

namespace TreasureFinder
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] key = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "find")
                {
                    break;
                }
                string decrypted = string.Empty;
                int keyIndex = 0;

                for (int i = 0; i < input.Length; i++)
                {
                    int symbolNum = input[i] - key[keyIndex];
                    keyIndex++;

                    decrypted += (char)(symbolNum);
                    if (keyIndex == key.Length)
                    {
                        keyIndex = 0;
                    }
                }
                int typeIndexStart = decrypted.IndexOf('&') + 1;
                int typeIndexLength = decrypted.LastIndexOf('&') - typeIndexStart;
                string type = decrypted.Substring(typeIndexStart, typeIndexLength);

                int coordinatesStart = decrypted.LastIndexOf('<') + 1;
                int coordinatesLength = decrypted.LastIndexOf('>') - coordinatesStart;
                string coordinates = decrypted.Substring(coordinatesStart, coordinatesLength);

                Console.WriteLine($"Found {type} at {coordinates}");
            }
        }
    }
}