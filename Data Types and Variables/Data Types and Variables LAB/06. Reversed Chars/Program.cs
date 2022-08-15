using System;

namespace _06._Reversed_Chars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char symbol = char.Parse(Console.ReadLine());
            char symbolTwo = char.Parse(Console.ReadLine());
            char symbolThree = char.Parse(Console.ReadLine());

            Console.Write($"{symbolThree} {symbolTwo} {symbol}");

        }
    }
}
