using System;
using System.Collections.Generic;
using System.Linq;

namespace TEST
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Dictionary<string, int> resources = new Dictionary<string, int>();

            int counter = 1;

            while (true)
            {
                string token = Console.ReadLine(); // gold

                if (token == "stop") break;

                if (counter % 2 != 0) // true
                {
                    if (!resources.ContainsKey(token)) // gold
                    {
                        resources.Add(token, 0); // gold , 0
                        counter++;
                    }
                    else
                    {
                        counter++;
                    }
                    if (counter % 2 == 0)
                    {
                        int amount = int.Parse(Console.ReadLine());
                        resources[token] += amount;
                        counter++;
                    }

                }

            }

            foreach (var res in resources)
            {
                Console.WriteLine($"{res.Key} -> {res.Value}");
            }
        }
    }
}
