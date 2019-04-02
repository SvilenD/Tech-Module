using System;
using System.Text;

namespace ASCII
{
    class ASCII
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            char test = '¥';
            Console.WriteLine(test);
            
        }
    }
}