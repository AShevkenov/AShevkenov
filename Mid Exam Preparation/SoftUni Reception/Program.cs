using System;

namespace SoftUni_Reception
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstEmployee  = int.Parse(Console.ReadLine());
            int secondEmployee = int.Parse(Console.ReadLine());
            int thirdEmployee  = int.Parse(Console.ReadLine());
            int students = int.Parse(Console.ReadLine());

            int totalEmployeePerHour = firstEmployee + secondEmployee + thirdEmployee;
            int hour = 0;
            int timeForABreak = 0;

            while (students > 0)
            {
                hour++;
                timeForABreak++;
                students -= totalEmployeePerHour;
                if (students <= 0)
                { break; }
                if (timeForABreak % 3 == 0)
                {
                    timeForABreak = 0;
                    hour++;
                }

            }

            Console.WriteLine($"Time needed: {hour}h.");

        }
        
        
    }
}
