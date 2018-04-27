namespace ConsoleApplication4
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Player
    {
        private string name;
        private int points;

        public string Name
        {
            get { return this.name; }
            private set { this.name = value; }
        }
        public int Points
        {
            get { return this.points; }
            set { this.points = value; }
        }

        public Player(string name, int points)
        {
            this.Name = name;
            this.Points = points;
        }
    }

    public class Team
    {
        private string name;
        private Player currPlayer;
        private List<Player> players;

        public string Name
        {
            get { return this.name; }
            private set { this.name = value; }
        }
        public Player CurrPlayer
        {
            get { return this.currPlayer; }

            private set
            {
                this.currPlayer = value;
                if (true)
                {

                }
            }
        }
        public List<Player> Players
        {
            get { return this.players; }
            private set
            {
                if (players == null)
                {
                    players = new List<Player>();
                }
                else if (players.Contains(this.currPlayer))
                {
                    players.Remove(this.currPlayer);
                }

                players.Add(currPlayer);
            }
        }

        public Team(string name, Player player)
        {
            this.Name = name;
            this.CurrPlayer = player;
        }

        public int GetTotalPoints()
        {
            return players.Sum(x => x.Points);
        }

        public string GetTopPlayerName()
        {
            var ordered = players.OrderByDescending(p => p.Points).ToList();
            return ordered[0].Name;
        }
    }

    public class Program
    {
        public static List<Team> teams;

        public static void Main()
        {
            teams = new List<Team>();

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

                ReadLine(inputLine);
            }
        }

        public static void ReadLine(string input)
        {
            var splitLine = input.Split(new[] { '|' }, StringSplitOptions.RemoveEmptyEntries);

            string team;
            string player;
            var points = int.Parse(SplitString(splitLine[2]));

            var firstToken = SplitString(splitLine[0]);
            if (firstToken.ToUpper() == firstToken)
            {
                team = firstToken;
                player = SplitString(splitLine[1]);
            }
            else
            {
                team = SplitString(splitLine[1]);
                player = firstToken;
            }

            AddPlayerPointsToTheTeam(team, player, points);

        }

        public static string SplitString(string str)
        {
            var delimiter = "@%$*".ToCharArray();

            var arr = str.Split(delimiter, StringSplitOptions.None);
            return string.Join("", arr);
        }

        public static void AddPlayerPointsToTheTeam(string team, string playerName, int points)
        {
            var currPlayer = new Player(playerName, points);

            if (!teams.Any(t => t.Name == team))
            {
                teams.Add(new Team(team, currPlayer));
            }
            else
            {
                var index = teams.FindIndex(x => x.Name == team);
                teams[index].Players.Add(currPlayer);
            }

            
        }

        public static void PrintResult()
        {
            foreach (var team in teams.OrderByDescending(x => x.Players.Sum(y => y.Points)))
            {
                var teamName = team.Name;
                var totalSumOfPoints = team.GetTotalPoints();
                var nameTopPlayer = team.GetTopPlayerName();

                Console.WriteLine($"{teamName} => {totalSumOfPoints}");
                Console.WriteLine($"Most points scored by {nameTopPlayer}");
            }
        }
    }
}
