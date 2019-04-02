using System;

namespace ConcatNames
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName = Console.ReadLine();
            string secondName = Console.ReadLine();
            string delimiter = Console.ReadLine();

            string output = firstName + delimiter + secondName;
            Console.WriteLine(output);
        }
    }
}
