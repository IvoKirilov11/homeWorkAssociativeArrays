﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace CompanyUsers
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<string, List<string>> companies = new SortedDictionary<string, List<string>>();

            while (true)
            {
                string line = Console.ReadLine();

                if(line == "End")
                {
                    break;
                }
                string[] parts = line.Split(" -> ");

                string company = parts[0];
                string employID = parts[1];

                if(!companies.ContainsKey(company))
                {
                    companies.Add(company, new List<string>());
                }
                companies[company].Add(employID);
            }
            foreach (var company in companies)
            {
                Console.WriteLine(company.Key);
                List<string> uniqEmploy = company
                    .Value
                    .Distinct()
                    .ToList();

                foreach (var employ in uniqEmploy)
                {
                    Console.WriteLine($"-- {employ}");
                }
            }
        }
    }
}
