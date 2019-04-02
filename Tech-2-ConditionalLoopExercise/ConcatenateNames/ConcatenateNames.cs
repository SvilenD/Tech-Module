using System;

namespace ConcatenateNames
{
    class ConcatenateNames
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            string family = Console.ReadLine();
            string delimiter = Console.ReadLine();
            Console.WriteLine(name+delimiter+family);
        }
    }
}