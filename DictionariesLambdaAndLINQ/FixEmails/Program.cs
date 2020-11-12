namespace FixEmails
{
    using System;
    using System.Collections.Generic;

    // From SoftUni Programming Fundamentals January 2018 - Exercises: Dictionaries, Lambda and LINQ
    class Program
    {
        /*
         * You are given a sequence of strings, each on a new line, until you receive the “stop” command.
         * The first string is the name of a person. On the second line, you will receive their email. 
         * Your task is to collect their names and emails, and remove emails whose domain ends with "us" or "uk" (case insensitive). 
         * Print: {name} – > {email} 
         */
        static void Main(string[] args)
        {
            Console.Write("Person's name or end of input: ");
            string input = Console.ReadLine();
            var dictionary = new Dictionary<string, string>();

            while (input != "stop")
            {
                Console.Write("Email: ");
                string email = Console.ReadLine();
                string domainEnd = email.Substring(email.Length - 2, 2);

                if (domainEnd == "uk" || domainEnd == "us")
                {
                    Console.Write("Person's name or end of input: ");
                    input = Console.ReadLine();
                    continue;
                }
                else
                {
                    dictionary.Add(input, email);
                }

                Console.Write("Person's name or end of input: ");
                input = Console.ReadLine();
            }

            foreach (var person in dictionary)
            {
                Console.WriteLine($"{person.Key} -> {person.Value}");
            }
        }
    }
}
