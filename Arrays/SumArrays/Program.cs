namespace SumArrays
{
    using System;
    using System.Linq;

    // From SoftUni Programming Fundamentals January 2018 - Lab: Arrays
    public class Program
    {
        /*Write a program that reads two arrays of integers and sums them. When the arrays are not of the same size,
         * duplicate the smaller array a few times.
         */
        public static void Main()
        {
            Console.Write("First array of integers: ");
            int[] firstArr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            Console.Write("Second array of integers: ");
            int[] secondArr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int endArrayLength = MaxLength(firstArr.Length, secondArr.Length);

            Console.Write("Sum: ");
            for (int i = 0; i < endArrayLength; i++)
            {
                int sum = firstArr[i % firstArr.Length] + secondArr[i % secondArr.Length];
                Console.Write(sum + " ");
            }
        }

        private static int MaxLength(int firstLength, int secondLength)
        {
            if (firstLength > secondLength)
            {
                return firstLength;
            }
            else
            {
                return secondLength;
            }
        }
    }
}