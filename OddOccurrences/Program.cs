using System;
using System.Collections.Generic;

namespace OddOccurrences
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> counts = new Dictionary<string, int>();

            string[] words = Console.ReadLine()
                .Split();
                

            foreach (var word in words)
            {
                string wordLowCase = word.ToLower();
                if(counts.ContainsKey(wordLowCase))
                {
                    counts[wordLowCase]++;
                }
                else
                {
                    counts.Add(wordLowCase, 1);
                }
            }
            foreach (var count in counts)
            {
                if(count.Value % 2 == 1)
                {
                    Console.Write(count.Key + " ");
                }
            }
        }
    }
}
