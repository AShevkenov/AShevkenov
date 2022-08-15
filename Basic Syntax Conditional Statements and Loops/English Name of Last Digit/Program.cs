using System;

namespace English_Name_of_Last_Digit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            int lastDigit = number % 10;

            if (lastDigit + 9 == 10)
            {
                Console.WriteLine("one");
            }
            if (lastDigit + 8 == 10)
            {
                Console.WriteLine("two");
            }
            if (lastDigit + 7 == 10)
            {
                Console.WriteLine("three");
            }
            if (lastDigit + 6 == 10)
            {
                Console.WriteLine("four");
            }
            if (lastDigit + 5 == 10)
            {
                Console.WriteLine("five");
            }
            if (lastDigit + 4 == 10)
            {
                Console.WriteLine("six");
            }
            if (lastDigit + 3 == 10)
            {
                Console.WriteLine("seven");
            }
            if (lastDigit + 2 == 10)
            {
                Console.WriteLine("eight");
            }
            if (lastDigit + 1 == 10)
            {
                Console.WriteLine("nine");
            }
            if (lastDigit == 0)
            {
                Console.WriteLine("zero");
            }

        }
    }
}
