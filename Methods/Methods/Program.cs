using System;

namespace Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int number = int.Parse(input);
            PrintSight(number);
        }

        static void PrintSight(int number)
        {
            if (number > 0)
            {
                Console.WriteLine($"The number {number} is positive.");
            }                            
            else if (number < 0)         
            {                            
                Console.WriteLine($"The number {number} is negative.");
            }                            
            else                         
            {                            
                Console.WriteLine($"The number {number} is zero.");
            }
        }
    }
}


