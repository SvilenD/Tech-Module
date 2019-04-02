using System;
using System.Collections.Generic;
using System.Linq;

namespace P04_ForceBook
{
    class Program
    {
        static Dictionary<string, List<string>> forceData = new Dictionary<string, List<string>>();
        static void Main(string[] args)
        {
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "Lumpawaroo")
                {
                    break;
                }
                else if (input.Contains("|"))
                {
                    AddUSer(input);
                }
                else if (input.Contains("->"))
                {
                    ChangeUserSide(input);
                }
            }
            PrintResult();
        }

        static void AddUSer(string input)
        {
            var splitted = input.Split(new char[] { '|' }, StringSplitOptions.RemoveEmptyEntries);
            var side = splitted[0].Trim();
            var user = splitted[1].Trim();

            if (!forceData.ContainsKey(side))
            {
                forceData.Add(side, new List<string>());
            }
            if (!forceData.Any(x => x.Value.Contains(user)))
            {
                forceData[side].Add(user);
            }
        }

        static void ChangeUserSide(string input)
        {
            var splitted = input.Split(new char[] { '-', '>' }, StringSplitOptions.RemoveEmptyEntries);
            var user = splitted[0].Trim();
            string side = splitted[1].Trim();

            if (!forceData.ContainsKey(side))
            {
                forceData.Add(side, new List<string>());
            }
            if (!forceData.Any(x => x.Value.Contains(user)))
            {
                forceData[side].Add(user);
            }
            else
            {
                foreach (var kvp in forceData)
                {
                    if (kvp.Value.Contains(user))
                    {
                        kvp.Value.Remove(user);
                        break;
                    }
                }
                forceData[side].Add(user);
            }
            Console.WriteLine($"{user} joins the {side} side!");
        }

        static void PrintResult()
        {
            foreach (var side in forceData.Where(x => x.Value.Count > 0).OrderByDescending(x => x.Value.Count).ThenBy(x => x.Key))
            {
                Console.WriteLine($"Side: {side.Key}, Members: {side.Value.Count}");

                var members = side.Value.OrderBy(x => x).ToList();
                for (int i = 0; i < members.Count(); i++)
                {
                    Console.WriteLine($"! {members[i]}");
                }
            }
        }
    }
}