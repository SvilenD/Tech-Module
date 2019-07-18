using System;
using System.Collections.Generic;
using System.Linq;
namespace P02_HornetComm
{
    class Program
    {
        static void Main(string[] args)
        {
            var messages = new List<string>();
            var broadcasts = new List<string>();
            while (true)
            {
                var input = Console.ReadLine();
                if (input == "Hornet is Green")
                {
                    break;
                }
                var data = input.Split(new string[] { " <-> " }, StringSplitOptions.None); // da si ebe maikata i maloumni input formati v ebaniq judge

                if (data.Length != 2)
                {
                    continue;
                }
                if (CheckIfPrivateMsg(data))
                {
                    var code = data[0].Reverse();
                    string result = $"{string.Join("", code)} -> {data[1]}";
                    messages.Add(result);
                }

                else if (CheckIfBroadcastMsg(data))
                {
                    var msg = data[0];
                    var second = data[1];
                    var frequency = string.Empty;
                    for (int i = 0; i < second.Length; i++)
                    {
                        if (second[i] >= 65 && second[i] <= 90)
                        {
                            string current = second[i].ToString().ToLower();
                            frequency += current;
                        }
                        else if (second[i] >= 97 && second[i] <= 122)
                        {
                            string current = second[i].ToString().ToUpper();
                            frequency += current;
                        }
                        else
                        {
                            frequency += second[i];
                        }
                    }
                    broadcasts.Add($"{frequency} -> {msg}");
                }
            }

            PrintResult(broadcasts, messages);
        }

        static bool CheckIfPrivateMsg(string[] data)
        {
            var first = data[0];
            var second = data[1];
            foreach (var symbol in first)
            {
                if (!char.IsDigit(symbol))
                {
                    return false;
                }
            }

            foreach (var symbol in second)
            {
                if (!char.IsLetterOrDigit(symbol))
                {
                    return false;
                }
            }
            return true;
        }

        static bool CheckIfBroadcastMsg(string[] data)
        {
            var first = data[0];
            var second = data[1];
            foreach (var symbol in first)
            {
                if (char.IsDigit(symbol))
                {
                    return false;
                }
            }

            foreach (var symbol in second)
            {
                if (!char.IsLetterOrDigit(symbol))
                {
                    return false;
                }
            }
            return true;
        }

        private static void PrintResult(List<string> broadcasts, List<string> messages)
        {
            Console.WriteLine("Broadcasts:");
            if (broadcasts.Count > 0)
            {
                foreach (var item in broadcasts)
                {
                    Console.WriteLine(item);
                }
            }
            else
            {
                Console.WriteLine("None");
            }
            Console.WriteLine("Messages:");
            if (messages.Count > 0)
            {
                foreach (var msg in messages)
                {
                    Console.WriteLine(msg);
                }
            }
            else
            {
                Console.WriteLine("None");
            }
        }
    }
}