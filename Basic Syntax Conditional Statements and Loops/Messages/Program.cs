using System;

namespace Messages
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            string output = string.Empty;

            for (int i = 1; i <= input; i++)
            {
                string number = Console.ReadLine();

                int lengthNumber = number.Length;

                int digit = int.Parse(Convert.ToString(number[0]));
                int index = (digit - 2) * 3;

                if (digit == 0)
                {
                    output += (char)(digit + 32);
                    continue;
                }
                if (digit == 8 || digit == 9)
                {
                    index++;
                }
                int letter = index + lengthNumber - 1;
                output += (char)(letter + 97);
            }
            Console.WriteLine(output);
        }
    }
}