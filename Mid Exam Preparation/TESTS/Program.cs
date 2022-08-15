using System;
using System.Collections.Generic;
using System.Linq;

internal class Program
{
    static List<string> numbers = new List<string>();
    static int moves = 0;
    static void Main()
    {
        numbers = Console.ReadLine().Split().ToList();
        string[] input = Console.ReadLine().Split().ToArray();

        while (input[0] != "end")
        {
            if (numbers.Count == 0)
                Console.WriteLine($"You have won in {moves} turns!");
            else
            {
                moves++;
                int index1 = int.Parse(input[0]);
                int index2 = int.Parse(input[1]);

                if (index1 == index2 || index1 < 0 || index1 >= numbers.Count || index2 < 0 || index2 >= numbers.Count)
                    WrongInputCase();
                else
                    CorrectInputCase(index1, index2);
            }

            input = Console.ReadLine().Split().ToArray();
        }

        if (numbers.Count > 0)
        {
            Console.WriteLine("Sorry you lose :(");
            Console.WriteLine(String.Join(" ", numbers));
        }
    }

    static void WrongInputCase()
    {
        Console.WriteLine("Invalid input! Adding additional elements to the board");
        int middleOfList = numbers.Count / 2;
        numbers.Insert(middleOfList, "-" + moves + "a");
        numbers.Insert(middleOfList, "-" + moves + "a");
    }

    static void CorrectInputCase(int index1, int index2)
    {
        if (numbers[index1] == numbers[index2])
        {
            int firstIndex = Math.Min(index1, index2);
            int secondIndex = Math.Max(index1, index2);

            Console.WriteLine($"Congrats! You have found matching elements - {numbers[index1]}!");
            numbers.RemoveAt(firstIndex);
            numbers.RemoveAt(secondIndex - 1);
        }
        else
        {
            Console.WriteLine("Try again!");
        }
    }
}