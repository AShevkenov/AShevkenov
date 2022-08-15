using System;

namespace _03.Elevator
{
    internal class Program
    {
        static void Main(string[] args)
        {
          
            double ppl = double.Parse(Console.ReadLine()); // 15
            double capacity = double.Parse(Console.ReadLine()); // 3

            double courses = Math.Ceiling(ppl / capacity);

            Console.WriteLine(courses);

        }
    }
}
