namespace SumAdjacentEqualNumbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    // From SoftUni Programming Fundamentals January 2018 - Lab: Lists
    class Program
    {
        /*
         Write a program to sum all adjacent equal numbers in a list of decimal numbers, starting from left to right.
            	After two numbers are summed, the obtained result could be equal to some of its neighbors and should be summed as well.
            	Always sum the leftmost two equal neighbors (if several couples of equal neighbors are available).
        Print the results.

        Hints:
        1.	Read the input and parse it to list of numbers.
        2.	Find the leftmost two adjacent equal cells.
        3.	Replace them with their sum.
        4.	Repeat (1) and (2) until no two equal adjacent cells survive.
        5.	Print the processed list of numbers.
         */
        static void Main()
        {
            Console.Write("Enter decimal values: ");
            List<decimal> input = Console.ReadLine().Split(' ').Select(decimal.Parse).ToList();
            decimal sum = 0;

            for (int i = 0; i < input.Count - 1; i++)
            {
                decimal currentNum = input[i];

                if (currentNum == input[i + 1])
                {
                    sum = input[i] + input[i + 1];
                    input.Remove(currentNum);
                    input.Remove(currentNum);
                    input.Insert(i, sum);
                    i = -1;
                }
            }

            Console.Write("Result: ");
            Console.WriteLine(string.Join(" ", input));
        }
    }
}