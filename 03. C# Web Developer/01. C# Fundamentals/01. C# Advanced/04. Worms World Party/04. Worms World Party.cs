namespace _04.Worms_World_Party
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Problem04
    {
        public static Dictionary<string, Dictionary<string, long>> dict;
        public static HashSet<string> hash;
        public static void Main()
        {
            dict = new Dictionary<string, Dictionary<string, long>>();
            hash = new HashSet<string>();

            ReadInput();

            PrintResult();
        }

        private static void ReadInput()
        {
            while (true)
            {
                var inputLine = Console.ReadLine();
                if (inputLine == "quit")
                {
                    break;
                }

                ReadLine(inputLine);
            }
        }

        private static void ReadLine(string input)
        {
            var arr = input.Split(new[] { " -> " }, StringSplitOptions.RemoveEmptyEntries);
            var wormName = arr[0];
            if (hash.Contains(wormName))
            {
                return;
            }

            hash.Add(wormName);

            var team = arr[1];
            var score = long.Parse(arr[2]);

            if (!dict.ContainsKey(team))
            {
                dict[team] = new Dictionary<string, long>();
            }

            dict[team][wormName] = score;
        }

        private static void PrintResult()
        {
            var cntr = 1;

            foreach (var team in dict.OrderByDescending(x => x.Value.Values.Sum())
                                     .ThenByDescending(x => x.Value.Values.Sum() / x.Value.Count))
            {
                var teamName = team.Key;
                var totalScore = team.Value.Values.Sum();
                Console.WriteLine($"{cntr}. Team: {teamName} - {totalScore}");

                foreach (var worm in team.Value.OrderByDescending(x => x.Value))
                {
                    var wormName = worm.Key;
                    var wormScore = worm.Value;
                    Console.WriteLine($"###{wormName} : {wormScore}");
                }

                cntr++;
            }
        }
    }
}
