using System;
using System.Collections.Generic;

namespace Songs
{
    public class Song
    {
        public string TypeList { get; set; }

        public string Name { get; set; }

        public string Time { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int numberOfSongs = int.Parse(Console.ReadLine());

            List<Song> songsCollection = new List<Song>();

            for (int index = 0; index < numberOfSongs; index++)
            {
                string[] input = Console.ReadLine().Split('_');

                Song song = new Song()
                {
                    TypeList = input[0],
                    Name = input[1],
                    Time = input[2]
                };
                songsCollection.Add(song);
            }
            string typeList = Console.ReadLine();

            if (typeList == "all")
            {
                foreach (var song in songsCollection)
                {
                    Console.WriteLine(song.Name);
                }
            }
            else
            {
                foreach (var song in songsCollection)
                {
                    if (song.TypeList == typeList)
                    {
                        Console.WriteLine(song.Name);
                    }
                }
            }
        }
    }
}