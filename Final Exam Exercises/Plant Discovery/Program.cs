using System;
using System.Collections.Generic;

namespace Plant_Discovery
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfPlants = int.Parse(Console.ReadLine());

            Dictionary<string, KeyValuePair<double, double>> plants = new Dictionary<string, KeyValuePair<double, double>>();

            // string -> [KEY], a тъй като трябва да пазим 2 стойности вътре създавам KeyValuePair -> [VALUE] , за да може да ги достъпим по-нататък и да го променяме, ако се наложи.
            Dictionary<string, double> counter = new Dictionary<string, double>();

            // counter -> KEY ще е името на растението, VALUE -> колко пъти сме му променили рейтинга

            for (int i = 0; i < numberOfPlants; i++)
            {
                string[] information = Console.ReadLine().Split("<->");
                if (plants.ContainsKey(information[0])) // Проверка дали го имаме и му променяме rarity
                {
                    plants[information[0]] = new KeyValuePair<double, double>(double.Parse(information[1]), 0);
                    // plants[името на растението] = и добавяме стойностите му
                }
                else
                {
                    plants.Add(information[0], new KeyValuePair<double, double>(double.Parse(information[1]), 0));
                    counter.Add(information[0], 0);
                    // тук си добавяме напълно ново растение в PLANTS, както и в counter като ключа го правим името а валюто колко пъти е променяна цената. В този случай 0, защото току-що го добавяме.
                }
            }

            while (true)
            {
                string cmd = Console.ReadLine();

                if (cmd == "Exhibition")
                {
                    break;
                }

                string[] tokens = cmd.Split(':', '-');
                string action = tokens[0];
                string plantName = tokens[1].Trim();

                switch (action)
                {
                    case "Rate":
                        double rating = double.Parse(tokens[2].Trim());
                        if (plants.ContainsKey(plantName))
                        {
                            plants[plantName] = new KeyValuePair<double, double>(plants[plantName].Key, plants[plantName].Value + rating);
                            counter[plantName] += 1;
                        }
                        else Console.WriteLine("error");
                        break;

                    case "Update":
                        double rarity = double.Parse(tokens[2].Trim());
                        if (plants.ContainsKey(plantName))
                        {
                            plants[plantName] = new KeyValuePair<double, double>(rarity, plants[plantName].Value);
                        }
                        else Console.WriteLine("error");
                        break;

                    case "Reset":
                        if (plants.ContainsKey(plantName))
                        {
                            plants[plantName] = new KeyValuePair<double, double>(plants[plantName].Key, 0);
                            counter[plantName] = 0;
                        }
                        else Console.WriteLine("error");
                        break;
                }
            }

            Console.WriteLine($"Plants for the exhibition:");

            foreach (var plant in plants)
            {
                foreach (var item in counter)
                {
                    double divide = item.Value;
                    if (divide == 0)
                    {
                        divide = 1;
                    }
                    Console.WriteLine($"- {plant.Key}; Rarity: {plant.Value.Key}; Rating: {plant.Value.Value / divide:f2}");
                    counter.Remove(item.Key);
                    break;

                }
            }
        }
    }
}
