namespace LogsAggregator
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    // From SoftUni Programming Fundamentals January 2018 - Exercises: Dictionaries, Lambda and LINQ
    class Program
    {
        /*You are given a sequence of access logs in format <IP> <user> <duration>. 
         Write a program to aggregate the logs data and print for each user the total duration of his sessions 
        and a list of unique IP addresses in format "<user>: <duration> [<IP1>, <IP2>, …]". 
        Order the users alphabetically. Order the IPs alphabetically. */
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var logs = new SortedDictionary<string, SortedDictionary<string, int>>();

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split(' ');

                var address = input[0];
                var user = input[1];
                var duration = int.Parse(input[2]);

                if (logs.ContainsKey(user) && logs[user].ContainsKey(address))
                {
                    logs[user][address] += duration;
                }
                else if (logs.ContainsKey(user) && !logs[user].ContainsKey(address))
                {
                    logs[user].Add(address, duration);
                }
                else
                {
                    var helperDict = new SortedDictionary<string, int>();
                    helperDict.Add(address, duration);
                    logs.Add(user, helperDict);
                }
            }

            foreach (var user in logs)
            {
                Console.Write($"{user.Key}: {user.Value.Values.Sum()} ");
                var userData = new List<string>();

                foreach (var userAddress in user.Value)
                {
                    userData.Add(userAddress.Key);
                }

                Console.Write($"[{string.Join(", ", userData)}]");
                Console.WriteLine();
            }
        }
    }
}
