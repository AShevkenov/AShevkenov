using System;
using System.Collections.Generic;
using System.Linq;

namespace Man_O_War
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<int> pirateShip = Console.ReadLine().Split(">").Select(int.Parse).ToList();
            List<int> warship = Console.ReadLine().Split(">").Select(int.Parse).ToList();

            int maxHealth = int.Parse(Console.ReadLine());

            List<string> command = Console.ReadLine().Split().ToList();

            while (command[0] != "Retire")
            {

                switch (command[0])
                {
                    case "Fire":

                        int index = int.Parse(command[1]);
                        int damage = int.Parse(command[2]);

                        if (index > warship.Count - 1)
                        {
                            break;
                        }
                        
                        warship[index] -= damage;

                        if (warship[index] <= 0)
                        {
                            Console.WriteLine("You won! The enemy ship has sunken.");
                            return;
                        }


                        break;

                    case "Defend":

                        int startIndex = int.Parse(command[1]);
                        int endIndex = int.Parse(command[2]);
                        damage = int.Parse(command[3]);


                        for (int i = startIndex; i <= endIndex; i++)
                        {
                            if (startIndex < 0 || startIndex > pirateShip.Count - 1 || endIndex > pirateShip.Count - 1)
                            {
                                break;
                            }

                            pirateShip[i] -= damage;

                            if (pirateShip[i] <= 0)
                            {
                                Console.WriteLine("You lost! The pirate ship has sunken.");
                                return;
                            }

                        }

                        break;

                    case "Repair":

                        index = int.Parse(command[1]);
                        int health = int.Parse(command[2]);

                        if (pirateShip[index] + health > maxHealth)
                        {
                            int addHealth = ((pirateShip[index] + health) - maxHealth);
                            addHealth = health - addHealth;
                            pirateShip[index] += addHealth;
                            break;
                        }

                        pirateShip[index] += health;


                        break;

                    case "Status":

                        Status(pirateShip, warship, maxHealth, command);

                        break;
                }

                command = Console.ReadLine().Split().ToList();
            }
            Console.WriteLine($"Pirate ship status: {pirateShip.Sum()}");
            Console.WriteLine($"Warship status: {warship.Sum()}");

        }

        private static void Status(List<int> pirateShip, List<int> warship, int maxHealth, List<string> command)
        {

            int counter = 0;

            for (int i = 0; i < pirateShip.Count; i++)
            {
                double minHealth = maxHealth * 0.2;

                if (pirateShip[i] < minHealth)
                {
                    counter++;
                }
            }
            Console.WriteLine($"{counter} sections need repair.");
        }


    }
}

