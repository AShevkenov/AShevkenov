﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace Pianist
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfPieces = int.Parse(Console.ReadLine());

            Dictionary<string, KeyValuePair<string, string>> music = new Dictionary<string, KeyValuePair<string, string>>();

            List<string> order = new List<string>();

            for (int i = 0; i < numberOfPieces; i++)
            {
                var pieceInfo = Console.ReadLine().Split('|', StringSplitOptions.RemoveEmptyEntries);

                string piece = pieceInfo[0];
                string composer = pieceInfo[1]; 
                string key = pieceInfo[2];

                if (!music.ContainsKey(piece))
                {
                    music.Add(piece, new KeyValuePair<string, string>(composer, key));
                    order.Add(piece);
                }
            }

            string play = Console.ReadLine();

            while (play != "Stop")
            {

                string[] commands = play.Split('|');
                string piece = commands[1];

                switch (commands[0])
                {
                    case "Add":
                        {
                            string composer = commands[2];
                            string key = commands[3];

                            if (!music.ContainsKey(piece))
                            {
                                music.Add(piece, new KeyValuePair<string, string>(composer, key));
                                Console.WriteLine($"{piece} by {composer} in {key} added to the collection!");
                                order.Add(piece);
                            }
                            else
                            {
                                Console.WriteLine($"{piece} is already in the collection!");
                            }
                            break;
                        }
                    case "Remove":
                        {
                            if (music.ContainsKey(piece))
                            {
                                music.Remove(piece);
                                Console.WriteLine($"Successfully removed {piece}!");
                                order.Remove(piece);
                            }
                            else
                            {
                                Console.WriteLine($"Invalid operation! {piece} does not exist in the collection.");
                            }
                            break;
                        }

                    case "ChangeKey":
                        {
                            string newKey = commands[2];
                            if (music.ContainsKey(piece))
                            {
                                var pieceData = music[piece];
                                var composer = pieceData.Key;
                                music[piece] = new KeyValuePair<string, string>(composer, newKey);
                                Console.WriteLine($"Changed the key of {piece} to {newKey}!");
                            }
                            else
                            {
                                Console.WriteLine($"Invalid operation! {piece} does not exist in the collection.");
                            }
                            break;
                        }


                }

                play = Console.ReadLine();
            }

            foreach (var item in order)
            {
                Console.WriteLine($"{item} -> Composer: {music[item].Key}, Key: {music[item].Value}");
            }
        }
    }
}
