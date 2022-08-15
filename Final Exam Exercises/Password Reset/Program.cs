using System;
using System.Text;
using System.Text.RegularExpressions;

namespace PasswordReset_ExamApril2020
{
    class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();
            StringBuilder newPassword = new StringBuilder();
            while (true)
            {
                string[] cmd = Console.ReadLine().Split();

                if (cmd[0] == "Done")
                {
                    break;
                }

                switch (cmd[0])
                {
                    case "TakeOdd":

                        for (int i = 1; i < password.Length; i += 2)
                        {
                            newPassword.Append(password[i]);
                        }
                        password = newPassword.ToString();
                        Console.WriteLine(password);

                        break;

                    case "Cut":

                        int index = int.Parse(cmd[1]);
                        int length = int.Parse(cmd[2]);

                        password = password.Remove(index, length);
                        Console.WriteLine(password);

                        break;

                    case "Substitute":

                        if (password.Contains(cmd[1]))
                        {
                            password = password.Replace(cmd[1], cmd[2]);
                            Console.WriteLine(password);
                        }
                        else
                        {
                            Console.WriteLine("Nothing to replace!");
                        }

                        break;
                }
            }

            Console.WriteLine($"Your password is: {password}");
        }

    }
}
