using System;
using System.Collections.Generic;

public class BePositive_broken
{
    //public static void Main()
    //{
    //    int countSequences = int.Parse(Console.ReadLine());

    //    for (int i = 0; i < countSequences; i++)
    //    {
    //        string[] input = Console.ReadLine().Trim().Split(' ');
    //        var numbers = new List<int>();

    //        bool found = false;

    //        for (int j = 0; j < input.Length; j++)
    //        {
    //            if (!input[j].Equals(string.Empty))
    //            {
    //                int num = int.Parse(input[j]);
    //                numbers.Add(num);
    //            }
    //        }

    //        for (int k = 0; k < numbers.Count; k++)
    //        {
    //            int currentNum = numbers[k];

    //            if (currentNum > 0)
    //            {
    //                if (found)
    //                {
    //                    Console.Write(" ");
    //                }

    //                Console.Write(currentNum);

    //                found = true;
    //            }
    //            else
    //            {
    //                currentNum += numbers[k + 1];
    //                k++;

    //                if (currentNum > 0)
    //                {
    //                    if (found)
    //                    {
    //                        Console.Write(" ");
    //                    }

    //                    Console.Write(currentNum);

    //                    found = true;
    //                }
    //                else
    //                {
    //                    numbers.Remove(currentNum);
    //                }
    //            }
    //        }

    //        if (!found)
    //        {
    //            Console.WriteLine("(empty)");
    //        }
    //    }
    //}
}