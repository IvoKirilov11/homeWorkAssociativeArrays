using System;
using System.Collections.Generic;

namespace OddOccurrences1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine()
                .Split();

            Dictionary<string, int> counts = new Dictionary<string, int>();

            foreach (var word in words)
            {
                string wordInLowerCase = word.ToLower();

                if(counts.ContainsKey(wordInLowerCase))
                {
                    counts[wordInLowerCase]++;
                }
                else
                {
                    counts.Add(wordInLowerCase, 1);
                }
            }
            foreach (var word in counts)
            {
                if(word.Value % 2 == 1)
                {
                    Console.Write(word.Key + " ");
                }
            }
               
        }
    }
}
