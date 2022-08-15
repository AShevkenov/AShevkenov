using System;
using System.Collections.Generic;

namespace _02._Pascal_Triangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());

            for (int i = 0; i < lines; i++)
            {
                int number = 1;

                for (int n = 0; n <= i; n++)
                {
                    Console.Write($"{number} ");
                    number = number * (i - n) / (n + 1);
                }

                Console.WriteLine();
            }
        }
    }
}
