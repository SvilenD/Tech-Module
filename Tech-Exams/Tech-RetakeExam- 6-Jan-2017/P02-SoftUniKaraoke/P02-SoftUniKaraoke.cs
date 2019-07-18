using System;
using System.Collections.Generic;
using System.Linq;

namespace P02_SoftUniKaraoke
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] split = { ',' };
            string[] participants = Console.ReadLine().Split(split, StringSplitOptions.RemoveEmptyEntries).Select(x => x.Trim()).ToArray();
            string[] songs = Console.ReadLine().Split(split, StringSplitOptions.RemoveEmptyEntries).Select(x => x.Trim()).ToArray();

            var awards = new Dictionary<string, List<string>>();

            while (true)
            {
                string[] input = Console.ReadLine().Split(split, StringSplitOptions.RemoveEmptyEntries).Select(x => x.Trim()).ToArray();
                if (input[0] == "dawn")
                {
                    break;
                }

                string singer = input[0];
                string presentSong = input[1];
                string presentAward = input[2];

                if (participants.Contains(singer) && songs.Contains(presentSong))
                {
                    if (!awards.ContainsKey(singer))
                    {
                        awards.Add(singer, new List<string>());
                    }
                    if (!awards[singer].Contains(presentAward))
                    {
                        awards[singer].Add(presentAward);
                        awards[singer].Sort();
                    }
                }
            }

            if (awards.Count < 1)
            {
                Console.WriteLine("No awards");
            }

            else
            {
                foreach (var singer in awards.OrderByDescending(x => x.Value.Count))
                {
                    int awardsCount = singer.Value.Count();
                    Console.WriteLine($"{singer.Key}: {awardsCount} awards");
                    for (int i = 0; i < awardsCount; i++)
                    {
                        Console.WriteLine($"--{singer.Value[i]}");
                    }
                }
            }
        }
    }
}