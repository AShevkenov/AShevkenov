using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.The_Lift
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int waitingList = int.Parse(Console.ReadLine());
            List<int> state = Console.ReadLine().Split().Select(int.Parse).ToList();


            for (int i = 0; i < state.Count; i++)
            {
                for (int j = state[i]; j < 4; j++)
                {
                    state[i]++;
                    waitingList--;

                    if (waitingList == 0)
                    {
                        if (state.Sum() < state.Count * 4)
                        {
                            Console.WriteLine("The lift has empty spots!");
                        }

                        Console.Write(string.Join(' ', state));

                        return;

                    }

                }
            }

            Console.WriteLine($"There isn't enough space! {waitingList} people in a queue!");
            Console.WriteLine(String.Join(' ', state));
        }
    }
}
