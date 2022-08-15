using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Randomize_Words
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string concealedmsg = Console.ReadLine();
            string commands = Console.ReadLine();

            while (commands != "Reveal")
            {
                string[] tokens = commands.Split(":|:");

                switch (tokens[0])
                {
                    case "ChangeAll":
                        {
                            string substring = tokens[1];
                            string replacement = tokens[2];
                            concealedmsg = concealedmsg.Replace(substring, replacement);
                            break;
                        }

                    case "Reverse":
                        {
                            string substring = tokens[1];
                            if (concealedmsg.Contains(substring))
                            {
                                int index = concealedmsg.IndexOf(substring);
                                concealedmsg = concealedmsg.Remove(index, substring.Length);                              
                                concealedmsg = concealedmsg + string.Join("", substring.Reverse());
                            }
                            else
                            {
                                Console.WriteLine("error");
                                commands = Console.ReadLine();
                                continue;
                            }
                            break;
                        }

                    case "InsertSpace":
                        {
                            int index = int.Parse(tokens[1]);
                            concealedmsg = concealedmsg.Insert(index, " ");
                        }
                        break;
                }

                Console.WriteLine(concealedmsg);
                commands = Console.ReadLine();
            }

            Console.WriteLine($"You have a new text message: {concealedmsg}");
        }



    }

}
