using System;

namespace AdvertisementMessage
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] phrases = { "Excellent product.", "Such a great product.", "I always use that product.", "Best product of its category.",
                "Exceptional product.", "I can’t live without this product."};
            string[] events = { "Now I feel good.", "I have succeeded with this product.", "Makes miracles. I am happy of the results!",
                "I cannot believe but now I feel awesome.", "Try it yourself, I am very satisfied.", "I feel great!" };
            string[] authors = { "Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva" };
            string[] cities = { "Burgas", "Sofia", "Plovdiv", "Varna", "Ruse" };

            int numberOfAds = int.Parse(Console.ReadLine());

            var random = new Random();
            for (int i = 0; i < numberOfAds; i++)
            {
                int phraseRandom = random.Next(0, phrases.Length);
                string phrase = phrases[phraseRandom];

                int eventsRandom = random.Next(0, events.Length);
                string eventsRnd = events[eventsRandom];

                int authorsRandom = random.Next(0, authors.Length);
                string author = authors[authorsRandom];

                int citiesRandom = random.Next(0, cities.Length);
                string city = cities[citiesRandom];
                Console.WriteLine($"{phrase} {eventsRnd} {author} – {city}.");
            }
        }
    }
}