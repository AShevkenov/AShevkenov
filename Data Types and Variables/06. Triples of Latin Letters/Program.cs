using System;

namespace _06._Triples_of_Latin_Letters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()); // 3

            for (int i = 0; i < n; i++)
            {
                for (int j = 0 ; j < n; j++)
                {
                    for (int m = 0; m < n; m++)
                    {
                        char first = Convert.ToChar(i + 97);
                        char second = Convert.ToChar(j + 97);
                        char third = Convert.ToChar(m + 97);
                        Console.WriteLine($"{first}{second}{third}");
                    }
                }
            }
        }
    }
}
