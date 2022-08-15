using System;
using System.Collections.Generic;
using System.Linq;

namespace Shoot_for_the_Win
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // НЕ Е РЕШЕНА!!!

            List<int> targets = Console.ReadLine().Split().Select(int.Parse).ToList();

            List<string> command = Console.ReadLine().Split().ToList();

            string action = command[0];


            List<int> newTargets = targets;

            while (action != "End")
            {
                
                int goal = int.Parse(command[1]);
                int temp = targets[goal];

                for (int i = 0; i < targets.Count; i++)
                {
                    if (targets[goal] > targets[i])
                    {
                        targets[i] += temp;
                    }
                    else
                    {
                        targets[i] -= temp;
                    }
                }

                newTargets[goal] = -1;
                targets = newTargets;

                command = Console.ReadLine().Split().ToList();
                action = command[0];

            }

            Console.WriteLine(String.Join(", ", newTargets));
        }
    }
}
