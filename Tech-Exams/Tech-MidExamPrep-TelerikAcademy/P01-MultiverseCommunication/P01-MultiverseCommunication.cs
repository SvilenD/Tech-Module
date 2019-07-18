using System;
using System.Collections.Generic;
using System.Linq;

namespace P01_MultiverseCommunication
{
    class Program
    {
        static void Main(string[] args)
        {
            var keyCode = new List<string>() { "CHU", "TEL", "OFT", "IVA", "EMY", "VNB", "POQ", "ERI", "CAD", "K-A", "IIA", "YLO", "PLA" };

            var input = Console.ReadLine();

            string encrypted = string.Empty;
            for (int i = 0; i < input.Length - 2; i += 3)
            {
                encrypted += input.Substring(i, 3) + " ";
            }
            var decoded = encrypted.Split(" ", StringSplitOptions.RemoveEmptyEntries);

            var numsList = new List<int>();
            for (int i = 0; i < decoded.Length; i++)
            {
                numsList.Add(keyCode.IndexOf(decoded[i]));
            }

            int power = numsList.Count -1;

            double sum = 0;
            for (int i = 0; i < numsList.Count; i++)
            {
                double num = numsList[i] * Math.Pow(13, power);
                sum += num;
                power--;
            }
       
            Console.WriteLine(sum);
        }
    }
}