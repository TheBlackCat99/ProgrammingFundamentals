using System;
using System.Collections.Generic;

namespace ImmuneSystem
{
    // From SoftUni Programming Fundamentals January 2018 - More Exercises: Dictionaries, Lambda and LINQ
    class Program
    {
        /*
         * An organism can encounter different types of viruses. It stores them in its immune system. 
         * If it has already encountered the virus, it fights it faster than if it hasn’t encountered it yet.
        The immune system can calculate the virus’ strength before it fights it. It is the sum of all 
        the virus name’s letters’ ASCII codes, divided by 3.
        The immune system can also calculate the time it takes to defeat a virus in seconds. 
        It is equal to the virus strength, multiplied by the length of the virus’ name.
        When you calculate the time to defeat the virus, convert it to minutes and seconds (500 -> 8m 20s). 
        Do not use any leading zeroes for the minutes and seconds.
        The virus is fought according to these conditions:
        - If the immune system defeats the virus, print:
        “{virusName} defeated in {virusDefeatMinutes}m {virusDefeatSeconds}s.”
        - If the virus’ strength is more than the immune system’s strength, print “Immune System Defeated.”
        and exit the program.
        After a virus is defeated, the immune system regains 20% of its strength. If the 20 percent exceeds 
        the initial health of the immune system, set it to the initial health instead.
         */
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var initialHealth = int.Parse(input);
            var health = initialHealth;
            input = Console.ReadLine();
            var viruses = new List<string>();

            while (input != "end" && health > 0)
            {
                var letterSum = 0;

                foreach (var letter in input)
                {
                    letterSum += letter;
                }

                var virusStrength = letterSum / 3;
                var timeToDefeat = virusStrength * input.Length;

                if (!viruses.Contains(input))
                {
                    viruses.Add(input);
                }
                else
                {
                    timeToDefeat /= 3;
                }

                Console.WriteLine($"Virus {input}: {virusStrength} => {timeToDefeat} seconds");

                var seconds = timeToDefeat % 60;
                var minutes = timeToDefeat / 60;
                var timeToDefeatInMin = $"{minutes}m {seconds}s";

                health -= timeToDefeat;

                if (health > 0)
                {
                    Console.WriteLine($"{input} defeated in {timeToDefeatInMin}.");
                    Console.WriteLine($"Remaining health: {health}");

                    health += (int)(health * 0.20);

                    if (health > initialHealth)
                    {
                        health = initialHealth;
                    }
                }
                else
                {
                    health = -1;
                }

                input = Console.ReadLine();
            }

            if (health > 0)
            {
                Console.WriteLine($"Final Health: {health}");
            }
            else
            {
                Console.WriteLine($"Immune System Defeated.");
            }
        }
    }
}
