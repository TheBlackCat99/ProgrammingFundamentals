namespace SumReversedNumbers
{
    using System;
    using System.Linq;

    // From SoftUni Programming Fundamentals January 2018 - Exercises: Lists
    public class Program
    {
        /*
         * Write a program that reads sequence of numbers, reverses their digits, and prints their sum.
         */
        public static void Main()
        {
            Console.Write("Enter random sequence of numbers: ");
            string[] sequenceOfNumbers = Console.ReadLine().Split(' ').ToArray();
            string[] numbers = new string[sequenceOfNumbers.Length];

            for (int i = 0; i < sequenceOfNumbers.Length; i++)
            {
                string currentSequence = sequenceOfNumbers[i];

                for (int j = currentSequence.Length - 1; j >= 0; j--)
                {
                    numbers[i] += currentSequence[j];
                }
            }

            int sum = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                sum += int.Parse(numbers[i]);
            }

            Console.WriteLine($"Sum of the numbers reversed: {sum}");
        }
    }
}