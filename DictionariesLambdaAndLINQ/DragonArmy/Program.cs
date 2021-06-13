namespace DragonArmy
{
    using System;
    using System.Collections.Generic;

    // From SoftUni Programming Fundamentals January 2018 - Exercises: Dictionaries, Lambda and LINQ
    class Program
    {
        /*
         * You need to categorize dragons by their type. For each dragon, identified by name, keep information 
         * about his stats. Type is preserved as in the order of input, but dragons are sorted alphabetically 
         * by name. For each type, you should also print the average damage, health and armor of the dragons. 
         * For each dragon, print his own stats. There may be missing stats in the input, though. 
         * If a stat is missing you should assign it default values. Default values are as follows: 
         * health 250, damage 45, and armor 10. Missing stat will be marked by null.
         * The input is in the following format {type} {name} {damage} {health} {armor}. 
         * Any of the integers may be assigned null value. If the same dragon is added a second time, 
         * the new stats should overwrite the previous ones. Two dragons are considered equal 
         * if they match by both name and type.
         */
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var dragons = new Dictionary<string, SortedDictionary<string, List<int>>>();

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split(' ');
                var type = input[0];
                var name = input[1];
                var damage = 45;
                var health = 250;
                var armour = 10;

                // could be done with var isNum = int.TryParse(input[3], out varName)

                if (input[2] != "null")
                {
                    damage = int.Parse(input[2]);
                }
                if (input[3] != "null")
                {
                    health = int.Parse(input[3]);
                }
                if (input[4] != "null")
                {
                    armour = int.Parse(input[4]);
                }

                if (!dragons.ContainsKey(type))
                {
                    var stats = new List<int>();
                    stats.Add(damage);
                    stats.Add(health);
                    stats.Add(armour);

                    var newDragon = new SortedDictionary<string, List<int>>();
                    newDragon.Add(name, stats);

                    dragons.Add(type, newDragon);
                }
                else
                {
                    if (dragons[type].ContainsKey(name))
                    {
                        dragons[type].Remove(name);
                    }

                    var stats = new List<int>();
                    stats.Add(damage);
                    stats.Add(health);
                    stats.Add(armour);

                    var newDragon = new SortedDictionary<string, List<int>>();
                    newDragon.Add(name, stats);

                    dragons[type].Add(name, stats);
                }
            }

            foreach (var dragonType in dragons)
            {
                var damage = 0;
                var health = 0;
                var armour = 0;

                foreach (var dragonName in dragonType.Value)
                {
                    damage += dragonName.Value[0];
                    health += dragonName.Value[1];
                    armour += dragonName.Value[2];
                }

                var dragonCount = dragons[dragonType.Key].Count;

                var avgDamage = (double)damage / dragonCount;
                var avgHealth = (double)health / dragonCount;
                var avgArmour = (double)armour / dragonCount;

                Console.WriteLine($"{dragonType.Key}::({avgDamage:F2}/{avgHealth:F2}/{avgArmour:F2})");

                foreach (var dragonName in dragonType.Value)
                {
                    Console.WriteLine($"-{dragonName.Key} -> " +
                        $"damage: {dragonName.Value[0]}, " +
                        $"health: {dragonName.Value[1]}, " +
                        $"armor: {dragonName.Value[2]}");
                }
            }
        }
    }
}
