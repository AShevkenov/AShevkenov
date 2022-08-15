﻿using System;

namespace Objects_and_Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split();

            Random random = new Random();

            for (int i = 0; i < words.Length; i++)
            {
                int randomIndex = random.Next(i, words.Length);

                string currentWord = words[i];
                words[i] = words[randomIndex];
                words[randomIndex] = currentWord;
            }

            foreach (var word in words)
            {
                Console.WriteLine(word);
            }

            
        }
    }

}
