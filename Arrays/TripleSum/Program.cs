namespace TripleSum
{
    using System;
    using System.Linq;

    // From SoftUni Programming Fundamentals January 2018 - Lab: Arrays
    public class Program
    {
        /*
         * Write a program to read an array of integers and find all triples of elements a, b and c, 
         * such that a + b == c (where a stays to the left from b). Print “No” if no such triples exist.
         */
        public static void Main()
        {
            Console.Write("Enter array of integers: ");
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            bool isTripleSum = false;

            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    int sum = numbers[i] + numbers[j];

                    // Another option                    
                    //if (numbers.Contains(sum))
                    //{
                    //    isTripleSum = true;
                    //    Console.WriteLine($"{numbers[i]} + {numbers[j]} == {sum}");
                    //}

                    for (int k = 0; k < numbers.Length; k++)
                    {
                        if(sum == numbers[k])
                        {
                            isTripleSum = true;
                            Console.WriteLine($"{numbers[i]} + {numbers[j]} == {sum}");
                            break;
                        }
                    }
                }
            }

            if (!isTripleSum)
            {
                Console.WriteLine("No");
            }
        }
    }
}
