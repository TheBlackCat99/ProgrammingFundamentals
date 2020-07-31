namespace LongestIncreasingSubsequence
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    // From SoftUni Programming Fundamentals January 2018 - Exercises: Lists
    public class Program
    {
        /*
         * Read a list of integers and find the longest increasing subsequence (LIS). If several such exist, print the leftmost.
         * Hints
        •	Assume we have n numbers in an array nums[0…n-1].
        •	Let len[p] holds the length of the longest increasing subsequence (LIS) ending at position p.
        •	In a for loop, we shall calculate len[p] for p = 0 … n-1 as follows:
            o	Let left is the leftmost position on the left of p (left < p), such that len[left] is the largest possible.
            o	Then, len[p] = 1 + len[left]. If left does not exist, len[p] = 1.
            o	Also, save prev[p] = left (we hold if prev[] the previous position, used to obtain the best length for position p).
        •	Once the values for len[0…n-1] are calculated, restore the LIS starting from position p such that len[p] is 
        maximal and go back and back through p = prev[p].

        index	0	    1	    2	    3	        4	    5	        6	        7	        8	        9           10
        nums[]	3	    14	    5	    12	        15	    7	        8	        9	        11	        10          1
        len[]	1	    2	    2	    3	        4	    3	        4	        5	        6	        6           1
        prev[]	-1	    0	    0	    2	        3	    2	        5	        6	        7	        7          -1
        LIS    {3}	   {3,14} {3,5} {3,5,12} {3,5,12,15} {3,5,7} {3,5,7,8}	{3,5,7,8,9}	{3,5,7,8,9,11}	{3,5,7,8,9,10}	{1}

         */
        public static void Main()
        {
            List<int> list = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            //int[] longestIncreasingSubsequence = new int[list.Count];
            int[] length = new int[list.Count];
            int[] previous = new int[list.Count];

            for (int i = 0; i < list.Count; i++)
            {
                int currentNum = list[i];

                if (currentNum < list[i + 1])
                {
                    length[i]++;
                }

            }
        }
    }
}