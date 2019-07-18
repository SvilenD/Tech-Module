using System;
using System.Collections.Generic;
using System.Linq;

namespace P04_MeTubeStats_Objects
{
    class Video
    {
        public string Name { get; set; }

        public int Views { get; set; }

        public int Likes { get; set; }
    }

    class Program
    {
        static List<Video> listOfVideos = new List<Video>();

        static void Main(string[] args)
        {

            while (true)
            {
                var input = Console.ReadLine();

                if (input == "stats time")
                {
                    break;
                }
                else if (input.Contains("-"))
                {
                    AddVideoViews(input);
                }
                else if (input.Contains(":"))
                {
                    VideoLikes(input);
                }
            }

            var printOrder = Console.ReadLine();
            if (printOrder == "by views")
            {
                foreach (var video in listOfVideos.OrderByDescending(x => x.Views))
                {
                    Console.WriteLine($"{video.Name} - {video.Views} views - {video.Likes} likes");
                }
            }
            else if (printOrder == "by likes")
            {
                foreach (var video in listOfVideos.OrderByDescending(x=>x.Likes))
                {
                    Console.WriteLine($"{video.Name} - {video.Views} views - {video.Likes} likes");
                }
            }
        }

        private static void AddVideoViews(string input)
        {
            var info = input.Split("-");

            var name = info[0];
            int views = int.Parse(info[1]);

            if (!listOfVideos.Any(x => x.Name == name))
            {
                Video video = new Video
                {
                    Name = name,
                    Views = views
                };
                listOfVideos.Add(video);
            }
            else
            {
                var video = listOfVideos.FirstOrDefault(x => x.Name == name);
                video.Views += views;
            }
        }

        private static void VideoLikes(string input)
        {
            var info = input.Split(":");
            var name = info[1];
            if (listOfVideos.Any(x => x.Name == name))
            {
                var video = listOfVideos.FirstOrDefault(x => x.Name == name);
                if (info[0] == "like")
                {
                    video.Likes++;
                }
                else if (info[0] == "dislike")
                {
                    video.Likes--;
                }
            }
        }
    }
}
