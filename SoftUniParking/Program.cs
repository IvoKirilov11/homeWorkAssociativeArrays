using System;
using System.Collections.Generic;

namespace SoftUniParking
{
    class Program
    {
        static void Main()
        {
            Dictionary<string, string> users = new Dictionary<string, string>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] parts = Console.ReadLine().Split();

                string command = parts[0];
                 if(command == "register")
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
                    string username = parts[1];
                    bool removed = users.Remove(username);
                    if(removed)
                    {
                        Console.WriteLine($"{username} unregistered successfully");
                    }
                    else
                    {
                        Console.WriteLine($"ERROR: user {username} not found");
                        
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
