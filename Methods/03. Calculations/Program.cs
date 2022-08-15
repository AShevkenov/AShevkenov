using System;

namespace _03._Calculations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            double numOne = double.Parse(Console.ReadLine());
            double numTwo = double.Parse(Console.ReadLine());
            double result = 0;
            switch (command)
            {
                case "add":
                    Add(numOne, numTwo);
                    break;
                case "multiply":
                    Multiply(numOne, numTwo);
                    break;
                case "subtract":
                    Subtract(numOne, numTwo);
                    break;
                case "divide":
                    Divide(numOne, numTwo);
                    break;
            }
        }
        static void Add(double numOne, double numTwo)
        {

            Console.WriteLine(numOne + numTwo);
        }
        static void Multiply(double numOne, double numTwo)
        {
            Console.WriteLine(numOne * numTwo);
        }
        static void Subtract(double numOne, double numTwo)
        {
            Console.WriteLine(numOne - numTwo);
        }
        static void Divide(double numOne, double numTwo)
        {
            Console.WriteLine(numOne / numTwo);
        }
    }
}
