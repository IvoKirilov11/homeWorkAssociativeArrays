using System;

namespace SecretChat
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string input = Console.ReadLine();

            while (input != "Reveal")
            {
                string[] tolkens = input.Split(":|:");
                string command = tolkens[0];

                if(command == "InsertSpace")
                {
                    int index = int.Parse(tolkens[1]);

                    text = text.Insert(index," ");
                    Console.WriteLine(text);
                }
                else if (command == "Reverse")
                {
                    string substring = tolkens[1];

                    if(text.Contains(substring))
                    {
                        string subsReverese = "";
                        int index = text.IndexOf(substring);

                        text = text.Remove(index, substring.Length);

                        for (int i = substring.Length - 1; i >= 0; i--)
                        {
                            subsReverese += substring[i];
                        }
                        text = text.Insert(index, subsReverese);

                        Console.WriteLine(text);
                    }
                }
            }
        }
    }
}
