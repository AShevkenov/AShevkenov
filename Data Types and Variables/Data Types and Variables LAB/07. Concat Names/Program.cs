using System;

namespace _07._Concat_Names
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Console.OutputEncoding = System.Text.Encoding.UTF8;

            string firstName = Console.ReadLine();
            string lastName = Console.ReadLine();
            string delimiter = Console.ReadLine();


            Console.WriteLine($"{firstName}{delimiter}{lastName}");


        }
    }
}
