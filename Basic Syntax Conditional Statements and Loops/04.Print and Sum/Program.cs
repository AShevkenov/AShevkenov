using System;

namespace _04.Print_and_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numOne = int.Parse(Console.ReadLine());
            int numTwo = int.Parse(Console.ReadLine());
            int sum = 0;

            for (int i = numOne; i <= numTwo; i++)
            {       
                
                Console.Write($"{numOne} ");
                sum += numOne;
                numOne++;
                
            }
            Console.WriteLine();
            Console.WriteLine($"Sum: {sum}");


        }
    }
}
