namespace MaxSequenceOfEqualElements
{
    using System;
    using System.Linq;

    // From SoftUni Programming Fundamentals January 2018 - Exercises: Arrays
    public class Program
    {
        /*
         Write a program that finds the longest sequence of equal elements in an array of integers. If several longest sequences exist, 
        print the leftmost one.

        Hints:
        •	Start with the sequence that consists of the first element: start=0, len=1.
        •	Scan the elements from left to right, starting at the second element: pos=1…n-1.
        o	At each step compare the current element with the element on the left.
            	Same value -> you have found a sequence longer by one -> len++.
            	Different value -> start a new sequence from the current element: start=pos, len=1.
        o	After each step remember the sequence it is found to be longest at the moment: bestStart=start, bestLen=len.
        •	Finally, print the longest sequence by using bestStart and bestLen.
         */
        public static void Main()
        {
            int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int length = 1;
            int start = 0;
            int bestLength = 0;
            int bestStart = ' ';

            for (int i = 1; i < array.Length; i++)
            {
                int currentElement = array[start];

                if (currentElement == array[i])
                {
                    length++;
                }
                else
                {
                    length = 1;
                }

                start++;

                if (bestLength < length)
                {
                    bestLength = length;
                    bestStart = currentElement;
                }
            }

            for (int i = 0; i < bestLength; i++)
            {
                Console.Write($"{bestStart} ");
            }
        }
    }
}