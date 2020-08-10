namespace FoldAndSum
{
    using System;
    using System.Linq;

    // From SoftUni Programming Fundamentals January 2018 - Lab: Dictionaries, Lambda and LINQ
    class Program
    {
        /*
         * Read an array with 4*k integers, fold it like the example below and print the sum of the upper and lower rows (2*k int).
         * Example:
         * Input: 12345678
         * After folding:
         * 2187
         * 3456
         * Output: 5 5 13 13 
         */
        static void Main(string[] args)
        {
            Console.Write("Array of integers: ");
            int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int k = array.Length / 4;

            int[] firstElementsOfFirstRow = array.Take(k).Reverse().ToArray();
            int[] lastElementsOfFirstRow = array.Reverse().Take(k).ToArray();

            int[] secondRow = array.Skip(k).Take(2 * k).ToArray();
            int[] firstRow = firstElementsOfFirstRow.Concat(lastElementsOfFirstRow).ToArray();

            int[] sum = new int[2 * k];

            for (int i = 0; i < sum.Length; i++)
            {
                sum[i] = firstRow[i] + secondRow[i];
            }

            Console.WriteLine($"Sum of the folded elements: {string.Join(" ", sum)}");
        }
    }
}
