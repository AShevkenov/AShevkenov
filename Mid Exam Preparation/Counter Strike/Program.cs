using System;

namespace Counter_Strike
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int energy = int.Parse(Console.ReadLine());
            string distance = Console.ReadLine();

            int win = 0;

            while (distance != "End of battle")
            {
                energy -= Convert.ToInt32(distance);

                if (energy >= 0)
                {
                    win++;
                    if (win % 3 == 0)
                    {
                        energy += win;
                    }
                }
                else
                {
                    energy += Convert.ToInt32(distance);
                    Console.WriteLine($"Not enough energy! Game ends with {win} won battles and {energy} energy");
                    return;
                }

                distance = Console.ReadLine();
            }

            Console.WriteLine($"Won battles: {win}. Energy left: {energy}");
        }
    }
}
