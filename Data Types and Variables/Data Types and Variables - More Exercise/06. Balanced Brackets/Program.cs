using System;

namespace _06._Balanced_Brackets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string characters = String.Empty;

            int counter = 0;

            for (int i = 1; i <= n; i++)
            {
                characters = Console.ReadLine();
                
                if (counter == 0 && characters == ")")
                {
                    Console.WriteLine("UNBALANCED");
                    return;
                }
                if (characters == "(")
                {
                    counter++;
                }
                else if (characters == ")")
                {
                    counter--;
                }
            }
            if (counter == 0)
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
