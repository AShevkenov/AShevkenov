using System;
using System.Text;

namespace _05._Multiply_Big_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string x = Console.ReadLine();
            int z = int.Parse(Console.ReadLine());
            StringBuilder sb = new StringBuilder();
            int remainder = 0;

            if (z == 0)
            {
                Console.WriteLine(0);
                return;
            }

            for (int i = x.Length - 1; i >= 0; i--)
            {
                char lastNum = x[i];
                int lastNumAsDigit = int.Parse(lastNum.ToString());

                int result = lastNumAsDigit * z + remainder;

                sb.Append(result % 10);

                remainder = result / 10;
            }

            if (remainder > 0)
            {
                sb.Append(remainder);
            }

            for (int i = sb.Length - 1; i >= 0 ; i--)
            {
                Console.Write(sb[i]);
            }
        }
    }
}
