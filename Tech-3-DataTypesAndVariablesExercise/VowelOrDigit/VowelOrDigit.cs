using System;

namespace VowelOrDigit
{
    class VowelOrDigit
    {
        static void Main(string[] args)
        {
            //string input = Console.ReadLine();

            //try
            //{
            //    int result = int.Parse(input);
            //    Console.WriteLine("digit");
            //}
            //catch (Exception)
            //{
            //    switch (input)
            //    {
            //        case "a":
            //        case "e":
            //        case "i":
            //        case "o":
            //        case "u": Console.WriteLine("vowel"); break;

            //        default:
            //            Console.WriteLine("other");
            //            break;
            //    }
            //}
            char input = char.Parse(Console.ReadLine());
            if (input == 'a' || input == 'e' || input == 'i' || input == 'o' || input == 'u')
            {
                Console.WriteLine("vowel");
            }
            else if (char.IsDigit(input))
            {
                Console.WriteLine("digit");
            }
            else Console.WriteLine("other");
        }
    }
}