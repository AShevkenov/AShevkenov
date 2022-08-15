using System;
using System.Text.RegularExpressions;
using System.Linq;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        string input = Console.ReadLine();
        string regex = @"([@#])(?<first>[A-Za-z]{3,})\1\1(?<second>[A-Za-z]{3,})\1";
        MatchCollection matches = Regex.Matches(input, regex);
        var results = new Dictionary<string, string>();

        foreach (Match match in matches)
        {

            string first = match.Groups["first"].Value;
            string second = match.Groups["second"].Value;
            string secondReversed = string.Join("", second.ToCharArray().Reverse().ToArray());
            if (first == secondReversed)
                results.Add(first, second);
        }

        if (matches.Count == 0)
            Console.WriteLine("No word pairs found!");
        else
            Console.WriteLine($"{matches.Count} word pairs found!");

        if (results.Count == 0)
            Console.WriteLine("No mirror words!");
        else
        {
            Console.WriteLine("The mirror words are:");
            Console.WriteLine(String.Join(", ", results.Select(x => $"{x.Key} <=> {x.Value}")));
        }
    }
}