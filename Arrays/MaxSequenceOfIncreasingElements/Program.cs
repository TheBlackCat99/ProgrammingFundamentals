namespace MaxSequenceOfIncreasingElements
{
    using System;
    using System.Linq;

    // From SoftUni Programming Fundamentals January 2018 - Exercises: Arrays
    public class Program
    {
        /*
         * Write a program that finds the longest increasing subsequence in an array of integers. The longest increasing 
         * subsequence is a portion of the array (subsequence) that is strongly increasing and has the longest possible length. 
         * If several such subsequences exist, find the left most of them.
         * 
         * Hints:
         * •	Use the same algorithm like in the previous problem (Max Sequence of Equal Elements).
         */
        public static void Main()
        {
            Console.Write("Initial array: ");
            int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int length = 1;
            int lengthMax = 0;
            int position = 0; // position of last element of the sequence

            for (int i = 0; i < array.Length - 1; i++)
            {
                if (array[i] < array[i + 1])
                {
                    length++;

                    if (length > lengthMax)
                    {
                        lengthMax = length;
                        position = i + 1;
                    }
                }
                else
                {
                    length = 1;
                }
            }

            int[] result = new int[lengthMax];

            for (int i = 0; i < result.Length; i++)
            {
                result[i] = array[position - lengthMax + 1 + i];
            }

            Console.WriteLine(string.Join(" ", result));
        }
    }
}