namespace PairsByDifference
{
    using System;
    using System.Linq;

    // From SoftUni Programming Fundamentals January 2018 - Exercises: Arrays
    public class Program
    {
        /*
         * Write a program that count the number of pairs in given array which difference is equal to given number.
         Input
         •	The first line holds the sequence of numbers.
         •	The second line holds the difference.
         */
        public static void Main()
        {
            Console.Write("Sequence of numbers: ");
            int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            Console.Write("Difference: ");
            int difference = int.Parse(Console.ReadLine());

            int counter = 0;

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (Math.Abs(array[i] - array[j]) == difference)
                    {
                        counter++;
                    }
                }
            }

            Console.WriteLine($"Pairs, which difference is equal to {difference} are {counter}.");
        }
    }
}