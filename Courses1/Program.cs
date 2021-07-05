﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace Courses1
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> studentsByCourse = new Dictionary<string, List<string>>();

            while (true)
            {
                string line = Console.ReadLine();

                if(line == "end")
                {
                    break;
                }

                string[] parts = line.Split(" : ", StringSplitOptions.RemoveEmptyEntries);
                string courese = parts[0];
                string student = parts[1];

                if(!studentsByCourse.ContainsKey(courese))
                {
                    studentsByCourse.Add(courese, new List<string>());
                }
                studentsByCourse[courese].Add(student);
            }

            Dictionary<string, List<string>> sortedCourses = studentsByCourse
                .OrderByDescending(s => s.Value.Count)
                .ToDictionary(x => x.Key, x => x.Value);

            foreach (var kvp in sortedCourses)
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value.Count}");

                kvp.Value.Sort();
                foreach (var student in kvp.Value)
                {
                    Console.WriteLine($"-- {student}");
                }
            }
        }
    }
}
