namespace _03.Travel_Company
{

    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Problem03
    {

        public static void Main()
        {
            var dict = new Dictionary<string, Dictionary<string, int>>();            

            while (true)
            {
                var inputLine = Console.ReadLine();

                if (inputLine == "ready")
                {
                    break;
                }

                AddVehicleByTown(inputLine, dict);
            }

            while (true)
            {
                var inputLine = Console.ReadLine();

                if (inputLine == "travel time!")
                {
                    break;
                }

                var inputArr = inputLine.Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries);
                var city = inputArr[0];
                var passengers = int.Parse(inputArr[1]);

                PrintCapacityStatus(city, passengers, dict);
            }

        }

        public static void AddVehicleByTown(
            string input, Dictionary<string, Dictionary<string, int>> dict)
        {
            //{city}:{type}-{capacity},{type}-{capacity}…

            var inputArr = input.Split(new[] { ':' }, StringSplitOptions.RemoveEmptyEntries);
            var city = inputArr[0];
            var typeAndCap = inputArr[1].Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries);

            if (!dict.ContainsKey(city))
            {
                dict[city] = new Dictionary<string, int>();
            }

            AddTypeAndCapacityFor(city, typeAndCap, dict);
        }

        public static void AddTypeAndCapacityFor(
            string city, string[] typeAndCap, Dictionary<string, Dictionary<string, int>> dict)
        {
            foreach (var kvp in typeAndCap)
            {
                var currKvp = kvp.Split(new[] { '-' }, StringSplitOptions.RemoveEmptyEntries);
                var type = currKvp[0];
                var capacity = int.Parse(currKvp[1]);

                if (!dict[city].ContainsKey(type))
                {
                    dict[city][type] = 0;
                }

                dict[city][type] = capacity;
            }

        }

        public static void PrintCapacityStatus(
            string city, int pass, Dictionary<string, Dictionary<string, int>> dict)
        {
            var totalCapacity = dict[city].Values.Sum();

            if (pass <= totalCapacity)
            {
                Console.WriteLine($"{city} -> all {pass} accommodated");
            }
            else
            {
                Console.WriteLine("{0} -> all except {1} accommodated",
                    city, pass - totalCapacity);
            }
        }
    }
}
