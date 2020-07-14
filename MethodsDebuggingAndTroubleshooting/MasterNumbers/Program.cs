namespace MasterNumbers
{
    using System;

    // From SoftUni Programming Fundamentals January 2018 - Lab: Methods, Debugging and Troubleshooting Code
    public class Program
    {
        /*
         A master number is an integer that holds the following properties:
            •	Is symmetric (palindrome), e.g. 5, 77, 282, 14341, 9553559.
            •	Its sum of digits is divisible by 7, e.g. 77, 313, 464, 5225, 37173.
            •	Holds at least one even digit, e.g. 232, 707, 6886, 87578.
         Write a program to print all master numbers in the range [1…n].
         */

        public static void Main()
        {
            Console.WriteLine("Number: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {

            }
        }

        static bool IsPalindrome(int num)
        {
            //if (num < 10)
            //{
            //    return true;
            //}
            //else
            //{

            //}

            throw new NotImplementedException();
        }

        static double SumOfDigits(int num)
        {
            throw new NotImplementedException();
        }

        static bool ContainsEvenDigit(int num)
        {
            throw new NotImplementedException();
        }
    }
}