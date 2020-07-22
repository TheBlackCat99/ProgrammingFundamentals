namespace RotateAndSum
{
    using System;
    using System.Linq;

    // From SoftUni Programming Fundamentals January 2018 - Exercises: Arrays
    public class Program
    {
        /*
         To “rotate an array on the right” means to move its last element first: {1, 2, 3} -> {3, 1, 2}. Write a program to read an array 
        of n integers (space separated on a single line) and an integer k, rotate the array right k times and sum the obtained arrays 
        after each rotation.
        */
        public static void Main()
        {
            Console.Write("Initial array: ");
            int[] array = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            Console.Write("Number of rotations: ");
            int k = int.Parse(Console.ReadLine());

            int arrayLength = array.Length;

            int[] sum = new int[arrayLength];

            for (int i = 0; i < k; i++)
            {
                int[] rotatedArr = new int[arrayLength];
                rotatedArr[0] = array[arrayLength - 1];

                for (int j = 1; j < arrayLength; j++)
                {
                    rotatedArr[j] = array[j - 1];
                }

                for (int m = 0; m < arrayLength; m++)
                {
                    sum[m] += rotatedArr[m];
                }

                Console.WriteLine($"Rotated array № {i + 1}: {string.Join(' ', rotatedArr)}");
                array = rotatedArr;
            }

            Console.WriteLine($"Sum of all rotated arrays: {string.Join(" ", sum)}");
        }
    }
}