namespace _06.FootballTeamGenerator.Models
{
    using _06.FootballTeamGenerator.Errors;
    using System;

    public class Stats
    {
        private const int MIN_VALUE = 0;
        private const int MAX_VALUE = 100;
        private const int STATS_COUNT = 5;

        private int endurance;
        private int sprint;
        private int dribble;
        private int passing;
        private int shooting;

        public Stats(int endurance, int sprint, int dribble, int passing, int shooting)
        {
            this.Endurance = endurance;
            this.Sprint = sprint;
            this.Dribble = dribble;
            this.Passing = passing;
            this.Shooting = shooting;
        }

        private int Endurance
        {
            get
            {
                return this.endurance;
            }
            set
            {
                CheckForValid(value, nameof(this.Endurance));

                this.endurance = value;
            }

        }

        private int Sprint
        {
            get
            {
                return this.sprint;
            }
            set
            {
                CheckForValid(value, nameof(this.Sprint));

                this.sprint = value;
            }

        }

        private int Dribble
        {
            get
            {
                return this.dribble;
            }
            set
            {
                CheckForValid(value, nameof(this.Dribble));

                this.dribble = value;
            }
        }

        private int Passing
        {
            get
            {
                return this.passing;
            }
            set
            {
                CheckForValid(value, nameof(this.Passing));

                this.passing = value;
            }
        }

        private int Shooting
        {
            get
            {
                return this.shooting;
            }
            set
            {
                CheckForValid(value, nameof(this.Shooting));

                this.shooting = value;
            }
        }

        public double AverageStats
        {
            get
            {
                return (this.endurance + this.sprint + this.dribble +
                        this.passing + this.shooting) / (double)STATS_COUNT;            
            }
        }

        private void CheckForValid(int value, string name)
        {
            if (value < MIN_VALUE || value > MAX_VALUE)
            {
                throw new ArgumentException(string.Format(
                    ErrorMessages.InvalidStatsValue, name, MIN_VALUE, MAX_VALUE));
            }
        }


    }
}
