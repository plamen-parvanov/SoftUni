namespace _04._MOBA_Challenger
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Problem04
    {
        private static Dictionary<string, Dictionary<string, int>> dict;
        public static void Main()
        {
            ReadInput();

            PrintDict();
        }

        private static void PrintDict()
        {

            foreach (var player in dict.OrderByDescending(x => x.Value.Values.Sum())
                .ThenBy(x => x.Key))
            {
                var totalSkill = player.Value.Values.Sum();
                Console.WriteLine($"{player.Key}: {totalSkill} skill");

                foreach (var kvp in player.Value.OrderByDescending(x => x.Value)
                    .ThenBy(x => x.Key))
                {
                    Console.WriteLine($"- {kvp.Key} <::> {kvp.Value}");
                }
            }
        }

        private static void ReadInput()
        {
            dict = new Dictionary<string, Dictionary<string, int>>();

            while (true)
            {
                var inputLine = Console.ReadLine();

                if (inputLine == "Season end")
                {
                    break;
                }

                var arr = inputLine.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                if (arr[1] != "vs")
                {
                    AddInfoInDict(inputLine);

                    continue;
                }

                var spleted = inputLine.Split(new[] { " vs " }, StringSplitOptions.RemoveEmptyEntries)
                              .ToArray();
                var firstName = spleted[0];
                var secondName = spleted[1];

                if (TwoPlayersExists(firstName, secondName))
                {
                    Duel(firstName, secondName);
                }
                
            }
        }

        private static bool TwoPlayersExists(string firstName, string secondName)
        {
            return dict.ContainsKey(firstName) && dict.ContainsKey(secondName);
        }

        private static void Duel(string firstName, string secondName)
        {
            if (BothPlayersHaveAtLeastOneCommonPosition(firstName, secondName))
            {
                var firstPlrPoints = dict[firstName].Values.Sum();
                var secondPlrPoints = dict[secondName].Values.Sum();


                if (firstPlrPoints > secondPlrPoints)
                {
                    dict.Remove(secondName);
                }
                else if (secondPlrPoints > firstPlrPoints)
                {
                    dict.Remove(firstName);
                }              
            }
        }


        private static bool BothPlayersHaveAtLeastOneCommonPosition(
            string firstName, string secondName)
        {
            foreach (var positions in dict[firstName])
            {
                if (dict[secondName].ContainsKey(positions.Key))
                {
                    return true;
                }
            }

            return false;
        }

        private static void AddInfoInDict(string input)
        {
            var arr = input.Split(new[] { " -> " }, StringSplitOptions.RemoveEmptyEntries)
                           .ToArray();
            var name = arr[0];
            var position = arr[1];
            var skill = int.Parse(arr[2]);

            if (!dict.ContainsKey(name))
            {
                dict[name] = new Dictionary<string, int>();
            }

            if (!dict[name].ContainsKey(position))
            {
                dict[name][position] = skill;
                return;
            }

            if (skill > dict[name][position])
            {
                dict[name][position] = skill;
            }

        }
    }
}
