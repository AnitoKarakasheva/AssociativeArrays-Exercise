using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.CompanyUsers
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> companies = new Dictionary<string, List<string>>();

            string command = Console.ReadLine();

            while (command != "End")
            {
                string[] courseArgs = command
                    .Split(" -> ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                string companyName = courseArgs[0];
                string employeeID = courseArgs[1];

                if (!companies.ContainsKey(companyName))
                {
                    companies.Add(companyName, new List<string>());
                }

                if (!companies[companyName].Contains(employeeID))
                {
                    companies[companyName].Add(employeeID);
                }

                command = Console.ReadLine();
            }


            foreach (var kvp in companies)
            {
                Console.WriteLine($"{kvp.Key}");

                foreach (var employeeID in kvp.Value)
                {
                    Console.WriteLine($"-- {employeeID}");
                }
            }
        }
    }
}
