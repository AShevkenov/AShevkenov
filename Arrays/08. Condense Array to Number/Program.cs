using System;
using System.Linq;

namespace _08._Condense_Array_to_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray(); // 2
            int[] condensed = new int[numbers.Length - 1]; // 2-1 => 1


            while (numbers.Length > 1)
            {

                for (int i = 0; i < numbers.Length - 1; i++) // i = 1; 1 < 2
                {
                    condensed[i] = numbers[i] + numbers[i + 1]; // 2+10 = 12; 10+3 = 13;

                    if (i == numbers.Length - 2)
                    {
                        numbers = condensed;
                        condensed = new int[numbers.Length - 1];
                    }
                }
            }
            Console.WriteLine(numbers[0]);

        }
    }
}
