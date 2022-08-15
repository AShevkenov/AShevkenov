using System;
using System.Collections.Generic;
using System.Linq;

namespace Train
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numberOfPassengers = Console.ReadLine().Split().Select(int.Parse).ToList();
            int maxCapacity = int.Parse(Console.ReadLine());

            string[] command = Console.ReadLine().Split();

            while (command[0] != "end")
            {
                string token = command[0];               

                if (token == "Add")
                {
                    numberOfPassengers.Add(int.Parse(command[1]));
                }
                else
                {
                    int newPassengers = Convert.ToInt32(command[0]);

                    AddPassengers(numberOfPassengers, newPassengers, maxCapacity);
                 
                }

                    command = Console.ReadLine().Split();
            }

            Console.Write(string.Join(" ", numberOfPassengers));
        }
        
        private static void AddPassengers(List<int> numbersOfPassengers, int newPassengers, int maxCapacity)
        {
            for (int i = 0; i < numbersOfPassengers.Count; i++)
            {
                if (numbersOfPassengers[i] + newPassengers <= maxCapacity)
                {
                    numbersOfPassengers[i] += newPassengers;
                    break;
                }
            }
        }
    }
}
