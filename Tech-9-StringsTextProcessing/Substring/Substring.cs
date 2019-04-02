using System;

namespace Substring
{
    class Program
    {
        static void Main(string[] args)
        {
            string key = Console.ReadLine();
            string text = Console.ReadLine();

            while (text.Contains(key))
            {
                int index = text.IndexOf(key);

                //if (index == -1)
                //{
                //    break;
                //}
                text = text.Remove(index, key.Length);
            }
            Console.WriteLine(text);
        }
    }
}