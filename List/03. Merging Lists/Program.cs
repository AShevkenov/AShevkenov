using System;
using System.Collections.Generic;
using System.Linq;


namespace _03._Merging_Lists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> firtsList = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> secondList = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> mergedList = new List<int>();

            int biggerCount = Math.Max(firtsList.Count, secondList.Count);

            for (int i = 0; i < biggerCount; i++)
            {
                if (firtsList.Count > i)
                {
                    mergedList.Add(firtsList[i]);
                }
                if (secondList.Count > i)
                {
                    mergedList.Add(secondList[i]);
                }
            }

            Console.WriteLine(string.Join(" ", mergedList));
        }
    }
}
