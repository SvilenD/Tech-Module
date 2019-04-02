using System;
using System.Text;

namespace P07_RepeatString
{
    class Program
    {
        static StringBuilder stringBuilder = new StringBuilder();
        
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int count = int.Parse(Console.ReadLine());

            RepeatString(input, count);
            Console.WriteLine(stringBuilder.ToString());
        }

        static void RepeatString (string input, int count)
        {
            for (int i = 0; i < count; i++)
            {
                stringBuilder.Append(input);
            }
        }
    }
}
