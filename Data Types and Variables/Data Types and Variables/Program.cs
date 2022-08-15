using System;

namespace Data_Types_and_Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double firstNum = double.Parse(Console.ReadLine());
            double secondNum = double.Parse(Console.ReadLine());
            double thirdNum = double.Parse(Console.ReadLine());
            double fourthNum = double.Parse(Console.ReadLine());

            double sum = firstNum + secondNum;
            int divide = (int)(sum / thirdNum);
            double multiply = divide * fourthNum;

            Console.WriteLine(multiply);



        }
    }
}
