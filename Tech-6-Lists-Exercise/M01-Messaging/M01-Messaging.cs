using System;
using System.Linq;
using System.Text;

namespace M01_Messaging
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            string message = Console.ReadLine();

            StringBuilder result = new StringBuilder();
            for (int i = 0; i < numbers.Count; i++)
            {
                int sum = 0;
                while (numbers[i] > 0)
                {
                    sum += numbers[i] % 10;
                    numbers[i] /= 10;
                }
                if (numbers[i] == 0)
                {
                    sum = sum % message.Length;
                    result.Append(message[sum]);
                }
                message = message.Remove(sum, 1);
            }
            Console.WriteLine(result);
        }
    }
}
