using System;

namespace HelloName
{
    class HelloName
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();

            PrintHelloName(name);
        }

        static void PrintHelloName(string name)
        {
            Console.WriteLine($"Hello, {name}!");
        }
    }
}