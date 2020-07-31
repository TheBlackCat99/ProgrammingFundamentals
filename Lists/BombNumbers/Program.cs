namespace BombNumbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    // From SoftUni Programming Fundamentals January 2018 - Exercises: Lists
    public class Program
    {
        /*
         * Write a program that reads sequence of numbers and special bomb number with a certain power.
         * Your task is to detonate every occurrence of the special bomb number and according to its power his neighbors from left
         * and right. Detonations are performed from left to right and all detonated numbers disappear. 
         * Finally print the sum of the remaining elements in the sequence.
         */
        public static void Main()
        {
            Console.Write("Sequence of Numbers: ");
            List<int> sequenceOfNumbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            Console.Write("Bomb number and its power: ");
            List<int> bombNumbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            int bomb = bombNumbers[0];
            int power = bombNumbers[1];

            // calculating how much elements have to be removed, based on the power if the bomb number
            int elementsToRemove = power * 2 + 1;
            int sum = 0;

            for (int i = 0; i < sequenceOfNumbers.Count; i++)
            {
                int currentNum = sequenceOfNumbers[i];

                if (currentNum == bomb)
                {
                    int index = i - power;

                    for (int j = 0; j < elementsToRemove; j++)
                    {
                        // on each iteration, a check is needed to make sure that the index is not outside the bounds of the list
                        if (index < 0)
                        {
                            index++;
                        }
                        else if (index >= sequenceOfNumbers.Count)
                        {
                            break;
                        }
                        else
                        {
                            sequenceOfNumbers.Remove(sequenceOfNumbers[index]);
                        }
                    }
                    // reseting the index, because after all manipulations, it's better to start from the beginning
                    // so we don't skip an element
                    i = -1;
                }
            }

            for (int i = 0; i < sequenceOfNumbers.Count; i++)
            {
                sum += sequenceOfNumbers[i];
            }

            Console.WriteLine($"Sum of remaining elements: {sum}");
        }
    }
}