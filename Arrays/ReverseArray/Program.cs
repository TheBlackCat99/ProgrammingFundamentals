namespace ReverseArray
{
    using System;
    using System.Linq;

    // From SoftUni Programming Fundamentals January 2018 - Lab: Arrays
    public class Program
    {
        /*Write a program to read an array of strings, reverse it and print its elements. 
         * The input consists of a sequence of space separated strings. 
         * Print the output on a single line (space separated).*/
        public static void Main()
        {
            Console.Write("Enter array of strings: ");
            string[] texts = Console.ReadLine().Split(' ');

            Console.WriteLine("Reversed array: ");
            //opiton 1
            Console.WriteLine(string.Join(' ', texts.Reverse()));

            //option 2
            for (int i = texts.Length - 1; i >= 0; i--)
            {
                Console.Write(texts[i] + " ");
            }

            Console.WriteLine();

            //option 3
            string[] reversedArray = ReverseArray(texts);

            foreach (var item in reversedArray)
            {
                Console.Write(item + " ");
            }
        }

        static string[] ReverseArray(string[] array)
        {
            for (int i = 0; i < array.Length / 2; i++)
            {
                string currentElement = array[i];
                array[i] = array[array.Length - 1 - i];
                array[array.Length - 1 - i] = currentElement;
            }

            return array;
        }
    }
}