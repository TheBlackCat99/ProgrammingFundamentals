namespace FoldAndSum
{
    using System;
    using System.Linq;

    // From SoftUni Programming Fundamentals January 2018 - Exercises: Arrays
    public class Program
    {
        /*
         * Read an array of 4*k integers, fold it like shown below, and print the sum of the upper and lower two rows (each holding 2 * k integers):
         * Input: 1 2 3 4 5 6 7 8
         * Output: 5 5 13 13
         * Calculations: 
         * 2  1  8  7  +
           3  4  5  6  =
           5  5 13 13

         Hints:
          •Create the first row after folding: the first k numbers reversed, followed by the last k numbers reversed.
          •Create the second row after folding: the middle 2*k numbers.
          •Sum the first and the second rows.

         */
        public static void Main()
        {
            Console.Write("Initial array: ");
            int[] array = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            int k = array.Length / 4;

            int[] firstArr = new int[2 * k]; // array.Length / 2
            int[] secondArr = new int[2 * k];

            int[] sum = new int[2 * k];

            for (int i = 0; i < k; i++)
            {
                // starting from first k elements in the folded array above
                firstArr[i] = array[k - 1 - i];

                // then calculating last k elements, starting from last one
                firstArr[firstArr.Length - 1 - i] = array[array.Length - k + i];
            }

            for (int i = 0; i < secondArr.Length; i++)
            {
                // that's the second array with 2*k elements
                secondArr[i] = array[k + i];
            }

            for (int i = 0; i < sum.Length; i++)
            {
                sum[i] = firstArr[i] + secondArr[i];
            }

            Console.WriteLine($"First row after folding: {string.Join(" ", firstArr)}");
            Console.WriteLine($"Second row: {string.Join(" ", secondArr)}");
            Console.WriteLine($"Sum of the two rows: {string.Join(" ", sum)}");
        }
    }
}
