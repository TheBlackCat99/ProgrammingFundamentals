namespace CharacterStats
{
    using System;

    // From SoftUni Programming Fundamentals January 2018 - Exercises: C# Intro and Basic Syntax
    public class Program
    {
        /*
         * Program displaying information about a video game character. 
         * You will receive their name, current health, maximum health, current energy and maximum energy on separate lines. 
         * The current values will always be valid (equal or lower than their respective max values).
         * 
         * Example: 
         * Input	Output
            Toad    Name: Toad
            8       Health: |||||||||............|
            20      Energy: |..........|
            0
            10
         */
        public static void Main()
        {
            Console.Write("Character name: ");
            string characterName = Console.ReadLine();

            Console.Write("Current health: ");
            int currentHealth = int.Parse(Console.ReadLine());

            Console.Write("Max health: ");
            int maxHealth = int.Parse(Console.ReadLine());

            Console.Write("Current energy: ");
            int currentEnergy = int.Parse(Console.ReadLine());

            Console.Write("Max energy: ");
            int maxEnergy = int.Parse(Console.ReadLine());

            Console.WriteLine($"Name: {characterName}");

            Console.Write("Health: ");
            Console.Write(new string('|', currentHealth + 1));
            Console.Write(new string('.', maxHealth - currentHealth));
            Console.Write("|");

            Console.WriteLine();

            Console.Write("Energy: ");
            Console.Write(new string('|', currentEnergy + 1));
            Console.Write(new string('.', maxEnergy - currentEnergy));
            Console.Write("|");
        }
    }
}