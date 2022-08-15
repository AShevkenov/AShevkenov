using System;
using System.Collections.Generic;

namespace VCatalogue_2._0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            List<Car> cars = new List<Car>();
            List<Truck> trucks = new List<Truck>();

            double totalHpCar = 0;
            double totalHpTruck = 0;

            while (true)
            {
                string[] command = input.Split();
                string type = command[0];

                if (type == "End")
                {
                    break;
                }

                switch (type)
                {
                    case "car":
                        Car car = new Car()
                        {
                            Model = command[1],
                            Color = command[2],
                            HorsePower = int.Parse(command[3])

                        };
                        totalHpCar += car.HorsePower;
                        cars.Add(car);
                        break;

                    case "truck":
                        Truck truck = new Truck()
                        {
                            Model = command[1],
                            Color = command[2],
                            HorsePower = int.Parse(command[3])
                        };
                        totalHpTruck += truck.HorsePower;
                        trucks.Add(truck);
                        break;
                }

                input = Console.ReadLine();
            }

            string check = Console.ReadLine();


            while (check != "Close the Catalogue")
            {
                foreach (Car car in cars)
                {

                    if (check == car.Model)
                    {
                        Console.WriteLine($"Type: Car");
                        Console.WriteLine($"Model: {car.Model}");
                        Console.WriteLine($"Color: {car.Color}");
                        Console.WriteLine($"Horsepower: {car.HorsePower}");
                        break;
                    }
                }

                foreach (Truck truck in trucks)
                {

                    if (check == truck.Model)
                    {
                        Console.WriteLine($"Type: Truck");
                        Console.WriteLine($"Model: {truck.Model}");
                        Console.WriteLine($"Color: {truck.Color}");
                        Console.WriteLine($"Horsepower: {truck.HorsePower}");
                        break;
                    }
                }

                check = Console.ReadLine();
            }
            double avrgHpCar = 0;
            double avrgHpTrucks = 0; 

            if (cars.Count > 0) { avrgHpCar = totalHpCar / cars.Count; }
            if (trucks.Count > 0) { avrgHpTrucks = totalHpTruck / trucks.Count; }

            Console.WriteLine($"Cars have average horsepower of: {avrgHpCar:f2}.");
            Console.WriteLine($"Trucks have average horsepower of: {avrgHpTrucks:f2}.");


        }

        class Truck
        {
            public string Type { get; set; }
            public string Model { get; set; }
            public string Color { get; set; }
            public int HorsePower { get; set; }
        }

        class Car
        {

            public string Type { get; set; }
            public string Model { get; set; }
            public string Color { get; set; }
            public int HorsePower { get; set; }
        }


    }
}
