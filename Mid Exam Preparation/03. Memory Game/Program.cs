using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Memory_Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> elements = Console.ReadLine().Split().ToList();

            string[] command = Console.ReadLine().Split().ToArray();

            int moves = 0;

            while (command[0] != "end")
            {

                moves++;

                int tokenOne = int.Parse(command[0]);
                int tokenTwo = int.Parse(command[1]);

                if (tokenOne == tokenTwo || tokenOne > elements.Count - 1 || tokenOne < 0 || tokenTwo > elements.Count - 1 || tokenTwo < 0)
                {
                    elements.Insert(((elements.Count) / 2), $"{-moves}a");
                    elements.Insert(((elements.Count) / 2), $"{-moves}a");
                    Console.WriteLine("Invalid input! Adding additional elements to the board");
                    command = Console.ReadLine().Split().ToArray();

                }
                else
                {
                    if (elements[tokenOne] == elements[tokenTwo])
                    {

                        Console.WriteLine($"Congrats! You have found matching elements - {elements[tokenOne]}!");
                        string temp = elements[tokenOne];
                        elements.Remove(temp);
                        elements.Remove(temp);
                        command = Console.ReadLine().Split().ToArray();

                    }
                    else
                    {
                        Console.WriteLine("Try again!");
                        command = Console.ReadLine().Split().ToArray();

                    }
                    if (elements.Count == 0)
                    {
                        Console.WriteLine($"You have won in {moves} turns!");
                        return;
                    }
                }

            }


            Console.WriteLine("Sorry you lose :(");
            Console.WriteLine(string.Join(" ", elements));

        }
    }
}

