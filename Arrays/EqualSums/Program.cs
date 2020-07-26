namespace EqualSums
{
    using System;
    using System.Linq;

    // From SoftUni Programming Fundamentals January 2018 - Exercises: Arrays
    public class Program
    {
        /*
         * Write a program that determines if there exists an element in the array such that the sum of the elements on its left 
         * is equal to the sum of the elements on its right. If there are no elements to the left / right, their sum is considered 
         * to be 0. Print the index that satisfies the required condition or “no” if there is no such index.
         */
        public static void Main()
        {
            Console.Write("Enter an array of integers: ");
            int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int index = 0;
            int leftSum = 0;
            int rightSum = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array.Length == 1)
                {
                    Console.WriteLine("Too few elements!");
                    return;
                }

                for (int j = 0; j < i; j++)
                {
                    leftSum += array[j];
                }

                for (int k = array.Length - 1; k > i; k--)
                {
                    rightSum += array[k];
                }

                if (leftSum == rightSum)
                {
                    index = i;
                    Console.WriteLine($"The sum of the elements on the left and on the right of element №{index + 1} is equal!");
                    return;
                }

                leftSum = 0;
                rightSum = 0;
            }

            if (index == 0)
            {
                Console.WriteLine("There's no such index!");
            }
        }
    }
}