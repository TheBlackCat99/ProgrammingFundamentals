namespace LegendaryFarming
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    // From SoftUni Programming Fundamentals January 2018 - Exercises: Dictionaries, Lambda and LINQ
    class Program
    {
        /*
         * The possible items are:
            •	Shadowmourne – requires 250 Shards;
            •	Valanyr – requires 250 Fragments;
            •	Dragonwrath – requires 250 Motes;
           Shards, Fragments and Motes are the key materials, all else is junk. You will be given lines of input, 
        such as 2 motes 3 ores 15 stones. Keep track of the key materials - the first that reaches
        the 250 mark wins the race. At that point, print the corresponding legendary obtained. 
        Then, print the remaining shards, fragments, motes, ordered by quantity in descending order, 
        then by name in ascending order, each on a new line. Finally, print the collected junk items,
        in alphabetical order.
         */
        static void Main(string[] args)
        {
            var junkMaterials = new SortedDictionary<string, int>();
            var valuableMaterials = new Dictionary<string, int>();

            valuableMaterials.Add("shards", 0);
            valuableMaterials.Add("fragments", 0);
            valuableMaterials.Add("motes", 0);

            while (!valuableMaterials.Any(x => x.Value >= 250))
            {
                var input = Console.ReadLine().Split(' ');

                for (int i = 0; i < input.Length; i += 2)
                {
                    var count = int.Parse(input[i]);
                    var material = input[i + 1].ToLower();

                    switch (material)
                    {
                        case "shards":
                        case "fragments":
                        case "motes":
                            valuableMaterials[material] += count;
                            break;
                        default:
                            if (junkMaterials.ContainsKey(material))
                            {
                                junkMaterials[material] += count;
                            }
                            else
                            {
                                junkMaterials.Add(material, count);
                            }
                            break;
                    }

                    if (valuableMaterials.Any(x => x.Value >= 250))
                    {
                        break;
                    }
                }
            }

            Print(valuableMaterials, junkMaterials);
        }

        static void Print(Dictionary<string, int> valuableMaterials,
            SortedDictionary<string, int> junkMaterials)
        {
            // only the first element with the highest value is needed
            var collectedItems = valuableMaterials.OrderByDescending(x => x.Value).First();
            var element = collectedItems.Key;
            valuableMaterials[element] -= 250;

            switch (element)
            {
                case "shards":
                    Console.WriteLine("Shadowmourne obtained!");
                    break;
                case "fragments":
                    Console.WriteLine("Valanyr obtained!");
                    break;
                case "motes":
                    Console.WriteLine("Dragonwrath obtained!");
                    break;
            }

            foreach (var item in valuableMaterials.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }

            foreach (var item in junkMaterials)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
        }
    }
}