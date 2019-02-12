namespace _06.FootballTeamGenerator
{
    using _06.FootballTeamGenerator.Errors;
    using _06.FootballTeamGenerator.Models;
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        private static List<Team> teams;
        public static void Main()
        {
            ReadInput();
        }

        private static void ReadInput()
        {
            teams = new List<Team>();

            string command;
            while ((command = Console.ReadLine()) != "END")
            {
                try
                {
                    Execute(command);
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }

        private static void Execute(string input)
        {
            var arr = input.Split(new[] { ';' }, StringSplitOptions.RemoveEmptyEntries);
            var command = arr[0];

            switch (command)
            {
                case "Team":
                    CreateTeam(arr.Skip(1).ToArray());
                    break;
                case "Add":
                    AddPlayer(arr.Skip(1).ToArray());
                    break;
                case "Remove":
                    RemovePlayer(arr.Skip(1).ToArray());
                    break;
                case "Rating":
                    PrintRating(arr.Skip(1).ToArray());
                    break;
                default:
                    break;
            }
        }

        private static void PrintRating(string[] arr)
        {
            var team = GetTeam(arr);

            Console.WriteLine($"{team.Name} - {team.Rating}");
        }

        private static void RemovePlayer(string[] arr)
        {
            var team = GetTeam(arr);

            team.RemovePlayer(arr.Skip(1).ToArray().FirstOrDefault());
        }

        private static void AddPlayer(string[] arr)
        {
            var team = GetTeam(arr);

            var player = CreatePlayer(arr.Skip(1).ToArray());

            team.AddPlayer(player);
        }

        private static Team GetTeam(string[] arr)
        {
            var teamName = arr.FirstOrDefault();

            var team = teams.FirstOrDefault(t => t.Name == teamName);
            if (team == null)
            {
                throw new ArgumentException(
                    string.Format(ErrorMessages.InvalidTeam, teamName));
            }

            return team;
        }

        private static Player CreatePlayer(string[] arr)
        {
            var playerName = arr[0];

            var intArr = arr.Skip(1).Select(int.Parse).ToArray();
            var stats = new Stats(intArr[0], intArr[1], intArr[2], intArr[3], intArr[4]);

            return new Player(playerName, stats);
        }

        private static void CreateTeam(string[] arr)
        {
            var teamName = arr.FirstOrDefault();

            var team = new Team(teamName);

            teams.Add(team);
        }
    }
}
