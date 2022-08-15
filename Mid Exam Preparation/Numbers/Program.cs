using System;
using System.Collections.Generic;
using System.Linq;

namespace Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> topNums = new List<int>();

            double average = Math.Round(numbers.Average(), 2);

            for (int i = 0; i <= numbers.Count - 1; i++)
            {
                if (numbers[i] > average)
                {
                    topNums.Add(numbers[i]);                   
                }            
            }

            if (topNums.Count == 0)
            {
                Console.WriteLine("No");
                return;
            }

            topNums.Sort();
            topNums.Reverse();

            if(topNums.Count - 1 > 5)
            {
                int end = (topNums.Count - 1) - 5;
                for (int i = 0; i <= end; i++)
                {
                    topNums.RemoveAt(topNums.Count - 1);
                }
            }

            Console.WriteLine(string.Join(" ", topNums));

        }
    }
}
