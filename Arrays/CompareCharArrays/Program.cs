namespace CompareCharArrays
{
    using System;
    using System.Linq;

    // From SoftUni Programming Fundamentals January 2018 - Exercises: Arrays
    public class Program
    {
        /*
         Compare two char arrays lexicographically (letter by letter). Print the them in alphabetical order, each on separate line.

        Hints:
        •	Compare the first letter of arr1[] and arr2[], if equal, compare the next letter, etc.
        •	If all letters are equal, the smaller array is the shorter.
        •	If all letters are equal and the array lengths are the same, the arrays are equal.
         */
        public static void Main()
        {
            Console.Write("First char array: ");
            char[] first = Console.ReadLine().Split(' ').Select(char.Parse).ToArray();

            Console.Write("Second char array: ");
            char[] second = Console.ReadLine().Split(' ').Select(char.Parse).ToArray();

            int minLength = first.Length < second.Length ? first.Length : second.Length;

            Console.WriteLine("The char arrays in in alphabetical order:");

            for (int i = 0; i < minLength; i++)
            {
                for (int j = 0; j < minLength; j++)
                {
                    if (first[i] > second[i])
                    {
                        Console.WriteLine(string.Join("", second));
                        Console.WriteLine(string.Join("", first));
                        return;
                    }
                    else if (first[i] < second[i])
                    {
                        Console.WriteLine(string.Join("", first));
                        Console.WriteLine(string.Join("", second));
                        return;
                    }
                }
            }

            if (first.Length < second.Length)
            {
                Console.WriteLine(string.Join("", first));
                Console.WriteLine(string.Join("", second));
            }
            else
            {
                Console.WriteLine(string.Join("", second));
                Console.WriteLine(string.Join("", first));
            }
        }
    }
}