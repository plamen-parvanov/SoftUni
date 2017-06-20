namespace _07.Population_Counte
{

    using System;
    using System.Collections.Generic;
    using System.Linq;


    public class Dictionaries
    {

        public static void Main()
        {
            var inputArr = Console.ReadLine().Split('|').ToArray();

            var countriesPop = new Dictionary<string, Dictionary<string, long>>();

            var command = inputArr[0];

            while (command != "report")
            {
                var country = inputArr[1];
                var town = inputArr[0];
                var pop = long.Parse(inputArr[2]);

                if (!countriesPop.Keys.Contains(country))
                {
                    countriesPop[country] = new Dictionary<string, long>();
                }

                countriesPop[country][town] = pop;

                inputArr = Console.ReadLine().Split('|').ToArray();
                command = inputArr[0];

            }           

            foreach (var kv in countriesPop.OrderByDescending(kvp => kvp.Value.Select(v => v.Value).Sum())
                )         
            {
                Console.WriteLine("{0} (total population: {1})",
                    kv.Key, countriesPop[kv.Key].Values.Sum());


                foreach (var town in kv.Value.OrderByDescending(kvp => kvp.Value))
                {
                    Console.WriteLine($"=>{town.Key}: {town.Value}");
                }
                
            }
        }
    }
}
