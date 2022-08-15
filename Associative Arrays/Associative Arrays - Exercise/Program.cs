using System;
using System.Collections.Generic;
using System.Linq;

namespace Count_Real_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Dictionary<char, int> countChar = new Dictionary<char, int>();

            //List<string> input = Console.ReadLine().Split().ToList();

            //for (int n = 0; n < input.Count; n++)
            //{
            //    string word = input[n]; 

            //    for (int i = 0; i < word.Length; i++)
            //    {
            //        char key = word[i];

            //        if (!countChar.ContainsKey(key))
            //        {
            //            countChar.Add(key, 0);
            //        }

            //        countChar[key]++;
            //    }

            //}
            //foreach (var item in countChar)
            //{
            //    Console.WriteLine($"{item.Key} -> {item.Value}");
            //}

            char[] word = Console.ReadLine().ToCharArray();
            Dictionary<char, int> letters = new Dictionary<char, int>();

            foreach (var letter in word)
            {
                if (letter != ' ')
                {
                    if (!letters.ContainsKey(letter))
                    {
                        letters[letter] = 0;
                    }

                    letters[letter]++;
                }
            }

            foreach (var kvpLetter in letters)
            {
                Console.WriteLine($"{kvpLetter.Key} -> {kvpLetter.Value}");
            }
        }
    }
}
