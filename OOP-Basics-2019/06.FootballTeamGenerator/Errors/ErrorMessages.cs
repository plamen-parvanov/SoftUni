namespace _06.FootballTeamGenerator.Errors
{
    public static class ErrorMessages
    {
        public static string InvalidStatsValue => "{0} should be between {1} and {2}.";
        public static string InvalidName => "A name should not be empty.";
        public static string InvalidPlayerToRemove => "Player {0} is not in {1} team.";
        public static string InvalidTeam => "Team {0} does not exist.";
    }
}
