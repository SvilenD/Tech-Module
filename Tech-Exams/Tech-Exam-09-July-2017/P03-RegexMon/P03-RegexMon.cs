using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace P03_RegexMon
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            string bojoPattern = $"[A-Za-z]+-[A-Za-z]+";
            string didiPattern = $"[^A-Za-z-]+";

            int index = 0;
            while (true)
            {
                string subInput = input.Substring(index);
                if (subInput.Length == 0)
                {
                    break;
                }
                Match matchDidi = Regex.Match(subInput, didiPattern);
                if (matchDidi.Success)
                {
                    Console.WriteLine(matchDidi.Value);
                    index += matchDidi.Index;
                    index += matchDidi.Length;
                }
                else
                {
                    break;
                }
                subInput = input.Substring(index);
                Match matchBojo = Regex.Match(subInput, bojoPattern);
                if (matchBojo.Success)
                {
                    Console.WriteLine(matchBojo.Value);
                    index += matchBojo.Index;
                    index += matchBojo.Length;
                }
                else
                {
                    break;
                }
            }
        }
    }
}