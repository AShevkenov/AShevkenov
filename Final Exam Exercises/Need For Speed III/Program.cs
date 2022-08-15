using System;
using System.Collections.Generic;

namespace Need_For_Speed_III
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfCars = int.Parse(Console.ReadLine());

            Dictionary<string, KeyValuePair<int, int>> myCars = new Dictionary<string, KeyValuePair<int, int>>();

            for (int i = 0; i < numberOfCars; i++)
            {
                string[] carInfo = Console.ReadLine().Split('|');
                string car = carInfo[0];
                int mileage = int.Parse(carInfo[1]);
                int fuel = int.Parse(carInfo[2]);

                myCars.Add(car, new KeyValuePair<int, int>(mileage, fuel));
            }

            while (true)
            {
                string cmd = Console.ReadLine();

                if (cmd == "Stop")
                {
                    break;
                }

                string[] tokens = cmd.Split(" : ");
                string action = tokens[0];

                switch (action)
                {
                    case "Drive":
                        {

                            string car = tokens[1];
                            int distanceToMove = int.Parse(tokens[2]);
                            int neededFuel = int.Parse(tokens[3]);

                            if (neededFuel > myCars[car].Value)
                            {
                                Console.WriteLine($"Not enough fuel to make that ride");
                            }

                            else
                            {
                                int distance = myCars[car].Key + distanceToMove;
                                int fuel = myCars[car].Value - neededFuel;

                                myCars[car] = new KeyValuePair<int, int>(distance, fuel);
                                Console.WriteLine($"{car} driven for {distanceToMove} kilometers. {neededFuel} liters of fuel consumed.");

                                if (distance > 100000)
                                {
                                    myCars.Remove(car);
                                    Console.WriteLine($"Time to sell the {car}!");
                                    break;
                                }
                            }
                        }
                        break;

                    case "Refuel":
                        {
                            string car = tokens[1];
                            int fuelToFill = int.Parse(tokens[2]);

                            if (fuelToFill + myCars[car].Value > 75)
                            {
                                fuelToFill = 75 - myCars[car].Value;
                                myCars[car] = new KeyValuePair<int, int>(myCars[car].Key, 75);
                                Console.WriteLine($"{car} refueled with {fuelToFill} liters");
                            }
                            else
                            {
                                myCars[car] = new KeyValuePair<int, int>(myCars[car].Key, myCars[car].Value + fuelToFill);
                                Console.WriteLine($"{car} refueled with {fuelToFill} liters");
                            }
                        }
                        break;

                    case "Revert":
                        {
                            string car = tokens[1];
                            int revertMileages = int.Parse(tokens[2]);

                            if (myCars[car].Key - revertMileages < 10000)
                            {
                                myCars[car] = new KeyValuePair<int, int>(10000, myCars[car].Value);
                                break;
                            }

                            myCars[car] = new KeyValuePair<int, int>(myCars[car].Key - revertMileages, myCars[car].Value);
                            Console.WriteLine($"{car} mileage decreased by {revertMileages} kilometers");
                        }
                        break;
                }
            }

            foreach (var item in myCars)
            {
                Console.WriteLine($"{item.Key} -> Mileage: {item.Value.Key} kms, Fuel in the tank: {item.Value.Value} lt.");
            }
        }
    }
}
