using System;

namespace GreaterValue
{
    class GreaterValue
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();

            if (input == "int")
            {
                int first = int.Parse(Console.ReadLine());
                int second = int.Parse(Console.ReadLine());

                int max = GetMax(first, second);
                Console.WriteLine(max);
            }
            else if (input == "char")
            {
                char first = char.Parse(Console.ReadLine());
                char second = char.Parse(Console.ReadLine());

                char max = GetMax(first, second);
                Console.WriteLine(max);
            }
            else
            {
                string first = Console.ReadLine();
                string second = Console.ReadLine();

                string max = GetMax(first, second);
                Console.WriteLine(max);
            }
            
        }

        static int GetMax(int first, int second)
        {
            int maxValue = Math.Max(first, second);
            return maxValue;
        }

        static char GetMax(char first, char second)
        {

            char greater = default(char);
            if (first > second)
            {
                greater = first;
            }
            else
            {
                greater = second;
            }
            return greater;
        }

        static string GetMax(string first, string second)
        {
            string output = string.Empty;
            if (first.CompareTo(second) >= 0)
            {
                output = first;
            }
            else output = second;
            return output;
        }
    }
}
