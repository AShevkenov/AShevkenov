﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace List_Exercises
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> wagons = Console.ReadLine().Split().Select(int.Parse).ToList();
            int maxCapacity = int.Parse(Console.ReadLine());
            string command = Console.ReadLine();

            while (command != "end")
            {
                string[] tokens = command.Split();
                if (tokens.Length == 2)
                {
                    int wagon = int.Parse(tokens[1]);
                    wagons.Add(wagon);
                }
                else
                {
                    int passengers = int.Parse(tokens[0]);
                    FindWagon(wagons, maxCapacity, passengers);
                }

                command = Console.ReadLine();
            }

            Console.WriteLine(String.Join(" ", wagons));
        }

        private static void FindWagon(List<int> wagons, int maxCapacity, int passengers)
        {
            for (int i = 0; i < wagons.Count; i++)
            {
                int currentWagon = wagons[i];
                if (currentWagon + passengers <= maxCapacity)
                {
                    wagons[i] += passengers;
                    break;
                }
            }
        }
    }
}
