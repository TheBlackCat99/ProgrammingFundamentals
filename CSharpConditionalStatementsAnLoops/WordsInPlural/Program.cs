namespace WordsInPlural
{
    using System;

    // From SoftUni Programming Fundamentals January 2018 - Exercises: C# Conditional Statements and Loops
    public class Program
    {
        /*Write a program, which receives a noun and prints the noun in plural. You will receive one of the following cases: 
            •A noun that ends in y – remove the y and add ies
            •A noun that ends in o, ch, s, sh, x or z – add es at the end of the word
            •In all other cases – just add s at the end
         */
        public static void Main()
        {
            Console.Write("Noun: ");
            string noun = Console.ReadLine();

            string pluralNoun;
            string lastChar = noun.Substring(noun.Length - 1);
            string lastTwoChars = noun.Substring(noun.Length - 2);

            if (lastChar == "y")
            {
                pluralNoun = noun.Remove(noun.Length - 1);
                pluralNoun += "ies";
            }
            else if (lastChar == "o" || lastChar == "s" || lastChar == "x" || lastChar == "z" || lastTwoChars == "ch" || lastTwoChars == "sh")
            {
                pluralNoun = noun + "es";
            }
            else
            {
                pluralNoun = noun + "s";
            }

            Console.Write($"Plural: {pluralNoun}");
        }
    }
}
