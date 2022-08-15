using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._List_Manipulation_Basics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            int counterForExit = 0;

            while (true)
            {                             

                string command = Console.ReadLine();

                if (command == "end")
                {
                    break;
                }

                string[] tokens = command.Split();
                string action = tokens[0];

                switch (action)
                {
                    case "Add":
                        int numberToAdd = int.Parse(tokens[1]);
                        numbers.Add(numberToAdd);
                        counterForExit++;
                        break;
                    case "Remove":
                        int numberToRemove = int.Parse(tokens[1]);
                        numbers.Remove(numberToRemove);
                        counterForExit++;
                        break;
                    case "RemoveAt":
                        int indexToRemoveAt = int.Parse(tokens[1]);
                        numbers.RemoveAt(indexToRemoveAt);
                        counterForExit++;
                        break;
                    case "Insert":
                        int numberToInsert = int.Parse(tokens[1]);
                        int indexToInsert = int.Parse(tokens[2]);
                        numbers.Insert(indexToInsert, numberToInsert);
                        counterForExit++;
                        break;
                    case "Contains":
                        int isNumberContains = int.Parse(tokens[1]); //543
                        bool isValid = true;
                        for (int i = 0; i < numbers.Count; i++)
                        {
                            for (int j = 0; j < numbers.Count; j++)
                            {
                                if (isNumberContains == numbers[j])
                                {
                                    Console.WriteLine("Yes");
                                    isValid = false;
                                    break;
                                }
                            }
                            if (isValid)
                            {
                                Console.WriteLine("No such number");
                                break;
                            }
                            break;
                        }
                        break;
                    case "PrintEven":
                        for (int i = 0; i < numbers.Count; i++)
                        {
                            if (numbers[i] % 2 == 0)
                            {
                                Console.Write($"{numbers[i]} ");
                            }
                        }
                        Console.WriteLine();
                        break;
                    case "PrintOdd":
                        for (int i = 0; i < numbers.Count; i++)
                        {
                            if (numbers[i] % 2 != 0)
                            {
                                Console.Write($"{numbers[i]} ");
                            }
                        }
                        Console.WriteLine();
                        break;
                    case "GetSum":
                        int sum = 0;
                        foreach (var item in numbers)
                        {
                            sum += item;
                        }
                        Console.WriteLine(sum);
                        break;
                    case "Filter":
                        switch (tokens[1])
                        {
                            case "<":
                                for (int i = 0; i < numbers.Count; i++)
                                {
                                    if (numbers[i] < int.Parse(tokens[2]))
                                    {
                                        Console.Write($"{numbers[i]} ");
                                    }
                                }
                                Console.WriteLine();
                                break;
                            case ">":
                                for (int i = 0; i < numbers.Count; i++)
                                {
                                    if (numbers[i] > int.Parse(tokens[2]))
                                    {
                                        Console.Write($"{numbers[i]} ");
                                    }
                                }
                                Console.WriteLine();
                                break;
                            case ">=":
                                for (int i = 0; i < numbers.Count; i++)
                                {
                                    if (numbers[i] >= int.Parse(tokens[2]))
                                    {
                                        Console.Write($"{numbers[i]} ");
                                    }
                                }
                                Console.WriteLine();
                                break;
                            case "<=":
                                for (int i = 0; i < numbers.Count; i++)
                                {
                                    if (numbers[i] <= int.Parse(tokens[2]))
                                    {
                                        Console.Write($"{numbers[i]} ");
                                    }
                                }
                                Console.WriteLine();
                                break;
                        }
                        break;
                }
            }
            if (counterForExit > 0) { Console.WriteLine(string.Join(" ", numbers)); }
        }
    }
}
