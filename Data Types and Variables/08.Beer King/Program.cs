using System;

namespace _08.Beer_King
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            double biggestKeg = double.MinValue;
            string model = "";
            string biggest = "";
            for (int i = 1; i <= n; i++)
            {
                model = Console.ReadLine();
                var radius = double.Parse(Console.ReadLine());
                var height = int.Parse(Console.ReadLine());

                double volumeKeg = Math.PI * Math.Pow(radius,2) * height;
                if (volumeKeg > biggestKeg)
                {
                    biggestKeg = volumeKeg;
                    biggest = model;
                }
            }
            Console.WriteLine(biggest);
        }
    }
}

