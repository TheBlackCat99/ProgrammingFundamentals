namespace LargestCommonEnd
{
    using System;

    // From SoftUni Programming Fundamentals January 2018 - Exercises: Arrays
    public class Program
    {
        /*
         * Read two arrays of words and find the length of the largest common end (left or right).
         */
        public static void Main()
        {
            Console.Write("First string array: ");
            var arrOne = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            Console.Write("Second string array: ");
            var arrTwo = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

            var shorterLength = arrOne.Length < arrTwo.Length ? arrOne.Length : arrTwo.Length;
            var count = 0;
            var countLeft = 0;
            var countRight = 0;

            for (int i = 0; i < shorterLength; i++)
            {
                if (arrOne[i] == arrTwo[i])
                {
                    countLeft++;
                }
                else
                {
                    break;
                }
            }

            for (int i = 0; i < shorterLength; i++)
            {
                if (arrOne[arrOne.Length - i - 1] == arrTwo[arrTwo.Length - i - 1])
                {
                    countRight++;
                }
                else
                {
                    break;
                }
            }

            count = countLeft > countRight ? countLeft : countRight;
            Console.WriteLine($"Largest common end: {count}");
        }
    }
}