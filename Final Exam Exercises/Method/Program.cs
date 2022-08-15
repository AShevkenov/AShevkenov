using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Method
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int numberOfStrings = int.Parse(Console.ReadLine());
            string pattern = @"(!)(?<cmd>[A-Z][a-z]{3,})\1:\[(?<msg>[A-Za-z]{8,})\]";

            for (int i = 0; i < numberOfStrings; i++)
            {
                string input = Console.ReadLine();
                //MatchCollection matches = Regex.Matches(input, pattern);
                if (!Regex.IsMatch(input, pattern))
                {
                    Console.WriteLine($"The message is invalid");
                    
                }
                else
                {
                  
                    Match regex = Regex.Match(input, pattern);
                    string translatedString = regex.Groups["msg"].Value;

                    List<int> sum = new List<int>();

                    
                    for (int j = 0; j < translatedString.Length; j++)
                    {
                        int currSum = 0;
                        currSum = translatedString[j];
                        sum.Add(currSum);

                    }
                        Console.WriteLine($"{regex.Groups["cmd"].Value}: {string.Join(" ", sum)}");
          
                }
            }
        }

    }
}