using System;

namespace Mid_Exam_Preparation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //•	On the first line – quantity food in kilograms - a floating - point number in the range[0.0…10000.0].
            //•	On the second line – quantity hay in kilograms - a floating - point number in the range[0.0…10000.0].
            //•	On the third line – quantity cover in kilograms - a floating - point number in the range[0.0…10000.0].
            //•	On the fourth line – guinea's weight in kilograms - a floating-point number in the range [0.0…10000.0].

            double food = double.Parse(Console.ReadLine()) * 1000;
            double hay = double.Parse(Console.ReadLine()) * 1000;
            double cover = double.Parse(Console.ReadLine()) * 1000;
            double weight = double.Parse(Console.ReadLine()) * 1000;

            for (int i = 1; i <= 30; i++)
            {
                food -= 300;
                if (i % 2 == 0)
                {
                    hay -= 0.05 * food;
                }
                if (i % 3 == 0)
                {
                    cover -= weight / 3;
                }
                if (food <= 0 || hay <= 0 || cover <= 0)
                {
                    Console.WriteLine("Merry must go to the pet store!");

                    return;
                }
            }

            food /= 1000;
            hay /= 1000;
            cover /= 1000;

            Console.WriteLine($"Everything is fine! Puppy is happy! Food: {food:f2}, Hay: {hay:f2}, Cover: {cover:f2}.");

        }
    }
}
