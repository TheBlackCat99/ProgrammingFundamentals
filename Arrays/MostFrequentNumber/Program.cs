namespace MostFrequentNumber
{
    using System;
    using System.Linq;

    // From SoftUni Programming Fundamentals January 2018 - Exercises: Arrays
    public class Program
    {
        /*
         * Write a program that finds the most frequent number in a given sequence of numbers. 
            •	Numbers will be in the range [0…65535].
            •	In case of multiple numbers with the same maximal frequency, print the left most of them.
         */
        public static void Main()
        {
            Console.Write("Sequence of numbers: ");
            int[] sequenceOfNumbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int mostFrequent = 0;
            int frequencyCounter = 0;
            int counter = 0;

            for (int i = 0; i < sequenceOfNumbers.Length; i++)
            {
                for (int j = 0; j < sequenceOfNumbers.Length; j++)
                {
                    if (sequenceOfNumbers[i] == sequenceOfNumbers[j])
                    {
                        counter++;
                    }

                    if (counter > frequencyCounter)
                    {
                        frequencyCounter = counter;
                        mostFrequent = sequenceOfNumbers[i];
                    }
                }

                counter = 0;
            }

            Console.WriteLine($"Most frequnt number: {mostFrequent}");
        }
    }
}