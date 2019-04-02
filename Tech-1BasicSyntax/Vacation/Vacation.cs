using System;

namespace Vacation
{
    class Vacation
    {
        static void Main(string[] args)
        {
            int people = int.Parse(Console.ReadLine());
            string type = Console.ReadLine().ToLower();
            string dayOfWeek = Console.ReadLine().ToLower();
            decimal price = 0;
            if (type == "students")
            {
                switch (dayOfWeek)
                {
                    case "friday": price = 8.45m;  break;
                    case "saturday": price = 9.80m; break;
                    case "sunday": price = 10.46m; break;
                }
                if (people >= 30) price *= 0.85m;
            }
            else if (type == "business")
            {
                switch (dayOfWeek)
                {
                    case "friday": price = 10.90m; break;
                    case "saturday": price = 15.60m; break;
                    case "sunday": price = 16m; break;
                }
                if (people >= 100) people -= 10;
            }
            else if (type == "regular")
            {
                switch (dayOfWeek)
                {
                    case "friday": price = 15m; break;
                    case "saturday": price = 20.0m; break;
                    case "sunday": price = 22.5m; break;
                }
                if (people >= 10 && people <= 20) price *= 0.95m;
            }
            Console.WriteLine($"Total price: {price*people:f2}");
        }
    }
}
