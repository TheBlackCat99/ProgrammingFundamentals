namespace MasterNumbers
{
    using System;
    using System.Linq;

    // From SoftUni Programming Fundamentals January 2018 - Exercises: Methods, Debugging and Troubleshooting Code
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
            //Console.WriteLine("Number: ");
            string n = Console.ReadLine();

            for (int i = 1; i <= int.Parse(n); i++)
            {
                if (IsPalindrome(i) && SumDivisibleBySeven(i) && ContainsEvenDigit(i))
                {
                    Console.WriteLine(i);
                }
                else
                {
                    continue;
                }
            }
        }

        static bool IsPalindrome(int number)
        {
            string num = number.ToString();

            if (num.Length == 1)
            {
                return true;
            }
            else
            {
                for (int i = 0; i < num.Length / 2; i++)
                {
                    char firstDigit = num.Skip(i).First();
                    char lastDigit = num.Skip(num.Length - 1 - i).First();

                    if (firstDigit != lastDigit)
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        static bool SumDivisibleBySeven(int num)
        {
            int sumOfDigits = 0;

            while (num != 0)
            {
                sumOfDigits += num % 10;
                num /= 10;
            }

            if (sumOfDigits % 7 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static bool ContainsEvenDigit(int number)
        {
            string num = number.ToString();

            for (int i = 0; i < num.Length; i++)
            {
                char currentChar = num.Skip(i).First();
                int currentDigit = Convert.ToInt32(currentChar);

                if (currentDigit % 2 == 0)
                {
                    return true;
                }
            }

            return false;
        }
    }
}