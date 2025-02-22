﻿using System;

namespace Data_Types_and_Variables___More_Exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();

            while (input != "END")
            {
                if (int.TryParse(input, out int integer))
                {
                    Console.WriteLine($"{input} is integer type");
                }
                else if (double.TryParse(input, out double number))
                {
                    Console.WriteLine($"{ input} is floating point type");
                }
                else if (char.TryParse(input, out char character))
                {
                    Console.WriteLine($"{input} is character type");
                }
                else if (bool.TryParse(input, out bool boolean))
                {
                    Console.WriteLine($"{input} is boolean type");
                }
                else
                {
                    Console.WriteLine($"{input} is string type");
                }

                input = Console.ReadLine();
            }
        }
    }
}
