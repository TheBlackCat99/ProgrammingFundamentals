namespace CountNumbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    // From SoftUni Programming Fundamentals January 2018 - Lab: Lists
    public class Program
    {
        /*
         * Read a list of integers in range [0…1000] and print them in ascending order along with their number of occurrences.
         */
        public static void Main()
        {
            Console.Write("Enter sequance of integers: ");
            List<int> list = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int[] count = new int[1001];

            for (int i = 0; i < list.Count; i++)
            {
                int currentNum = list[i];
                count[currentNum]++;
            }

            Console.WriteLine("The list in ascending order: ");

            for (int i = 0; i < count.Length; i++)
            {
                if (count[i] != 0)
                {
                    Console.WriteLine($"{i} -> {count[i]}");
                }
            }
        }
    }
}
