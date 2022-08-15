using System;

namespace Arrays___Exercises
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numOfWagons = int.Parse(Console.ReadLine());
            int[] wagons = new int[numOfWagons];
            int total = 0;

            for (int i = 0; i < numOfWagons; i++)
            {
                int people = int.Parse(Console.ReadLine());
                wagons[i] = people;
                total += people;
            }
            for (int i = 0; i < numOfWagons; i++)
            {
                Console.Write($"{wagons[i]} ");
            }
            Console.WriteLine();
            Console.WriteLine(total);
            

        }
    }
}
