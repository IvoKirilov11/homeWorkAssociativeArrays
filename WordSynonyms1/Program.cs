using System;
using System.Collections.Generic;

namespace WordSynonyms1
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> words = new Dictionary<string, List<string>>();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string word = Console.ReadLine();
                string sinonims = Console.ReadLine();

                if(words.ContainsKey(word))
                {
                    words[word].Add(sinonims);
                }
                else
                {
                    words.Add(word, new List<string> { sinonims });
                }
            }
            foreach (var word in words)
            {
                Console.WriteLine($"{word.Key} - {string.Join(", ",word.Value)}");
            }
        }
    }
}
