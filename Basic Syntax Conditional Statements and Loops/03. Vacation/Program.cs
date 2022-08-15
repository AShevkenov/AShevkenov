using System;

namespace _03._Vacation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double ppl = double.Parse(Console.ReadLine());
            string type = Console.ReadLine();
            string day = Console.ReadLine();

            double price = 0;
            double total = 0;

            if (type != "Students")
            {
                if (type == "Business")
                {
                    switch (day)
                    {
                        case "Friday":
                            price = 10.90;
                            break;
                        case "Saturday":
                            price = 15.60;
                            break;
                        case "Sunday":
                            price = 16.00;
                            break;
                    }

                    total = ppl * price;

                    if (ppl >= 100)
                    {
                        double discount = 10 * price;
                        total = ppl * price - discount;
                    }
                }
                else
                {
                    switch (day)
                    {
                        case "Friday":
                            price = 15.00;
                            break;
                        case "Saturday":
                            price = 20.00;
                            break;
                        case "Sunday":
                            price = 22.50;
                            break;
                    }

                    total = ppl * price;

                    if (ppl >= 10 && ppl <= 20)
                    {
                        total = ppl * price;
                        total *= 0.95;
                    }
                }
            }
            else
            {
                switch (day)
                {
                    case "Friday":
                        price = 8.45;
                        break;
                    case "Saturday":
                        price = 9.80;
                        break;
                    case "Sunday":
                        price = 10.46;
                        break;
                }

                total = ppl * price;

                if (ppl >= 30)
                {
                    total = ppl * price;
                    total *= 0.85;
                }
            }

            Console.WriteLine($"Total price: {total:f2}");
        }
    }
}