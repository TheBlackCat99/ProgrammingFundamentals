namespace SquareNumbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    // From SoftUni Programming Fundamentals January 2018 - Lab: Lists
    public class Program
    {
        /*
         * Read a list of integers and extract all square numbers from it and print them in descending order. A square number is
         * an integer which is the square of any integer. For example, 1, 4, 9, 16 are square numbers.
         * 
         * Hints
            •	To find out whether an integer is “square number”, check whether its square root is integer number 
            (has no fractional part):
            o	if (√num == (int)√num) …
            •	To order the results list in descending order use sorting by lambda function:
            o	squareNums.Sort((a, b) => b.CompareTo(a));
         */
        public static void Main()
        {
            Console.Write("Sequence of Numbers: ");
            List<int> list = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            List<int> squareNumbers = new List<int>();

            for (int i = 0; i < list.Count; i++)
            {
                int currentNum = list[i];
                double square = Math.Sqrt(currentNum);

                if ((int)square == square)
                {
                    squareNumbers.Add(currentNum);
                }
            }

            for (int i = 0; i < squareNumbers.Count; i++)
            {
                for (int j = i + 1; j < squareNumbers.Count; j++)
                {
                    if (squareNumbers[i] > squareNumbers[j])
                    {
                        int temp = squareNumbers[i];
                        squareNumbers[i] = squareNumbers[j];
                        squareNumbers[j] = temp;
                    }
                }
            }

            Console.Write("All square numbers in descending order: ");

            for (int i = squareNumbers.Count - 1; i >= 0; i--)
            {
                Console.Write(squareNumbers[i] + " ");
            }

            //squareNumbers.Sort((a, b) => b.CompareTo(a));
            //Console.WriteLine(string.Join(" ", squareNumbers));
        }
    }
}