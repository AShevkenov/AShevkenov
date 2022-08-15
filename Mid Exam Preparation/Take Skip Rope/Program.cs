using System;
using System.Collections.Generic;
using System.Linq;

namespace Take_Skip_Rope
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> nonNumbers = Console.ReadLine().Split().ToList();
            
            List<int> numbers = new List<int>();

            for (int i = 0; i < nonNumbers.Count - 1; i++)
            {
                numbers[i] = int.Parse(nonNumbers[i]);
            }
        }
    }
    
}
