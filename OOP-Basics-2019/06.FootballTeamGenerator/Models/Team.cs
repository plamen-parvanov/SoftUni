namespace _06.FootballTeamGenerator.Models
{
    using _06.FootballTeamGenerator.Errors;
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Team
    {
        private string name;
        private List<Player> players;

        public Team(string name)
        {
            this.players = new List<Player>();
            this.name = name;
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            private set
            {
                CheckForValidName(value);

                this.name = value;
            }
        }

        public int Rating
        {
            get
            {
                if (this.players.Count == 0)
                {
                    return 0;
                }

                return (int)Math.Round(this.players.Sum(p => p.AverageStats)) / this.NumberOfPlayers;

            }
        }
        private int NumberOfPlayers => this.players.Count;

        public void AddPlayer(Player player)
        {
            this.players.Add(player);
        }

        public void RemovePlayer(string playerName)
        {
            var playerToRemove = players.FirstOrDefault(p => p.Name == playerName);

            if (playerToRemove == null)
            {
                throw new ArgumentException(string.Format(
                    ErrorMessages.InvalidPlayerToRemove, playerName, this.name));
            }

            players.Remove(playerToRemove);
        }

        private void CheckForValidName(string value)
        {
            if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException(ErrorMessages.InvalidName);
            }
        }
    }
}
