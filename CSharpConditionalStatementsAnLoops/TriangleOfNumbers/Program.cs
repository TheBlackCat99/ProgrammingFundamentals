namespace TriangleOfNumbers
{
    using System;

    // From SoftUni Programming Fundamentals January 2018 - Exercises: C# Conditional Statements and Loops
    public class Program
    {
        /* Write a program, which receives a number – n, and prints a triangle from 1 to n as in the examples.
         * Input	Output
            3	    1
                    2 2 
                    3 3 3 */
        public static void Main()
        {
            Console.Write("Number: ");
            int n = int.Parse(Console.ReadLine());

            for (int row = 1; row <= n; row++)
            {
                for (int col = 1; col <= row; col++)
                {
                    Console.Write(row + " ");
                }

                Console.WriteLine();
            }
        }
    }
}