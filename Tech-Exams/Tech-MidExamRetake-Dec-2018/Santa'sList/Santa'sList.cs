using System;
using System.Collections.Generic;
using System.Linq;

namespace Santa_sList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> kids = Console.ReadLine().Split('&').ToList();

            while (true)
            {
                string[] commandLine = Console.ReadLine().Split();

                if (commandLine[0] == "Finished!")
                {
                    break;
                }
                string command = commandLine[0];
                string name = commandLine[1];

                switch (command.ToLower())
                {
                    case "bad":
                        if (!kids.Contains(name))
                        {
                            kids.Insert(0, name);
                        }
                        break;
                    case "good":
                        if (kids.Contains(name))
                        {
                            kids.Remove(name);
                        }
                        break;
                    case "rename":
                        if (kids.Contains(name))
                        {
                            int index = kids.IndexOf(name);
                            string newName = commandLine[2];
                            kids[index] = newName;
                        }
                        break;
                    case "rearrange":
                        if (kids.Contains(name))
                        {
                            kids.Remove(name);
                            kids.Add(name);
                        }
                        break;
                    default:
                        break;
                }
            }
            Console.WriteLine(string.Join(", ", kids));
        }
    }
}