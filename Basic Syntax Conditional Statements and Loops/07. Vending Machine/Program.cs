using System;

namespace _07._Vending_Machine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string command = (Console.ReadLine());
            double totalInsert = 0;

            while (command != "Start")
            {
                double insertCoins = Convert.ToDouble(command);

                if (insertCoins != 0.1 && insertCoins != 0.2 && insertCoins != 0.5 && insertCoins != 1.00 && insertCoins != 2.00)
                {
                    Console.WriteLine($"Cannot accept {insertCoins}");
                    totalInsert -= insertCoins;
                }

                totalInsert += insertCoins;

                command = Console.ReadLine();

            }
            string producttobuy = Console.ReadLine();
            while (producttobuy != "End")
            {
                if (producttobuy != "Coke" && producttobuy != "Nuts" && producttobuy != "Water" && producttobuy != "Soda" && producttobuy != "Crisps")
                {
                    Console.WriteLine("Invalid product");
                }
                if (producttobuy == "Coke")
                {
                    totalInsert -= 1.0;
                    if (totalInsert >= 0)
                    {
                        Console.WriteLine("Purchased coke");
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                        totalInsert += 1.0;
                    }
                }
                if (producttobuy == "Nuts")
                {
                    totalInsert -= 2.0;
                    if (totalInsert >= 0)
                    {
                        Console.WriteLine("Purchased nuts");
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                        totalInsert += 2.0;
                    }
                }
                if (producttobuy == "Water")
                {
                    totalInsert -= 0.7;
                    if (totalInsert >= 0)
                    {
                        Console.WriteLine("Purchased water");
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                        totalInsert += 0.7;
                    }
                }
                if (producttobuy == "Soda")
                {
                    totalInsert -= 0.8;
                    if (totalInsert >= 0)
                    {
                        Console.WriteLine("Purchased soda");
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                        totalInsert += 0.8;
                    }
                }
                if (producttobuy == "Crisps")
                {
                    totalInsert -= 1.5;
                    if (totalInsert >= 0)
                    {
                        Console.WriteLine("Purchased crisps");
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                        totalInsert += 1.5;
                    }
                }
                producttobuy = Console.ReadLine();
                if (producttobuy == "End")

                {
                    Console.WriteLine($"Change: {totalInsert:f2}");
                    return;
                }
            }


        }

    }
}
