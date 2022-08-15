using System;
using System.Linq;

namespace Arrays___More_Exercises
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());
            double sum = 0;
            double totalSum = 0;
            int sumVowels = 0;
            int sumConst = 0;

            double[] total = new double[lines];

            for (int i = 0; i < lines; i++)
            {
                totalSum = 0;
                string text = Console.ReadLine();

                for (int n = 0; n < text.Length; n++)
                {
                    if (text[n] == 'a' || text[n] == 'e' || text[n] == 'o' || text[n] == 'i' || text[n] == 'u')
                    {
                        sum = text[n] * text.Length;
                    }
                    else if (text[n] == 'A' || text[n] == 'E' || text[n] == 'O' || text[n] == 'I' || text[n] == 'U')
                    {
                        sum = text[n] * text.Length;
                    }
                    else
                    {
                        sum = text[n] / text.Length;
                    }

                    totalSum += sum;
                }

                total[i] = totalSum;

            }

            Array.Sort(total);

            foreach (var item in total)
            {
                Console.WriteLine(item);
            }

        }
    }
}
