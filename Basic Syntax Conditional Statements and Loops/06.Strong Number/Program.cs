using System;

namespace _06.Strong_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int numCopy = num;
            int sum = 0;
            
            while (num > 0) //145
            {
                int factorialNum = 1; //1
                int currentNum = num % 10; // 5
                num = num / 10; //14

                for (int i = 2; i <= currentNum; i++)
                {
                    factorialNum *= i;
                }

                sum += factorialNum;
            }

            Console.WriteLine(sum == numCopy ? "yes" : "no ");


        }
    }
}
