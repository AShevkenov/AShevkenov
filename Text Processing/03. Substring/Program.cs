﻿using System;

namespace _03._Substring
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string firstString = Console.ReadLine();
            string secondString = Console.ReadLine();

            while (secondString.Contains(firstString))
            {
                int startIndex = secondString.IndexOf(firstString);

                secondString = secondString.Remove(startIndex, firstString.Length);
                
            }

            Console.WriteLine(secondString);
        }
    }
}
