using System;
using System.Collections.Generic;
using System.Linq;

namespace P04_Songs
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());

            var songsList = new List<Song>();
            for (int i = 0; i < count; i++)
            {
                string[] input = Console.ReadLine().Split(new char[] { '_' });
                string type = input[0];
                string name = input[1];
                string length = input[2];

                Song song = new Song();
                song.TypeList = type;
                song.Name = name;
                song.Length = length;

                songsList.Add(song);
            }
            string typeList = Console.ReadLine();
            foreach (var song in songsList.Where(x=>x.TypeList == typeList))
            {
                Console.WriteLine(song.Name);
            }
        }
    }

    class Song
    {
        public string TypeList { get; set; }

        public string Name { get; set; }

        public string Length { get; set; }
    }
}
