namespace NeighbourWars
{
    using System;

    // From SoftUni Programming Fundamentals January 2018 - Exercises: C# Conditional Statements and Loops
    public class Program
    {
        /*
         * Gosho and Pesho have their own signature attacks – Gosho attacks with “Thunderous fist” on every even turn of the game 
         * and Pesho attacks with “Roundhouse kick” on every odd turn. You will receive how much damage these attacks do from the console.
         * Both players start with 100 Health points. On every third turn Pesho and Gosho restore 10 Health Points. 
         * Health points are restored after the attack is made.
         */
        public static void Main()
        {
            Console.Write("Pesho's damage: ");
            int peshosDamage = int.Parse(Console.ReadLine());
            int peshosHealth = 100;

            Console.Write("Gosho's damage: ");
            int goshosDamage = int.Parse(Console.ReadLine());
            int goshosHealth = 100;

            int numOfRounds = 0;
            string attackerName;

            while (true)
            {
                string defenderName;
                string attackName;
                int defenderHealth;

                numOfRounds++;

                if (numOfRounds % 2 == 1) // Pesho attacks at every odd round
                {
                    attackerName = "Pesho";
                    defenderName = "Gosho";
                    attackName = "Roundhouse kick";

                    defenderHealth = goshosHealth - peshosDamage;
                    goshosHealth -= peshosDamage;
                }
                else // Gosho attacks at every even round
                {
                    attackerName = "Gosho";
                    defenderName = "Pesho";
                    attackName = "Thunderous fist";

                    defenderHealth = peshosHealth - goshosDamage;
                    peshosHealth -= goshosDamage;
                }

                if (goshosHealth > 0 && peshosHealth > 0)
                {
                    Console.WriteLine($"{attackerName} used {attackName} and reduced {defenderName} to {defenderHealth} health.");
                }
                else
                {
                    break;
                }

                if (numOfRounds % 3 == 0)
                {
                    goshosHealth += 10;
                    peshosHealth += 10;
                }
            }

            Console.WriteLine($"{attackerName} won in {numOfRounds}th round.");
        }
    }
}