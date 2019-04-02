using System;

namespace SubstringReplaceText
{
    class Program
    {
        static void Main(string[] args)
        {
            var stringToRemove = Console.ReadLine();
            var text = Console.ReadLine();

            while (text.Contains(stringToRemove))
            {
                text = text.Replace(stringToRemove, string.Empty);
            }
            Console.WriteLine(text);
        }
    }
}
