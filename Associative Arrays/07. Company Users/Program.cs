using System;
using System.Collections.Generic;

namespace _07._Company_Users
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var companies = new Dictionary<string, List<string>>();

            string cmd = Console.ReadLine();

            while (cmd != "End")
            {
                string[] tokens = cmd.Split(" -> ", StringSplitOptions.RemoveEmptyEntries);
                var companyName = tokens[0];
                var employeeID = tokens[1];

                if (!companies.ContainsKey(companyName))
                {
                    companies[companyName] = new List<string>();
                }
                if (companies[companyName].Contains(employeeID))
                {
                    cmd = Console.ReadLine();
                    continue;
                }
                companies[companyName].Add(employeeID);

                cmd = Console.ReadLine();
            }

            foreach (var c in companies)
            {
                Console.WriteLine($"{c.Key}");

                foreach (var employeeId in c.Value)
                {
                    Console.WriteLine($"-- {employeeId}");
                }
            }
        }
    }
}
