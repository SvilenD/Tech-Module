using System;
using System.Collections.Generic;
using System.Linq;

namespace P08_VehicleCatalogue
{
    class Catalogue
    {
        public Catalogue(List<Car> carsList, List<Truck> trucksList)
        {
            this.CarsCatalogue = carsList;      //if carList & truckList are initiated in the main method;
            this.TrucksCatalogue = trucksList;
        }
        public Catalogue()
        {
            this.CarsCatalogue = new List<Car>();
            this.TrucksCatalogue = new List<Truck>();
        }
        public List<Truck> TrucksCatalogue { get; set; }
        public List<Car> CarsCatalogue { get; set; }
    }

    class Car
    {
        public Car(string brand, string model, int horsePower)
        {
            this.Brand = brand;
            this.Model = model;
            this.HorsePower = horsePower;
        }

        public string Brand { get; set; }

        public string Model { get; set; }

        public int HorsePower { get; set; }

        public override string ToString()
        {
            return $"{Brand}: {Model} - {HorsePower}hp";
        }

    }

    class Truck
    {
        public Truck(string brand, string model, int weight)
        {
            this.Brand = brand;
            this.Model = model;
            this.Weight = weight;
        }

        public string Brand { get; set; }

        public string Model { get; set; }

        public int Weight { get; set; }

        public override string ToString()
        {
            return $"{Brand}: {Model} - {Weight} kg";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var catalogue = new Catalogue();

            while (true)
            {
                string[] input = Console.ReadLine().Split("/");
                if (input[0] == "end")
                {
                    break;
                }
                string type = input[0];
                if (type == "Truck")
                {
                    string brand = input[1];
                    string model = input[2];
                    int weight = int.Parse(input[3]);

                    var truck = new Truck(brand, model, weight);
                    if (!catalogue.TrucksCatalogue.Contains(truck))
                    {
                        catalogue.TrucksCatalogue.Add(truck);
                    }
                }
                else if (type == "Car")
                {
                    string brand = input[1];
                    string model = input[2];
                    int horsePower = int.Parse(input[3]);

                    var car = new Car(brand, model, horsePower);
                    if (!catalogue.CarsCatalogue.Contains(car))
                    {
                        catalogue.CarsCatalogue.Add(car);
                    }
                }
            }
            if (catalogue.CarsCatalogue.Count > 0)
            {
                Console.WriteLine("Cars:");
                foreach (var car in catalogue.CarsCatalogue.OrderBy(c => c.Brand))
                {
                    Console.WriteLine(car);
                }
            }
            if (catalogue.TrucksCatalogue.Count > 0)
            {
                Console.WriteLine("Trucks:");
                foreach (var truck in catalogue.TrucksCatalogue.OrderBy(t => t.Brand))
                {
                    Console.WriteLine(truck);
                }
            }
        }
    }
}