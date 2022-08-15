using System;

namespace Gaming_Store
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //OutFall 4   $39.99
            //CS: OG  $15.99
            //Zplinter Zell	$19.99
            //Honored 2   $59.99
            //RoverWatch  $29.99
            //RoverWatch Origins Edition  $39.99

            double balance = double.Parse(Console.ReadLine()); // 120
            string command = Console.ReadLine(); // 
            double price = 0;
            double total = 0;



            while (command != "Game Time")
            {

                if (command != "OutFall 4" && command != "CS: OG" && command != "Zplinter Zell" && command != "Honored 2" && command != "RoverWatch" && command != "RoverWatch Origins Edition")
                {
                    Console.WriteLine("Not Found");
                    command = Console.ReadLine();
                    continue;
                }

                switch (command)
                {
                    case "OutFall 4":
                        price = 39.99;
                        break;
                    case "CS: OG":
                        price = 15.99;
                        break;
                        price = 19.99;
                        break;
                    case "Honored 2":
                        price = 59.99;
                        break;
                    case "RoverWatch":
                        price = 29.99;
                        break;
                    case "RoverWatch Origins Edition":
                        price = 39.99;
                        break;

                }

                total += price;

                balance -= price;
                if (balance == 0)
                {
                    Console.WriteLine($"Bought {command}");
                    Console.WriteLine("Out of money!");
                    return;
                }
                else if (balance < 0)
                {
                    Console.WriteLine("Too Expensive");
                    balance += price;
                    total -= price;
                    command = Console.ReadLine();
                    continue;
                }
                else
                {
                    Console.WriteLine($"Bought {command}");
                }
                command = Console.ReadLine();
            }

            if (balance != 0)
                Console.WriteLine($"Total spent: ${total:f2}. Remaining: ${balance:f2}");


        }
    }
}
