using System;

namespace _05._Login
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();
            string password = "";
            int wrongPass = 0;

            for (int i = username.Length - 1; i >= 0; i--)
            {
                password += username[i];
            }
            string userPass = Console.ReadLine();
            if (password == userPass)
            {
                Console.WriteLine($"User {username} logged in.");
            }
            while (password != userPass)
            {
                wrongPass++;
                if (wrongPass >= 4)
                {
                    Console.WriteLine($"User {username} blocked!");
                    return;
                }
                else if (wrongPass < 4)
                {
                    Console.WriteLine($"Incorrect password. Try again.");
                }
                userPass = Console.ReadLine();
                if (password == userPass)
                    Console.WriteLine($"User {username} logged in.");
            }
        }
    }
}
