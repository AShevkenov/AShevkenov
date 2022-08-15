using System;
using System.Collections.Generic;

namespace Ranking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string inputOne = Console.ReadLine();
            string[] contestsAndPasswords = inputOne.Split(':');
            Dictionary<string, string> rankings = new Dictionary<string, string>();

            while (inputOne != "end of contests")
            {
                rankings[contestsAndPasswords[0]] = contestsAndPasswords[1];

                inputOne = Console.ReadLine();
                contestsAndPasswords = inputOne.Split(':');
            }

            string inputTwo = Console.ReadLine();
            string[] userPoints = inputTwo.Split("=>");

            List<string> students = new List<string>();

            while (inputTwo != "end of submissions")
            {
                if (rankings.ContainsKey(userPoints[0]) && rankings.ContainsValue(userPoints[1]))
                {
                    Student student = new Student
                    {
                        Contest = userPoints[0],
                        Password = userPoints[1],
                        UserName = userPoints[2],
                        Points = userPoints[3]

                    };  
                }

                

                inputTwo = Console.ReadLine();
                userPoints = inputTwo.Split("=>");
            }
        }

        class Student
        {
            public string Contest { get; set; }
            public string Password { get; set; }
            public string UserName { get; set; }
            public string Points { get; set; }
        }
    }
}
