namespace _04.Champions_League
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Problem04
    {
        private static Dictionary<string, int> teams;
        private static Dictionary<string, List<string>> opponents;

        public static void Main()
        {
            ReadInput();

            PrintAllTeams();
        }

        private static void PrintAllTeams()
        {
            foreach (var team in teams.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                var name = team.Key;
                var wins = team.Value;
                var allOpponents = string.Join(", ", opponents[name].OrderBy(x => x));

                Console.WriteLine($"{name}");
                Console.WriteLine($"- Wins: {wins}");
                Console.WriteLine($"- Opponents: {allOpponents}");
            }
        }

        private static void ReadInput()
        {
            teams = new Dictionary<string, int>();
            opponents = new Dictionary<string, List<string>>();

            while (true)
            {
                var inputLine = Console.ReadLine();
                if (inputLine == "stop")
                {
                    break;
                }

                AddInfoInDict(inputLine);
            }
        }

        private static void AddInfoInDict(string input)
        {
            var arr = input.Split(new[] { " | " }, StringSplitOptions.RemoveEmptyEntries);
            var firstTeam = arr[0];
            var secondTeam = arr[1];

            if (!teams.ContainsKey(firstTeam))
            {
                teams[firstTeam] = 0;
                opponents[firstTeam] = new List<string>();
            }

            if (!teams.ContainsKey(secondTeam))
            {
                teams[secondTeam] = 0;
                opponents[secondTeam] = new List<string>();
            }

            opponents[firstTeam].Add(secondTeam);
            opponents[secondTeam].Add(firstTeam);

            var winner = FindsWinner(arr);

            if (winner == firstTeam)
            {
                teams[firstTeam]++;
                return;
            }

            teams[secondTeam]++;

        }

        private static string FindsWinner(string[] arr)
        {
            var firstMatch = GetGoals(arr[2]);
            var secondMatch = GetGoals(arr[3]);

            var firstTeam = arr[0];
            var firstTeamHomeGals = firstMatch[0];
            var firstTeamAwayGoals = secondMatch[1];
            var firstTeamTotalsGoals = firstTeamHomeGals + firstTeamAwayGoals;

            var secondTeam = arr[1];
            var secondTeamHomeGoals = secondMatch[0];
            var secondTeamAwayGoals = firstMatch[1];
            var secondTeamTotalGoals = secondTeamHomeGoals + secondTeamAwayGoals;

            if (firstTeamTotalsGoals > secondTeamTotalGoals)
            {
                return firstTeam;
            }
            else if (secondTeamTotalGoals > firstTeamTotalsGoals)
            {
                return secondTeam;
            }
            else if (firstTeamAwayGoals > secondTeamAwayGoals)
            {
                return firstTeam;
            }

            return secondTeam;
        }

        private static int[] GetGoals(string input)
        {
            return input
                .Split(new[] { ':' }, StringSplitOptions
                .RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
        }
    }
}
