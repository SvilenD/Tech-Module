using System;

namespace ExtractFile
{
    class Program
    {
        static void Main(string[] args)
        {
            string fileAddress = Console.ReadLine();

            int fileIndex = fileAddress.LastIndexOf('\\');
            string file = fileAddress.Substring(fileIndex + 1);

            int extensionIndex = file.IndexOf('.');
            string extension = file.Substring(extensionIndex + 1);

            file = file.Remove(extensionIndex);

            Console.WriteLine("File name: " + file);
            Console.WriteLine("File extension: " + extension);
        }
    }
}