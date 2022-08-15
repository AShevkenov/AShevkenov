using System;

namespace DEMO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int count = 0;

            for (int i = 1; i <= n; i++)
            {
                string bracket = Console.ReadLine();

                if (bracket == "(")
                {
                    count++;
                }
                if (bracket == ")")
                {
                    count--;
                }
                if (count != 0 && count != 1)
                {
                    Console.WriteLine("UNBALANCED");
                    return;
                }
            }

            if (count == 0)
            {
                Console.WriteLine("BALANCED");
            }
            else
            {
                Console.WriteLine("UNBALANCED");
            }
        }
    }
}
