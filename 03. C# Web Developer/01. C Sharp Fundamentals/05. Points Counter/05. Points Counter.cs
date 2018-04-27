using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.Points_Counter
{
    public class Problem05
    {
        public static Dictionary<string, List<Player>> teams;
        public static void Main()
        {
            teams = new Dictionary<string, List<Player>>();

            ReadInput();

            PrintResult();
        }
        public static void ReadInput()
        {
            while (true)
            {
                var inputLine = Console.ReadLine();
                if (inputLine == "Result")
                {
                    break;
                }

                Read(inputLine);
            }
        }

        public static void Read(string input)
        {
            var arr = input.Split(new[] { '|' }, StringSplitOptions.RemoveEmptyEntries);
            
            var delimeter = "@%$*".ToCharArray();
            var team = string.Join("", 
                arr[0].Split(delimeter, StringSplitOptions.RemoveEmptyEntries));
            var player = string.Join("",
                arr[1].Split(delimeter, StringSplitOptions.RemoveEmptyEntries));

            if (team.ToUpper() != team )
            {
                var temp = team;
                team = player;
                player = temp;          
            }

            var points = int.Parse(arr[2]);

            AddTeamAndPlayer(team, player, points);
        }

        public static void AddTeamAndPlayer(string team, string player, int points)
        {
            if (!teams.ContainsKey(team))
            {
                teams[team] = new List<Player>();
            }

            var oldPlayer = teams[team].SingleOrDefault(p => p.Name == player);
            if (oldPlayer != null)
            {
                teams[team].Remove(oldPlayer);
            }

            // teams[team].RemoveAll(p => p.Name == player)  ili RemoveFirst

            teams[team].Add(new Player(player, points));
        }

        public static void PrintResult()
        {
            foreach (var team in teams.OrderByDescending(x => x.Value.Sum(y => y.Points)))
            {
                var teamName = team.Key;
                var totalPoints = team.Value.Sum(x => x.Points);
                Console.WriteLine($"{teamName} => {totalPoints}");

                var topPlayer = GetTopPlayer(team.Value);
                Console.WriteLine($"Most points scored by {topPlayer.Name}");
            }
        }

        public static Player GetTopPlayer(List<Player> players)
        {
            var ordered = players.OrderByDescending(x => x.Points).ToList(); // .First()
            return ordered[0]; 
        }
    }
}
