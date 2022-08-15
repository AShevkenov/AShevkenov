using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._A_Miner_Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Dictionary<string, int> resources = new Dictionary<string, int>();

            //string input = Console.ReadLine();
            //int quantity = int.Parse(Console.ReadLine());

            //int counter = 0;

            //while (true)
            //{
            //    if (counter % 2 == 0)
            //    {
            //        if (resources.ContainsKey(input))
            //        {
            //            resources[input] += quantity;
            //            input = Console.ReadLine();
            //            if (input == "stop")
            //            {
            //                break;
            //            }
            //            quantity = int.Parse(Console.ReadLine());
            //            continue;
            //        }
            //        resources.Add(input, 0);
            //    }

            //    counter++;

            //    if (counter % 2 == 1)
            //    {
            //        if (resources.ContainsKey(input))
            //        {
            //            resources[input] += quantity;
            //        }
            //    }

            //    counter++;

            //    input = Console.ReadLine();
            //    if (input == "stop") break;
            //    quantity = int.Parse(Console.ReadLine());



            //}

            //foreach (var item in resources)
            //{
            //    Console.WriteLine($"{item.Key} -> {item.Value}");
            //}


            Dictionary<string, int> items = new Dictionary<string, int>();
            string resources = Console.ReadLine();

            while (resources != "stop")
            {
                if (resources != null) continue;

                int quantity = int.Parse(Console.ReadLine());

                if (!items.ContainsKey(resources))
                {
                    items.Add(resources, 0);
                }
                items[resources] += quantity;

                resources = Console.ReadLine();
            }

            foreach (var currRes in items)
            {
                Console.WriteLine($"{currRes.Key} -> {currRes.Value}");
            }

        }

    }
}
