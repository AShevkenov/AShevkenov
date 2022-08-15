using System;
using System.Collections.Generic;
using System.Text;

namespace World_Tour
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string allOfStop = Console.ReadLine();

            while (true)
            {
                string cmd = Console.ReadLine();
                if (cmd == "Travel") break;

                string[] tokens = cmd.Split(':');
                string action = tokens[0];

                switch (action)
                {
                    case "Add Stop":
                        int index = int.Parse(tokens[1]);
                        string newDestination = tokens[2];
                        if (index >= 0 && index < allOfStop.Length)
                        {
                            allOfStop = allOfStop.Insert(index, newDestination);
                        }

                        Console.WriteLine(allOfStop);
                        break;

                    case "Remove Stop":
                        int startIndex = int.Parse(tokens[1]);
                        int endIndex = int.Parse(tokens[2]);
                        if (startIndex >= 0 && endIndex < allOfStop.Length)
                        {

                            allOfStop = allOfStop.Remove(startIndex, endIndex - startIndex + 1);
                        }

                        Console.WriteLine(allOfStop);
                        break;

                    case "Switch":
                        string oldString = tokens[1];
                        string newString = tokens[2];
                        if (allOfStop.Contains(oldString))
                        {
                            allOfStop = allOfStop.Replace(oldString, newString);
                        }
                        Console.WriteLine(allOfStop);
                        break;
                }
            }

            Console.WriteLine($"Ready for world tour! Planned stops: {allOfStop}");
        }
    }
}
