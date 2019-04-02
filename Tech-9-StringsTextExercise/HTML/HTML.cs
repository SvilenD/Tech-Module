using System;

namespace HTML
{
    class Program
    {
        static void Main(string[] args)
        {
            string header = Console.ReadLine();
            Console.WriteLine($"<h1>{Environment.NewLine}    {header}{Environment.NewLine}</h1>");

            string article = Console.ReadLine();
            Console.WriteLine($"<article>{Environment.NewLine}    {article}{Environment.NewLine}</article>");
            while (true)
            {
                string comment = Console.ReadLine();
                if (comment == "end of comments")
                {
                    break;
                }

                Console.WriteLine($"<div>{Environment.NewLine}    {comment}{Environment.NewLine}</div>");
            }
        }
    }
}
