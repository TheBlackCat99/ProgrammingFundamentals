namespace Phonebook
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    // From SoftUni Programming Fundamentals January 2018 - Exercises: Dictionaries, Lambda and LINQ
    class Program
    {
        /*
         * Write a program that receives some info from the console about people and their phone numbers. 
         * Each entry should have just one name and one number (both of them strings). 
            On each line, you will receive some of the following commands:
            •	A {name} {phone} – adds entry to the phonebook. In case of trying to add a name that is already in the phonebook
        you should change the existing phone number with the new one provided.
            •	S {name} – searches for a contact by given name and prints it in format "{name} -> {number}".
            In case the contact isn't found, print "Contact {name} does not exist.".
            •	END – stop receiving more commands.

        Add functionality to the phonebook to print all contacts ordered lexicographically when receive the command “ListAll”.
         */
        static void Main(string[] args)
        {
            Console.Write("Command: ");
            string[] input = Console.ReadLine().Split(' ');
            string command = input[0];
            var phonebook = new Dictionary<string, string>();

            while(command != "END")
            {
                string name;

                switch (command)
                {
                    case "A":
                        name = input[1];
                        string phone = input[2];

                        if (phonebook.ContainsKey(name))
                        {
                            phonebook[name] = phone;
                        }
                        else
                        {
                            phonebook.Add(name, phone);
                        }
                        break;
                    case "S":
                        name = input[1];

                        if (phonebook.ContainsKey(name))
                        {
                            Console.WriteLine($"{name} -> {phonebook[name]}");
                        }
                        else
                        {
                            Console.WriteLine($"Contact {name} does not exist.");
                        }
                        break;
                    case "ListAll":
                        foreach (var item in phonebook.Keys.OrderBy(x => x))
                        {
                            Console.WriteLine($"{item} -> {phonebook[item]}");
                        }
                        break;
                }

                Console.Write("Command: ");
                input = Console.ReadLine().Split();
                command = input[0];
            }
        }
    }
}