namespace HandsOfCards
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    // From SoftUni Programming Fundamentals January 2018 - Exercises: Dictionaries, Lambda and LINQ
    class Program
    {
        /*
         * You are given a sequence of people and for every person what cards he draws from the deck.
         * The input will be separate lines in the format:
            •	{personName}: {PT, PT, PT,… PT}
            Where P (2, 3, 4, 5, 6, 7, 8, 9, 10, J, Q, K, A) is the power of the card and T (S, H, D, C) is the type. 
        The input ends when a "JOKER" is drawn. The name can contain any ASCII symbol except ':'. 
        The input will always be valid and in the format described, there is no need to check it.
            A single person cannot have more than one card with the same power and type, if they draw such a card they discard it. 
        The people are playing with multiple decks. Each card has a value that is calculated by the power multiplied by the type. 
        Powers 2 to 10 have the same value and J to A are 11 to 14. Types are mapped to multipliers the following way 
        (S -> 4, H-> 3, D -> 2, C -> 1).
            Finally print out the total value each player has in his hand in the format:
            •	{personName}: {value}
         */
        static void Main(string[] args)
        {
            Console.Write("Player name and drawn cards or end of input: ");
            var input = Console.ReadLine().Split(':');
            var points = new Dictionary<string, int>(); // name of the player, points
            var hands = new Dictionary<string, List<string>>(); // name of the player, hands

            while (input[0] != "JOKER")
            {
                var playerName = input[0];
                var playerHands = input[1].Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries).Distinct().ToList();

                if (hands.ContainsKey(playerName))
                {
                    for (int i = 0; i < playerHands.Count; i++)
                    {
                        if (hands[playerName].Contains(playerHands[i]))
                        {
                            continue;
                        }

                        hands[playerName].Add(playerHands[i]);
                    }
                }
                else
                {
                    hands.Add(playerName, playerHands);
                }

                Console.Write("Player name and drawn cards or end of input: ");
                input = Console.ReadLine().Split(':');
            }

            foreach (var item in hands)
            {
                var playerName = item.Key;
                var playerHand = item.Value;
                int score = 0;

                for (int i = 0; i < playerHand.Count; i++)
                {
                    var power = "";

                    if (playerHand[i].Length == 3)
                    {
                        power = playerHand[i].Substring(0, 2);
                    }
                    else
                    {
                        power = playerHand[i].Substring(0, 1);
                    }

                    var type = playerHand[i].Last();

                    int cardScore;
                    int typeScore = 0;

                    switch (power)
                    {
                        case "J":
                            cardScore = 11;
                            break;
                        case "Q":
                            cardScore = 12;
                            break;
                        case "K":
                            cardScore = 13;
                            break;
                        case "A":
                            cardScore = 14;
                            break;
                        default:
                            cardScore = int.Parse(power);
                            break;
                    }

                    switch (type)
                    {
                        case 'S':
                            typeScore = 4;
                            break;
                        case 'H':
                            typeScore = 3;
                            break;
                        case 'D':
                            typeScore = 2;
                            break;
                        case 'C':
                            typeScore = 1;
                            break;
                    }

                    int currentScore = cardScore * typeScore;
                    score += currentScore;
                }

                points.Add(playerName, score);
            }

            foreach (var item in points)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
        }
    }
}