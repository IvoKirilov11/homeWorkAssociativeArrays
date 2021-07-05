using System;
using System.Collections.Generic;

namespace SoftUniParking1
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> users = new Dictionary<string, string>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] parts = Console.ReadLine().Split();

                string command = parts[0];
                if (command == "register")
                {
                    string username = parts[1];
                    string licensNumb = parts[2];

                    if(users.ContainsKey(username))
                    {
                        Console.WriteLine($"ERROR: already registered with plate number {licensNumb}");
                    }
                    else
                    {
                        users.Add(username, licensNumb);
                        Console.WriteLine($"{username} registered {licensNumb} successfully");
                    }
                }
                else
                {
                    string userName = parts[1];
                    bool removed = users.Remove(userName);

                    if (removed)
                    {
                        Console.WriteLine($"{userName} unregistered successfully");
                    }
                    else
                    {
                        Console.WriteLine($"ERROR: user {userName} not found");

                    }
                }
            }
            foreach (var user in users)
            {
                Console.WriteLine($"{user.Key} => {user.Value}");
            }
        }
    }
}
