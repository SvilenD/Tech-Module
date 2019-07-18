using System;

namespace P01_ThePhotographer
{
    class Program
    {
        static void Main(string[] args)
        {
            long pictures = long.Parse(Console.ReadLine());
            long filterTime = long.Parse(Console.ReadLine());
            int filterFactor = int.Parse(Console.ReadLine());
            long uploadTime = long.Parse(Console.ReadLine());

            long timeSpend = pictures * filterTime;

            long picturesToUpload = Convert.ToInt64(Math.Ceiling(pictures * filterFactor / 100.0));
            timeSpend += picturesToUpload * uploadTime;

            TimeSpan time = TimeSpan.FromSeconds(timeSpend);

            Console.WriteLine($"{time.Days}:{time.Hours:D2}:{time.Minutes:D2}:{time.Seconds:D2}");
        }
    }
}