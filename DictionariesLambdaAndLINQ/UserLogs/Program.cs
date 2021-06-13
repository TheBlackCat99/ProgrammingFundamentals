namespace UserLogs
{
    using System;
    using System.Collections.Generic;

    // From SoftUni Programming Fundamentals January 2018 - Exercises: Dictionaries, Lambda and LINQ
    class Program
    {
        /*
         * You are given an input in the format:
	    IP=(IP.Address) message=(A&sample&message) user=(username)
        Your task is to parse the IP and the username from the input and for every user,
        you have to display every IP from which the corresponding user has sent a message 
        and the count of the messages sent with the corresponding IP. In the output,
        the usernames must be sorted alphabetically while their IP addresses should be displayed 
        in the order of their first appearance. 
         */

        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ');

            var userIpAddresses = new SortedDictionary<string, Dictionary<string, int>>();

            while (input[0] != "end")
            {
                var ipInput = input[0].Split('=');
                var ipAddress = ipInput[1];
                var userInput = input[2].Split('=');
                var username = userInput[1];
                bool userExists = userIpAddresses.ContainsKey(username);

                if (userExists)
                {
                    bool ipExists = userIpAddresses[username].ContainsKey(ipAddress);

                    if (ipExists)
                    {
                        userIpAddresses[username][ipAddress]++;
                    }
                    else
                    {
                        userIpAddresses[username].Add(ipAddress, 1);
                    }
                }
                else
                {
                    var currentIpAndCount = new Dictionary<string, int>();
                    currentIpAndCount.Add(ipAddress, 1);
                    userIpAddresses.Add(username, currentIpAndCount);
                }

                input = Console.ReadLine().Split(' ');
            }

            foreach (var userItem in userIpAddresses)
            {
                Console.WriteLine($"{userItem.Key}:");
                var printHelper = new List<string>();

                foreach (var userIpAndCount in userItem.Value)
                {
                    printHelper.Add($"{userIpAndCount.Key} => {userIpAndCount.Value}");
                }

                Console.WriteLine(string.Join(", ", printHelper) + ".");
            }

        }
    }
}
