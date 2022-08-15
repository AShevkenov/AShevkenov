using System;

namespace Computer_Store
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            double totalPrice = 0;
            double totalTaxes = 0;

            while (command != "special" && command != "regular")
            {
                double partPrice = double.Parse(command);

                if (partPrice <= 0)
                {
                    Console.WriteLine("Invalid price!");
                    command = Console.ReadLine();
                    continue;
                }

                totalTaxes += (partPrice * 1.2) - partPrice;
                partPrice *= 1.2;
                totalPrice += partPrice;

                command = Console.ReadLine();
            }

            double withoutTaxes = totalPrice - totalTaxes;

            if (totalPrice <= 0)
            {
                Console.WriteLine("Invalid order!");
                return;
            }
            if (command == "special")
            {
                totalPrice *= 0.9;
            }

            Console.WriteLine("Congratulations you've just bought a new computer!");
            Console.WriteLine($"Price without taxes: {withoutTaxes:f2}$");
            Console.WriteLine($"Taxes: {totalTaxes:f2}$");
            Console.WriteLine("-----------");
            Console.WriteLine($"Total price: {totalPrice:f2}$");

        }
    }
}

