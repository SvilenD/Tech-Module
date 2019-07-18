using System;
using System.Collections.Generic;

namespace P02_ChatLogger
{
    class Program
    {

        static void Main(string[] args)
        {
            List<string> chats = new List<string>();
            while (true)
            {
                var input = Console.ReadLine()
                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                if (input[0] == "end")
                {
                    break;
                }
                else if (input[0] == "Chat")
                {
                    chats.Add(input[1]);
                }
                else if (input[0] == "Delete")
                {
                    chats.Remove(input[1]);
                }
                else if (input[0] == "Edit")
                {
                    if (chats.Contains(input[1]))
                    {
                        int index = chats.IndexOf(input[1]);
                        chats[index] = input[2];
                    }
                }
                else if (input[0] == "Pin")
                {
                    if (chats.Contains(input[1]))
                    {
                        chats.Remove(input[1]);
                        chats.Add(input[1]);
                    }
                }
                else if (input[0] == "Spam")
                {
                    for (int i = 1; i < input.Length; i++)
                    {
                        chats.Add(input[i]);
                    }
                }
            }
            for (int i = 0; i < chats.Count; i++)
            {
                Console.WriteLine(chats[i]);
            }
        }
    }
}
