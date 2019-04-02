using System;

namespace ExtractPersonInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            for (int i = 0; i < num; i++)
            {
                string input = Console.ReadLine();

                int nameStart = input.IndexOf('@') + 1;
                int nameEnd = input.IndexOf('|');
                string name = input.Substring(nameStart, nameEnd - nameStart);

                int ageStart = input.IndexOf('#') + 1;
                int ageEnd = input.IndexOf('*');
                string age = input.Substring(ageStart, ageEnd - ageStart);

                Console.WriteLine($"{name} is {age} years old.");
            }
        }
    }
}
