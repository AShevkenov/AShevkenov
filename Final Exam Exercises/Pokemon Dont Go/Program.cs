using System;
using System.Linq;

namespace Magic_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int n = int.Parse(Console.ReadLine());


            int sum = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    sum = numbers[i] + numbers[j];

                    if (sum == n)
                    {
                        Console.WriteLine($"{numbers[i]} {numbers[j]}");
                        sum = 0;
                        break;
                    }

                    sum = 0;
                }
            }
        }
    }
}
