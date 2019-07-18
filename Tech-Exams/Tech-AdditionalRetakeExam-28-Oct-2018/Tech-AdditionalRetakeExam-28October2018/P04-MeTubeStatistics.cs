using System;
using System.Collections.Generic;
using System.Linq;

namespace P04_MeTubeStatistics
{
    class Program           // да се реши с обекти!!!
    {
        static void Main(string[] args)
        {
            var stats = new Dictionary<string, Dictionary<int, int>>();

            while (true)
            {
                var input = Console.ReadLine();

                if (input == "stats time")
                {
                    break;
                }
                else if (input.Contains("like:"))
                {
                    var splitted = input.Split(':');
                    var name = splitted[1];
                    if (splitted[0] == "like" && stats.ContainsKey(name))
                    {
                        int currentViews = 0;
                        int currentLikes = 0;
                        foreach (var kvp in stats[name])
                        {
                            currentViews = kvp.Key;
                            currentLikes = kvp.Value;
                        }
                        stats[name][currentViews]++;
                    }
                    else if (splitted[0] == "dislike" && stats.ContainsKey(name))
                    {
                        int currentViews = 0;
                        int currentLikes = 0;
                        foreach (var kvp in stats[name])
                        {
                            currentViews = kvp.Key;
                            currentLikes = kvp.Value;
                        }
                        stats[name][currentViews]--;
                    }
                }

                else if (input.Contains('-'))
                {
                    var splitted = input.Split('-');
                    var name = splitted[0];
                    int views = int.Parse(splitted[1]);
                    if (!stats.ContainsKey(name))
                    {
                        stats.Add(name, new Dictionary<int, int>());
                        stats[name].Add(views, 0);
                    }
                    else
                    {
                        int currentViews = 0;
                        int currentLikes = 0;
                        foreach (var kvp in stats[name])
                        {
                            currentViews = kvp.Key;
                            currentLikes = kvp.Value;
                        }

                        stats[name].Remove(currentViews);
                        stats[name].Add(currentViews + views, currentLikes);
                    }
                }
            }

            var sortCriteria = Console.ReadLine();
            if (sortCriteria == "by likes")
            {
                stats = stats.OrderByDescending(x => x.Value.Values.Max()).ToDictionary(x => x.Key, y => y.Value);
            }

            else if (sortCriteria == "by views")
            {
                stats = stats.OrderByDescending(x => x.Value.Keys.Max()).ToDictionary(x => x.Key, y => y.Value);
            }
            foreach (var video in stats)
            {
                foreach (var kvp in video.Value)
                {
                    Console.WriteLine($"{video.Key} - {kvp.Key} views - {kvp.Value} likes");
                }
            }
        }
    }
}