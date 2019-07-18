using System;
using System.Collections.Generic;

namespace QuestsJournal
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> journal = new List<string>();

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "Retire!")
                {
                    break;
                }

                string command = string.Empty;

                if (input.Contains("Start - "))
                {
                    int startIndex = input.IndexOf('-') + 2;
                    command = input.Substring(startIndex);
                    if (!journal.Contains(command))
                    {
                        journal.Add(command);
                    }
                }

                else if (input.Contains("Complete - "))
                {
                    int startIndex = input.IndexOf('-') + 2;
                    command = input.Substring(startIndex);
                    if (journal.Contains(command))
                    {
                        journal.Remove(command);
                    }
                }

                else if (input.Contains("Side Quest - "))
                {
                    int startIndex = input.IndexOf('-') + 2;
                    int length = input.IndexOf(':') - startIndex;
                    command = input.Substring(startIndex, length);
                    if (journal.Contains(command))
                    {
                        int newIndex = input.IndexOf(':') + 1;
                        string newEntry = input.Substring(newIndex);

                        if (!journal.Contains(newEntry))
                        {
                            int commandIndex = journal.IndexOf(command);
                            journal.Insert(commandIndex + 1, newEntry);
                        }
                    }
                }

                else if (input.Contains("Renew - "))
                {
                    int startIndex = input.IndexOf('-') + 2;
                    command = input.Substring(startIndex);
                    if (journal.Contains(command))
                    {
                        journal.Remove(command);
                        journal.Add(command);
                    }
                }

                else
                {
                    string[] itemsToAdd = input.Split(", ");

                    for (int i = 0; i < itemsToAdd.Length; i++)
                    {
                        journal.Add(itemsToAdd[i]);
                    }
                }
            }

            Console.WriteLine(string.Join(", ", journal));
        }
    }
}
