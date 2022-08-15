using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Text_Processing_Exercises
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] userNames = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).ToArray();

            List<string> validUserNames = new List<string>();

            foreach (var userName in userNames)
            {
                if (userName.Length >= 3 && userName.Length <= 16)
                {
                    bool isValid = true;
                    for (int i = 0; i < userName.Length; i++)
                    {
                        char currentChar = userName[i];

                        if (!(currentChar == '-' || currentChar == '_' || char.IsLetterOrDigit(currentChar)))
                        {
                            isValid = false;
                            break;
                        }

                    }

                    if (isValid)
                    {
                        validUserNames.Add(userName);
                    }
                }
            }

            Console.WriteLine(String.Join(Environment.NewLine, validUserNames));
        }
    }
}
