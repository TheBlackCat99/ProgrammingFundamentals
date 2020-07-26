namespace SieveOfEratosthenes
{
    using System;

    // From SoftUni Programming Fundamentals January 2018 - Exercises: Arrays
    public class Program
    {
        /*
         Write a program to find all prime numbers in range [1…n]. Implement the algorithm called “Sieve of Eratosthenes”: 
        https://en.wikipedia.org/wiki/Sieve_of_Eratosthenes. Steps in the “Sieve of Eratosthenes” algorithm:
            1.	Assign primes[0…n] = true
            2.	Assign primes[0] = primes[1] = false
            3.	Find the smallest p, which holds primes[p] = true
            •	Print p (it is prime)
            •	Assign primes[2*p] = primes[3*p] = primes[4*p] = … = false
            4.	Repeat for the next smallest p < n.
         */
        public static void Main()
        {
            Console.Write("Find all prime numbers from 1 to: ");
            int n = int.Parse(Console.ReadLine());

            bool[] isPrime = new bool[n + 1];

            for (int i = 2; i < isPrime.Length; i++)
            {
                isPrime[i] = true;
            }

            Console.Write($"Prime numbers between 1 and {n} are: ");

            for (int i = 2; i < isPrime.Length; i++)
            {
                if (isPrime[i] == true)
                {
                    Console.Write(i + " ");

                    for (int j = 2; j < isPrime.Length; j++)
                    {
                        if (i * j >= isPrime.Length)
                        {
                            break;
                        }

                        isPrime[i * j] = false;
                    }
                }
            }
        }
    }
}
