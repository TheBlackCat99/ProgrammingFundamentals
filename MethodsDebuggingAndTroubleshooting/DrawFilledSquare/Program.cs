namespace DrawFilledSquare
{
    using System;

    // From SoftUni Programming Fundamentals January 2018 - Lab: Methods, Debugging and Troubleshooting Code
    public class Program
    {

        /*
         Printing a square simillar to this one, the size of which is taken from the input
         --------
         -\/\/\/-
         -\/\/\/-
         --------
        (here the size is 4)
        */

        public static void Main()
        {
            Console.Write("Size of the square: ");
            int n = int.Parse(Console.ReadLine());

            PrintDashes(n);
            PrintMiddle(n);
            PrintDashes(n);
        }

        private static void PrintMiddle(int n)
        {
            for (int i = 0; i < n - 2; i++)
            {
                Console.Write("-");

                for (int j = 0; j < n - 1; j++)
                {
                    Console.Write("\\/");
                }

                Console.Write("-");
                Console.WriteLine();
            }
        }

        private static void PrintDashes(int n)
        {
            /*Another way
             Console.WriteLine(new string("-", 2 * n));
             */
            for (int i = 1; i <= 2 * n; i++)
            {
                Console.Write("-");
            }
            Console.WriteLine();
        }
    }
}
