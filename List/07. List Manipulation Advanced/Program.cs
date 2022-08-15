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
                string input = Console.ReadLine();
                counterForExit = 0;

                if (input == "end")
                {
                    break;
                }

                string[] tokens = input.Split();
                string command = tokens[0];

                switch (command)
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
                        int numberContains = int.Parse(tokens[1]);
                        if (numbers.Contains(numberContains))
                        {
                            Console.WriteLine("Yes");
                        }
                        else
                        {
                            Console.WriteLine("No such number");
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

                        int sumOfAll = 0;
                        int lastNumber = 0;
                        foreach (var total in numbers)
                        {
                            sumOfAll += lastNumber;                             
                        }
                        Console.WriteLine(sumOfAll);
                        break;

                    case "Filter":
                        string condition = tokens[1];
                        int numberCondition = int.Parse(tokens[2]);
                        for (int i = 0; i < numbers.Count; i++)
                        {
                            switch (condition)
                            {

                                case "<":
                                    for (int j = 0; j < numbers.Count; j++)
                                    {
                                        if (numbers[j] < numberCondition)
                                            Console.Write($"{numbers[j]} ");
                                    }
                                    break;
                                case ">":
                                    for (int j = 0; j < numbers.Count; j++)
                                    {
                                        if (numbers[j] > numberCondition)
                                            Console.Write($"{numbers[j]} ");
                                    }
                                    break;
                                case ">=":
                                    for (int j = 0; j < numbers.Count; j++)
                                    {
                                        if (numbers[j] >= numberCondition)
                                            Console.Write($"{numbers[j]} ");
                                    }
                                    break;
                                case "<=":
                                    for (int j = 0; j < numbers.Count; j++)
                                    {
                                        if (numbers[j] <= numberCondition)
                                            Console.Write($"{numbers[j]} ");
                                    }
                                    break;
                            }                            
                            break;
                        }
                        Console.WriteLine();
                        break;
                }              
            }           
        }
    }
}
