﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Race
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Regex patternForName = new Regex(@"(?<name>[A-Za-z])");
            string patternForDigits = @"(?<digits>\d+)";

            int sumOfDigits = 0;

            Dictionary<string, int> participans = new Dictionary<string, int>();

            var name = Console.ReadLine().Split(", ").ToList();

            string input = Console.ReadLine();

            while (input != "end of race")
            {
                MatchCollection matchedNames = patternForName.Matches(input);
                MatchCollection matchedDigits = Regex.Matches(input, patternForDigits);

                string currName = string.Join("", matchedNames);
                string currDigit = string.Join("", matchedDigits);

                sumOfDigits = 0;

                for (int i = 0; i < currDigit.Length; i++)
                {
                    sumOfDigits += int.Parse(currDigit[i].ToString());
                }

                if (name.Contains(currName))
                {

                    if (!participans.ContainsKey(currName))
                    {
                        participans.Add(currName, sumOfDigits);
                    }
                    else
                    {
                        participans[currName] += sumOfDigits;
                    }
                }

                input = Console.ReadLine();
            }

            var winners = participans.OrderByDescending(x => x.Value).Take(3);

            var firstPlace = winners.Take(1);
            var secondPlace = winners.OrderByDescending(x => x.Value).Take(2).OrderBy(x => x.Value).Take(1);
            var thirdPlace = winners.OrderBy(x => x.Value).Take(1);

            foreach (var firstName in firstPlace)
            {
                Console.WriteLine($"1st place: {firstName.Key}");
            }

            foreach (var secondName in secondPlace)
            {
                Console.WriteLine($"2nd place: {secondName.Key}");
            }

            foreach (var thirdName in thirdPlace)
            {
                Console.WriteLine($"3rd place: {thirdName.Key}");
            }
        }
    }
}
