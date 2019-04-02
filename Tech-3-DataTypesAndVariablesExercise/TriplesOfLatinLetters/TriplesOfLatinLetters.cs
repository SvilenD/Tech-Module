using System;

namespace TriplesOfLatinLetters
{
    class TriplesOfLatinLetters
    {
        static void Main(string[] args)
        {
            int endLetter = int.Parse(Console.ReadLine());
            for (char letter1 = 'a'; letter1 <= Convert.ToChar((endLetter+96)); letter1++)
            {
                for (char letter2 = 'a'; letter2 <= Convert.ToChar((endLetter+96)); letter2++)
                {
                    for (char letter3 = 'a'; letter3 <= Convert.ToChar((endLetter+96)); letter3++)
                    {
                        Console.WriteLine($"{letter1}{letter2}{letter3}");
                    }
                }
            }
        }
    }
}