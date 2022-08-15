using System;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace _05._Digits__Letters_and_Other
{
    internal class Program
    {
        static void Main(string[] args)
        {


            string input = Console.ReadLine();

            char[] digit = input.Where(ch => char.IsDigit(ch)).ToArray();
            char[] letters = input.Where(ch => char.IsLetter(ch)).ToArray();
            char[] others = input.Where(ch => !char.IsLetterOrDigit(ch)).ToArray();


            Console.WriteLine(digit);
            Console.WriteLine(letters);
            Console.WriteLine(others);

        }
    }
}
