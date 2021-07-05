using System;
using System.Collections.Generic;
using System.Linq;

namespace LegendaryFarming1
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> legendaryItem = new Dictionary<string, int>
            {
                {"shards", 0},
                {"fragments", 0},
                {"motes", 0}
            };


            SortedDictionary<string, int> junk = new SortedDictionary<string, int>();
            bool isRuning = true;
            string winneritem = string.Empty;

            while (isRuning)
            {
                string[] parts = Console.ReadLine().Split();

                for (int i = 0; i < parts.Length; i+=2)
                {
                    int quontyty = int.Parse(parts[i]);
                    string item = parts[i + 1].ToLower();

                    if(legendaryItem.ContainsKey(item))
                    {
                        legendaryItem[item] += quontyty;
                        if(legendaryItem[item] >= 250)
                        {
                            winneritem = item;
                            legendaryItem[item] -= 250;
                            isRuning = false;
                            break;
                        }
                    }
                    else
                    {
                        if(junk.ContainsKey(item))
                        {
                            junk[item] += quontyty;
                        }
                        else
                        {
                            junk.Add(item, quontyty);
                        }
                    }
                }
            }
            if (winneritem == "shards")
            {
                Console.WriteLine("Shadowmourne obtained!");
            }
            else if (winneritem == "fragments")
            {
                Console.WriteLine("Valanyr obtained!");
            }
            else
            {
                Console.WriteLine("Dragonwrath obtained!");
            }

            Dictionary<string, int> sortedLegendItems = legendaryItem
                .OrderByDescending(i => i.Value)
                .ThenBy(i => i.Key)
                .ToDictionary(x => x.Key, x => x.Value);

            foreach (var kvp in sortedLegendItems)
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value}");
            }



            foreach (var kvp in junk)
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value}");
            }
        }
    }
}
