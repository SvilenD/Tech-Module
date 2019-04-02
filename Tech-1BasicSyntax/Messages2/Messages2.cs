using System;

namespace Messages
{
    class Program
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());

            string[] letters = new string[] { " ", "", "abc", "def", "ghi", "jkl", "mno", "pqrs", "tuv", "wxyz" };

            string message = string.Empty;
            for (int i = 0; i < length; i++)
            {
                string num = Console.ReadLine();
                if (num == "1")
                {
                    continue;
                }
                int lastDigit = int.Parse(num) % 10;

                message += letters[lastDigit][num.Length - 1];
            }
            Console.WriteLine(message);
        }
    }
}