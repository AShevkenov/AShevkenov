using System;

namespace Data_Types_and_Variables_LAB
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double m = double.Parse(Console.ReadLine());

            double km = 1000;

            Console.WriteLine($"{m/km:f2}");

        }
    }
}
