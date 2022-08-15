using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace RegEx_Exercises
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string pattern = @">>(?<name>[A-Za-z\s)]+)<<(?<price>\d+(.\d+)?)!(?<quantity>\d+)";

            List<string> furnitures = new List<string>();

            double totalPrice = 0;

            while (input != "Purchase")
            {

                Match matches = Regex.Match(input, pattern, RegexOptions.IgnoreCase);

                if (matches.Success)
                {
                    var name = matches.Groups["name"].Value;
                    double price = double.Parse(matches.Groups["price"].Value);
                    int quantity = int.Parse(matches.Groups["quantity"].Value);

                    furnitures.Add(name);
                    totalPrice += price * quantity;
                }
                     
                input = Console.ReadLine();
            }

            Console.WriteLine("Bought furniture:");
            furnitures.ForEach(Console.WriteLine);
            Console.WriteLine($"Total money spend: {totalPrice:f2}");
        }
    }
}
