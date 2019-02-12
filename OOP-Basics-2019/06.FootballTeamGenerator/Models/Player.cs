namespace _06.FootballTeamGenerator.Models
{
    using _06.FootballTeamGenerator.Errors;
    using System;

    public class Player
    {
        private string name;
        private Stats stats;

        public Player(string name, Stats stats)
        {
            this.Name = name;
            this.stats = stats;
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

        public double AverageStats => this.stats.AverageStats;

        private void CheckForValidName(string value)
        {
            if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException(ErrorMessages.InvalidName);
            }
        }
    }
}
