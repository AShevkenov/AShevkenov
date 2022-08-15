using System;
using System.Text.RegularExpressions;

namespace SoftUni_Bar_Income
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"%(?<customer>[A-Za-z]+)%[^|$%.]*<(?<product>[\w]+)>[^|$%.]*\|(?<quantity>[0-9]+)\|[^|$%.]*?(?<price>[\d]+.?[\d]+)?\$";

            string input = Console.ReadLine();

            double totalIncome = 0;

            while (input != "end of shift")
            {

                Regex regex = new Regex(pattern);
                bool isValid = regex.IsMatch(input);

                if (isValid)
                {
                    string customer = regex.Match(input).Groups["customer"].Value;
                    string product = regex.Match(input).Groups["product"].Value;
                    int quantity = int.Parse(regex.Match(input).Groups["quantity"].Value);
                    double price = double.Parse(regex.Match(input).Groups["price"].Value);

                    double totalPriceForCurrentProduct = price * quantity;
                    totalIncome += totalPriceForCurrentProduct;
                    Console.WriteLine($"{customer}: {product} - {totalPriceForCurrentProduct:f2}");
                }
                input = Console.ReadLine();
            }

            Console.WriteLine($"Total income: {totalIncome:f2}");
        }
    }
}
