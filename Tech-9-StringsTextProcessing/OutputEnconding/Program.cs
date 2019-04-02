using System;
using System.Text;

namespace OutputEnconding
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.WriteLine('♔');
        }
    }
}
