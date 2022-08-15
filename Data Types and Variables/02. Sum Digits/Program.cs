using System;

namespace _02._Sum_Digits
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()); //23
            int lastDigit = 0;
            int sum = 0;

            while (n != 0)
            {
                lastDigit = n % 10; // 3
                n /= 10;
                sum += lastDigit; // 3
            }


            Console.WriteLine(sum);

        }
    }
}
