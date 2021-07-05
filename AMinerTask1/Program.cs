using System;
using System.Collections.Generic;

namespace AMinerTask1
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> quantytyByResorce = new Dictionary<string, int>();

            while (true)
            {
                string line = Console.ReadLine();

                if(line == "stop")
                {
                    break;
                }

                int quantyty = int.Parse(Console.ReadLine());
                if(quantytyByResorce.ContainsKey(line))
                {
                    quantytyByResorce[line] += quantyty;
                }
                else
                {
                    quantytyByResorce.Add(line, quantyty);
                }
            }
            foreach (var item in quantytyByResorce)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
