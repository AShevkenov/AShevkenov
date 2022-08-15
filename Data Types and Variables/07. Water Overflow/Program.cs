using System;

namespace _07._Water_Overflow
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int waterTankCapacity = 255;
            int times = int.Parse(Console.ReadLine());
            int sum = 0;

            for (int i = 1; i <= times; i++)
            {
                int quantities = int.Parse(Console.ReadLine());
                sum += quantities;
                if (sum > waterTankCapacity)
                {
                    Console.WriteLine("Insufficient capacity!");
                    sum -= quantities;
                    continue;
                }
            }
            Console.WriteLine(sum);
        }
    }
}
