using System;

namespace _03._Floating_Equality
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double firstNum = double.Parse(Console.ReadLine());
            double secondNum = double.Parse(Console.ReadLine());

            double result = Math.Abs(firstNum - secondNum);
           
            double eps = 0.000001;

            if (result < eps)
            {
                Console.WriteLine(true);
            }
            else if (result == eps)
            {
                Console.WriteLine(true);
            }
            else
            {
                Console.WriteLine(false);
            }

        }
    }
}
