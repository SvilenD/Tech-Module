using System;

namespace StringsAndObjects
{
    class StringsAndObjects
    {
        static void Main(string[] args)
        {
            string one = "Hello";
            string two = "World";

            object concat = one + " " + two;
            string output = Convert.ToString(concat);

            Console.WriteLine(output);
        }
    }
}
