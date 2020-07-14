namespace MagicLetter
{
    using System;

    // From SoftUni Programming Fundamentals January 2018 - Exercises: C# Conditional Statements and Loops
    public class Program
    {
        /*
         * Write a program, which prints all 3-letter combinations, using only the letters from a given interval. 
         * You will also receive a third letter. Every combination, which contains this letter should not be printed.
         */
        public static void Main()
        {
            Console.Write("First letter: ");
            char first = char.Parse(Console.ReadLine());

            Console.Write("Second letter: ");
            char second = char.Parse(Console.ReadLine());

            Console.Write("Forbidden letter: ");
            char forbidden = char.Parse(Console.ReadLine());

            for (char i = first; i <= second; i++)
            {
                for (char j = first; j <= second; j++)
                {
                    for (char k = first; k <= second; k++)
                    {
                        if (i == forbidden || j == forbidden || k == forbidden)
                        {
                            continue;
                        }
                        Console.Write($"{i}{j}{k} ");
                    }
                }
            }
        }
    }
}