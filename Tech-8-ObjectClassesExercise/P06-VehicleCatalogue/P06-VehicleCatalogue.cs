using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace P06_VehicleCatalogue
{
    class Vehicle
    {
        public Vehicle(string type, string model, string color, double power)
        {
            this.Type = type;
            this.Model = model;
            this.Color = color;
            this.HorsePower = power;
        }

        public string Type { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public double HorsePower { get; set; }
    }

    class Program
    {
        static List<Vehicle> vehicleList = new List<Vehicle>();

        static void Main(string[] args)
        {
            InputInfo();

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "Close the Catalogue")
                {
                    break;
                }

                PrintModelData(input);
            }

            PrintSummary();
        }

        static void InputInfo()
        {
            while (true)
            {
                var input = Console.ReadLine().Split();
                if (input[0] == "End")
                {
                    break;
                }

                var type = input[0];
                var model = input[1];
                var color = input[2];
                double power = double.Parse(input[3]);

                var vehicle = new Vehicle(type, model, color, power);
                vehicleList.Add(vehicle);
            }
        }

        private static void PrintModelData(string input)
        {
            var vehicle = vehicleList.FirstOrDefault(x => x.Model == input);

            Console.WriteLine($"Type: {CultureInfo.CurrentCulture.TextInfo.ToTitleCase(vehicle.Type)}");
            Console.WriteLine($"Model: {vehicle.Model}");
            Console.WriteLine($"Color: {vehicle.Color}");
            Console.WriteLine($"Horsepower: {vehicle.HorsePower}");
        }

        static void PrintSummary()
        {
            double carsPower = 0;
            if (vehicleList.Any(x => x.Type == "car"))
            {
                carsPower = vehicleList.Where(c => c.Type == "car").Average(c => c.HorsePower);
            }
            Console.WriteLine($"Cars have average horsepower of: {carsPower:f2}.");

            double trucksPower = 0;
            if (vehicleList.Any(x => x.Type == "truck"))
            {
                trucksPower = vehicleList.Where(t => t.Type == "truck").Average(t => t.HorsePower);
            }
            Console.WriteLine($"Trucks have average horsepower of: {trucksPower:f2}.");
        }
    }
}