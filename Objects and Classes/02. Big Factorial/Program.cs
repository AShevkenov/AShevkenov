using System;
using System.Numerics;

namespace _02._Big_Factorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numbers = int.Parse(Console.ReadLine());
            BigInteger result = 1;

            for (int i = 2; i <= numbers; i++)
            {
                result *= i;
            }

            Console.WriteLine(result);
        }
    }
}
