namespace _04_SoftUni_Beer_Pong
{

    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Problem04
    {

        public static void Main()
        {
            var dict = new Dictionary<string, Dictionary<string, long>>();

            while (true)
            {
                var input = Console.ReadLine();
                if (input == "stop the game")
                {
                    break;
                }

                var arr = input.Split(new[] { '|' }, StringSplitOptions.RemoveEmptyEntries);
                var playerName = arr[0];
                var teamName = arr[1];
                var playerPoints = long.Parse(arr[2]);

                if (!dict.Keys.Contains(teamName))
                {
                    dict[teamName] = new Dictionary<string, long>();
                }

                if (dict[teamName].Keys.Count < 3)
                {
                    dict[teamName][playerName] = playerPoints;
                }
            }
            
            var sorted = dict
                .Where(v => v.Value.Count() > 2)
                .OrderByDescending(v => v.Value.Values.Sum())
                .ToDictionary(k => k.Key, v => v.Value);

            var cntr = 0;

            foreach (var kvp in sorted)
            {
                cntr++;
                Console.WriteLine($"{cntr}. {kvp.Key}; Players:");

                foreach (var kvp2 in kvp.Value.OrderByDescending(v => v.Value))
                {
                    Console.WriteLine($"###{kvp2.Key}: {kvp2.Value}");
                }
                
            }
        }
    }
}
