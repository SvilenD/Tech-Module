using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace VehicleCatalogue
{
    public class Vehicle
    {
        public Vehicle(string type, string model, string color, double horsePower)
        {
            this.Type = type;
            this.Model = model;
            this.Color = color;
            this.Power = horsePower;
        }

        public string Type { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public double Power { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var vehicleCatalogue = new List<Vehicle>();
            while (true)
            {
                string[] input = Console.ReadLine().Split();

                if (input[0].ToLower() == "end")
                {
                    break;
                }

                string type = input[0].ToLower();
                string model = input[1];
                string color = input[2];
                double horsePower = double.Parse(input[3]);

                var vehicle = new Vehicle(type, model, color, horsePower);
                vehicleCatalogue.Add(vehicle);
            }

            while (true)
            {
                string filter = Console.ReadLine();
                if (filter == "Close the Catalogue")
                {
                    break;
                }

                foreach (var vehicle in vehicleCatalogue.Where(x => x.Model == filter))
                {
                    Console.WriteLine($"Type: {CultureInfo.InvariantCulture.TextInfo.ToTitleCase(vehicle.Type)}");
                    Console.WriteLine($"Model: {vehicle.Model}");
                    Console.WriteLine($"Color: {vehicle.Color}");
                    Console.WriteLine($"Horsepower: {vehicle.Power}");
                }
            }

            double carsAveragePower = 0;

            if (vehicleCatalogue.Where(x => x.Type == "car").Count() > 0)
            {
                carsAveragePower = vehicleCatalogue.Where(x => x.Type == "car").Average(y => y.Power);
            }
            Console.WriteLine($"Cars have average horsepower of: {carsAveragePower:F2}.");

            double trucksAveragePower = 0;

            if (vehicleCatalogue.Where(x => x.Type == "truck").Count() > 0)
            {
                trucksAveragePower = vehicleCatalogue.Where(x => x.Type == "truck").Average(y => y.Power);
            }
            Console.WriteLine($"Trucks have average horsepower of: {trucksAveragePower:F2}.");
        }
    }
}