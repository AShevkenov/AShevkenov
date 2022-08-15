using System;
using System.Text.RegularExpressions;

namespace RegEx
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string input = Console.ReadLine();

            string pattern = @"\b[A-Z][a-z]+ [A-Z][a-z]+";

            Regex regex = new Regex(pattern);

            MatchCollection matches = regex.Matches(input);


            Console.WriteLine(string.Join(" ", matches));


        }
    }
}
