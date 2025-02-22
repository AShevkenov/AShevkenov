﻿using System;

namespace _12._Refactor_Special_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());

            for (int i = 1; i <= count; i++)
            {
                int sum = 0;
                int digits = i;

                while (digits != 0)
                {
                    sum += digits % 10;
                    digits = digits / 10;
                }
                if ((sum == 5) || (sum == 7) || (sum == 11))
                {
                    Console.WriteLine($"{i} -> True");
                }
                else
                {
                    Console.WriteLine($"{i} -> False");
                }

            }

        }
    }
}
