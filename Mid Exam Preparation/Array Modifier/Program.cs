using System;
using System.Linq;

namespace Array_Modifier
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            string command = Console.ReadLine();

            while (command != "end")
            {
                string[] tokens = command.Split();
                string action = tokens[0];

                switch (action)
                {
                    case "swap":
                        int tempNum = numbers[int.Parse(tokens[1])]; 
                        numbers[int.Parse(tokens[1])] = numbers[int.Parse(tokens[2])]; 
                        numbers[int.Parse(tokens[2])] = tempNum;
                        break;
                    case "multiply":
                        numbers[int.Parse(tokens[1])] = numbers[int.Parse(tokens[1])] * numbers[int.Parse(tokens[2])];
                        break;

                }
                
                if (command == "decrease" || tokens[0] == "decrease")
                {                                    
                        for (int i = 0; i < numbers.Length; i++)
                    {
                        numbers[i] = numbers[i] - 1;                    
                    }
                    command = Console.ReadLine();
                    continue;
                }

                command = Console.ReadLine();
            }

            Console.WriteLine(string.Join(", ", numbers));
        }
    }
}
