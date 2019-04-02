using System;

namespace TextFilter
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] bannedWords = Console.ReadLine().Split(", ");
            string text = Console.ReadLine();

            string[] replacement = new string[bannedWords.Length];
            for (int i = 0; i < bannedWords.Length; i++)
            {
                replacement[i] = bannedWords[i].Replace(bannedWords[i], new string('*', bannedWords[i].Length));
                text = text.Replace(bannedWords[i], replacement[i]);
            }
            Console.WriteLine(text);
        }
    }
}
