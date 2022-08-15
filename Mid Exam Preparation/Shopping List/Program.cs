using System;
using System.Collections.Generic;
using System.Linq;

namespace Shopping_List
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<string> shoppingList = Console.ReadLine().Split('!').ToList();

            List<string> command = Console.ReadLine().Split().ToList();

            string action = Convert.ToString(command);
            string itemTwo = string.Empty;

            while (command[0] != "Go")
            {
                string tokens = command[0];
                string item = command[1];


                switch (tokens)
                {
                    case "Urgent":
                        if (shoppingList.Contains(item))
                        {
                            command = Console.ReadLine().Split().ToList();
                            continue;
                        }
                        if (shoppingList[0] == item)
                        {
                            command = Console.ReadLine().Split().ToList();
                            continue;
                        }
                        else
                        {
                            shoppingList.Insert(0, item);
                            for (int i = 0; i < shoppingList.Count; i++)
                            {
                                if (item == shoppingList[i + 1])
                                {
                                    shoppingList.RemoveAt(i + 1);
                                    command = Console.ReadLine().Split().ToList();
                                    break;
                                }
                            }
                        }
                        break;

                    case "Unnecessary":
                        if (!shoppingList.Contains(item))
                        {
                            command = Console.ReadLine().Split().ToList();
                            continue;
                        }
                        shoppingList.Remove(item);
                        break;

                    case "Correct":
                        Correct(shoppingList, tokens, item, itemTwo, command);
                        break;
                    case "Rearrange":
                        if (shoppingList.Contains(item))
                        {
                            shoppingList.Remove(item);
                            shoppingList.Add(item);
                        }
                        break;
                }
                command = Console.ReadLine().Split().ToList();
            }

            Console.WriteLine(string.Join(", ", shoppingList));
        }

        private static void Correct(List<string> shoppingList, string tokens, string item, string itemTwo, List<string> command)
        {

            itemTwo = command[2];
            if (shoppingList.Contains(item))
            {
                shoppingList.Insert(shoppingList.IndexOf(item), itemTwo);
                shoppingList.Remove(item);

            }

        }
    }
}

