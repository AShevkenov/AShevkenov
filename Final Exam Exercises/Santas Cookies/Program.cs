using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

class MOBAChallenger
{
    static void Main(string[] args)
    {
        Dictionary<string, List<string>> hero = new Dictionary<string, List<string>>();

        string cmd = Console.ReadLine();

        while (true)
        {
            if (cmd == "End")
            {
                break;
            }

            string[] tokens = cmd.Split();
            string action = tokens[0];
            string heroName = tokens[1];


            switch (action)
            {
                case "Enroll":
                    {
                        if (hero.ContainsKey(heroName))
                        {
                            Console.WriteLine($"{heroName} is already enrolled.");
                        }
                        else
                        {
                            hero.Add(heroName, new List<string>());
                        }
                    }
                    break;

                case "Learn":
                    {
                        string spellName = tokens[2];
                        if (hero.ContainsKey(heroName))
                        {
                            if (hero[heroName].Contains(spellName))
                            {
                                Console.WriteLine($"{heroName} has already learnt {spellName}.");
                            }
                            else
                            {
                                hero[heroName].Add(spellName);
                            }
                        }
                        else
                        {
                            Console.WriteLine($"{heroName} doesn't exist.");
                        }
                    }
                    break;

                case "Unlearn":
                    {
                        string spellName = tokens[2];
                        if (!hero.ContainsKey(heroName))
                        {
                            Console.WriteLine($"{heroName} doesn't exist.");
                        }
                        else
                        {
                            if (hero[heroName].Contains(spellName))
                            {
                                hero[heroName].Remove(spellName);
                            }
                            else
                            {
                                Console.WriteLine($"{heroName} doesn't know {spellName}.");
                            }
                        }
                    }
                    break;
            }

            cmd = Console.ReadLine();
        }

        Console.WriteLine("Heroes:");
        foreach (var item in hero)
        {
            Console.WriteLine($"== {item.Key}: {string.Join(", ", item.Value)}");
        }
    }

}