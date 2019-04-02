using System;

namespace Photographer
{
    class Photographer
    {
        static void Main(string[] args) // с int-ове прелива и дава 70/100
        {
            long pictures = long.Parse(Console.ReadLine());
            long filterTime = long.Parse(Console.ReadLine());
            int filterFactor = int.Parse(Console.ReadLine());
            long uploadTime = long.Parse(Console.ReadLine());

            long timeSpend = pictures * filterTime;
            long totalPictures = Convert.ToInt64(Math.Ceiling(pictures * filterFactor / 100.0));
            timeSpend += totalPictures * uploadTime;
            TimeSpan time = TimeSpan.FromSeconds(timeSpend);
            string result = time.ToString("d\\:hh\\:mm\\:ss"); // или time.ToString(@"d\:hh\:mm\:ss");
            Console.WriteLine(result);
        }
    }
}
