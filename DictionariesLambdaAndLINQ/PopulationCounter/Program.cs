namespace PopulationCounter
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    // From SoftUni Programming Fundamentals January 2018 - Exercises: Dictionaries, Lambda and LINQ
    class Program
    {
        /*
         * On each input line, you’ll be given data in format: "city|country|population". There will be 
         * no redundant whitespaces anywhere in the input. Aggregate the data by country 
         * and by city and print it on the console. Input ends when the command "report" is received.
           For each country, print its total population and on separate lines, 
           the data for each of its cities. Countries should be ordered by their total population
           in descending order and within each country, the cities should be ordered by the same criterion.
         */
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split('|');

            var popCountriesAndCities = new Dictionary<string, Dictionary<string, long>>();

            while (input[0] != "report")
            {
                var city = input[0];
                var country = input[1];
                var population = long.Parse(input[2]);

                if (popCountriesAndCities.ContainsKey(country))
                {
                    popCountriesAndCities[country].Add(city, population);
                }
                else
                {
                    var cityPop = new Dictionary<string, long>();
                    cityPop.Add(city, population);
                    popCountriesAndCities.Add(country, cityPop);
                }

                input = Console.ReadLine().Split('|');
            }

            foreach (var country in popCountriesAndCities.OrderByDescending(x => x.Value.Values.Sum()))
            {
                Console.WriteLine($"{country.Key} (total population: {country.Value.Values.Sum()})");

                foreach (var city in country.Value.OrderByDescending(x => x.Value))
                {
                    Console.WriteLine($"=>{city.Key}: {city.Value}");
                }
            }

            // original soluiton that worked but it's longer and and redundant
            //var countriesDictionary = new Dictionary<string, long>();

            //foreach (var countryItem in popCountriesAndCities)
            //{
            //    long countryPop = 0;

            //    foreach (var cityItem in countryItem.Value.OrderByDescending(x => x.Value))
            //    {
            //        countryPop += cityItem.Value;
            //    }

            //    countriesDictionary.Add(countryItem.Key, countryPop);
            //}

            //foreach (var country in countriesDictionary.OrderByDescending(x => x.Value))
            //{
            //    Console.WriteLine($"{country.Key} (total population: {country.Value})");

            //    foreach (var current in popCountriesAndCities)
            //    {
            //        if (current.Key == country.Key)
            //        {
            //            foreach (var city in current.Value.OrderByDescending(x => x.Value))
            //            {
            //                Console.WriteLine($"=>{city.Key}: {city.Value}");
            //            }
            //        }
            //    }
            //}
        }
    }
}
