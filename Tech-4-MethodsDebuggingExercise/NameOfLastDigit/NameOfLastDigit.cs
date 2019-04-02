using System;

namespace NameOfLastDigit
{
    class NameOfLastDigit
    {
        static void Main(string[] args)
        {
            long num = long.Parse(Console.ReadLine());

            string output = GetLastDigitName(num);
            Console.WriteLine(output);
        }

        private static string GetLastDigitName(long num)
        {
            string name = string.Empty;
            long digit = Math.Abs (num % 10);
            switch (digit)
            {
                case 0: name = "zero"; break;
                case 1: name = "one"; break;
                case 2: name = "two"; break;
                case 3: name = "three"; break;
                case 4: name = "four"; break;
                case 5: name = "five"; break;
                case 6: name = "six"; break;
                case 7: name = "seven"; break;
                case 8: name = "eight"; break;
                case 9: name = "nine"; break;
            }

            return name;
        }
    }
}
