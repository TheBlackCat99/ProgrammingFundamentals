namespace IndexOfLetters
{
    using System;

    // From SoftUni Programming Fundamentals January 2018 - Exercises: Arrays
    public class Program
    {
        /*
         Write a program that creates an array containing all letters from the alphabet (a-z). 
        Read a lowercase word from the console and print the index of each of its letters in the letters array.
         */
        public static void Main()
        {
            var lowercaseWord = Console.ReadLine();
            char[] alphabet = new char[26];

            int j = 0;

            for (char i = 'a'; i <= 'z'; i++)
            {
                alphabet[j] = i;
                j++;
                if (j >= alphabet.Length)
                {
                    break;
                }
            }

            foreach (var item in lowercaseWord)
            {
                for (int i = 0; i < alphabet.Length; i++)
                {
                    if (item == alphabet[i])
                    {
                        Console.WriteLine($"{item} -> {i}");
                    }
                }
            }
        }
    }
}