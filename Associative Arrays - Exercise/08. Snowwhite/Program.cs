using System;
using System.Collections.Generic;
using System.Linq;

namespace _08._Snowwhite
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var dwarfs = new Dictionary<string, int>();

            string cmd = Console.ReadLine();


            while (cmd != "Once upon a time")
            {
                string[] tokens = cmd.Split(" <:> ", StringSplitOptions.RemoveEmptyEntries);

                var dwarfName = tokens[0];
                var hatColor = tokens[1];
                var phisycs = int.Parse(tokens[2]);
                var dwarfId = $"{dwarfName}:{hatColor}";
                if (!dwarfs.ContainsKey(dwarfId))
                {
                    dwarfs.Add(dwarfId, phisycs);
                }
                else
                {
                    dwarfs[dwarfId] = Math.Max(dwarfs[dwarfId], phisycs);
                }

                cmd = Console.ReadLine();
            }

            foreach (var dwarf in dwarfs.OrderByDescending(x => x.Value).ThenByDescending(currDwarf => dwarfs.Where(hatColor => hatColor.Key.Split(":")[1] == currDwarf.Key.Split(":")[1]).Count()))
            {
                string hatColor = dwarf.Key.Split(":")[1];
                string dwarfName = dwarf.Key.Split(":")[0];
                int dwarfPhisycs = dwarf.Value;
                Console.WriteLine($"({hatColor}) {dwarfName} <-> {dwarfPhisycs}");
            }
        }
    }
}
