using System;

namespace Black_Flag
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //•	On the 1st line, you will receive the days of the plunder – an integer number in the range[0…100000]
            //•	On the 2nd line, you will receive the daily plunder – an integer number in the range[0…50]
            //•	On the 3rd line, you will receive the expected plunder – a real number in the range[0.0…10000.0]

            double plunderDays = double.Parse(Console.ReadLine()); // 5 
            double dailyPlunder = double.Parse(Console.ReadLine()); // 40
            double expectPlunder = double.Parse(Console.ReadLine()); // 100

            double
                totalPlunder = 0;
            double
                plunderBonusCounter = 0;
            double
                plunderLostCounter = 0;

            for (int i = 0; i < plunderDays; i++)
            {
                totalPlunder += dailyPlunder;
                plunderBonusCounter++;
                plunderLostCounter++;

                if (plunderBonusCounter % 3 == 0)
                {
                    totalPlunder += dailyPlunder / 2;
                    plunderBonusCounter = 0;
                }
                if (plunderLostCounter % 5 == 0)
                {
                    totalPlunder *= 0.7;
                    plunderLostCounter = 0;
                }
            }

            if (totalPlunder >= expectPlunder)
            {
                Console.WriteLine($"Ahoy! {totalPlunder:f2} plunder gained.");
            }
            else
            {

                Console.WriteLine($"Collected only {((totalPlunder / expectPlunder) * 100):f2}% of the plunder.");
            }
        }
    }
}
