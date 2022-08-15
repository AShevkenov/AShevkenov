using System;
using System.Collections.Generic;
using System.Linq;

namespace Car_Race
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            double leftCarTime = 0;
            double rightCarTime = 0;

            for (int i = 0; i < (numbers.Count - 1) / 2; i++)
            {
                leftCarTime += numbers[i];
                rightCarTime += numbers[(numbers.Count - 1)- i];

                if (numbers[i] == 0)
                {
                    leftCarTime *= 0.8;
                }

                if (numbers[(numbers.Count - 1) - i] == 0)
                {
                    rightCarTime *= 0.8;
                }
            }

            if (leftCarTime < rightCarTime)
            {
                Console.WriteLine($"The winner is left with total time: {leftCarTime}");
            }
            else
            {
                Console.WriteLine($"The winner is right with total time: {rightCarTime}");

            }
        }
    }
}
