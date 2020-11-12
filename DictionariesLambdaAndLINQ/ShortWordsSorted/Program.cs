namespace ShortWordsSorted
{
    using System;
    using System.Linq;

    // From SoftUni Programming Fundamentals January 2018 - Lab: Dictionaries, Lambda and LINQ
    class Program
    {
        /*
         * Read a text, extract its words, find all short words (less than 5 characters) and print them alphabetically, in lowercase.
            •	Use the following separators: . , : ; ( ) [ ] " ' \ / ! ? (space).
            •	Use case-insensitive matching.
            •	Remove duplicated words.
         */
        static void Main(string[] args)
        {
            char[] delimiters = new char[] { '.', ',', ':', ';', '(', ')', '[', ']', '\"', '\'', '\\', '/', '!', '?', ' ' };

            Console.Write("Text: ");
            var words = Console.ReadLine()
                .ToLower()
                .Split(delimiters, StringSplitOptions.RemoveEmptyEntries)
                .Distinct();

            Console.WriteLine($"Al short words(under 5 characters) alphabetically: " +
                $"{string.Join(", ", words.Where(x => x.Length < 5).OrderBy(x => x))}");
        }
    }
}