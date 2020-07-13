namespace MethodsDebuggingAndTroubleshooting
{
    using System;

    // From SoftUni Programming Fundamentals January 2018 - Lab: Methods, Debugging and Troubleshooting Code
    public class Program
    {

        /*Printing a triangle simillar to this one, where the biggest number is taken from the input
          1 2
          1 2 3
          1 2 3 4
          1 2 3
          1 2
          */

        public static void Main()
        {
            Console.Write("Number of columns: ");
            int n = int.Parse(Console.ReadLine());

            PrintTriangle(n);
        }

        private static void PrintTriangle(int n)
        {
            PrintTopPart(n);
            PrintBottomPart(n);
        }

        private static void PrintTopPart(int n)
        {
            for (int row = 1; row <= n; row++)
            {
                PrintLine(row);
            }
        }

        private static void PrintBottomPart(int n)
        {
            for (int row = n - 1; row >= 1; row--)
            {
                PrintLine(row);
            }
        }

        private static void PrintLine(int row)
        {
            for (int col = 1; col <= row; col++)
            {
                Console.Write(col + " ");
            }
            Console.WriteLine();
        }
    }
}