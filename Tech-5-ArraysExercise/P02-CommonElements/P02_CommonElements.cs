using System;
using System.Linq;

namespace P02_CommonElements
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] first = Console.ReadLine().Split();
            string[] second = Console.ReadLine().Split();

            for (int i = 0; i < second.Length; i++)
            {
                string element = second[i];
                if (first.Contains(element))
                {
                    Console.Write(element+ " ");
                }
            }
        }
    }
}
