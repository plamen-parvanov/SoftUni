using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;


namespace _03.Football_League
{
    class Program
    {
        static void Main(string[] args)
        {
            var key = Console.ReadLine();
            var league = new Dictionary<string, decimal>();
            var goals = new Dictionary<string, decimal>();

            while (true)
            {
                var inputLine = Console.ReadLine();
                if (inputLine.Equals("final"))
                {
                    break;
                }

                var keyEscaped = GetKey(key);

                var patternTeams = $@"{keyEscaped}*[a-zA-Z]*{keyEscaped}*";
                var regexTeams = new Regex(patternTeams);
                var matches = regexTeams.Matches(inputLine);

                var homeTeam = GetTeamName(matches[0], key);
                var awayTeam = GetTeamName(matches[1], key);

                var patternScore = @"(\d+)(:)(\d+)";
                var regexScore = new Regex(patternScore);
                var scores = regexScore.Matches(inputLine);

                var homeScore = GetScore(scores, 1);
                var awayScore = GetScore(scores, 3);

                var homePoints = 0;
                var awayPoints = 0;

                if (homeScore == awayScore)
                {
                    homePoints = 1;
                    awayPoints = 1;
                }
                else if (homeScore > awayScore)
                {
                    homePoints = 3;
                    awayPoints = 0;
                }
                else
                {
                    homePoints = 0;
                    awayPoints = 3;
                }

                if (!league.ContainsKey(homeTeam))
                {
                    league[homeTeam] = 0;
                }

                if (!league.ContainsKey(awayTeam))
                {
                    league[awayTeam] = 0;
                }

                league[homeTeam] += homePoints;
                league[awayTeam] += awayPoints;

                if (!goals.ContainsKey(homeTeam))
                {
                    goals[homeTeam] = 0;
                }

                if (!goals.ContainsKey(awayTeam))
                {
                    goals[awayTeam] = 0;
                }

                goals[homeTeam] += homeScore;
                goals[awayTeam] += awayScore;

            }

            

            PrintLeagueTable(league);

            PrintGoals(goals);

        }

        public static void PrintLeagueTable(Dictionary<string, decimal> league)
        {
            Console.WriteLine("League standings:");

            var cntr = 1;
            var leagueOrdered = league.OrderByDescending(p => p.Value).ThenBy(n => n.Key);

            foreach (var team in leagueOrdered)
            {

                Console.WriteLine($"{cntr}. {team.Key} {team.Value}");
                cntr++;
            }
        }

        public static string GetTeamName(Match match, string key)
        {
            var team = match.ToString()
                        .ToUpper()
                        .Substring(key.Length, match.Length - 2 * (key.Length))
                        .Reverse()
                        .ToArray();

            var teamStr = string.Empty;
            for (int i = 0; i < team.Length; i++)
            {
                teamStr += team[i];
            }

            return teamStr;
        }

        public static string GetKey(string key)
        {
            var keyEscaped = string.Empty;
            var escapeSymbols = "?%@;*";
            for (int i = 0; i < key.Length; i++)
            {
                if (escapeSymbols.Contains(key[i]))
                {
                    keyEscaped += @"\" + key[i];
                }
                else
                {
                    keyEscaped += key[i];
                }
            }

            return keyEscaped;
        }

        public static int GetScore(MatchCollection scores, byte i)
        {
            var score = 0;
            foreach (Match item in scores)
            {
                score = int.Parse(item.Groups[i].Value);
            }
            return score;
        }

        public static void PrintGoals(Dictionary<string, decimal> goals)
        {
            Console.WriteLine("Top 3 scored goals:");

            var goalsOrdered = goals.OrderByDescending(g => g.Value).ThenBy(n => n.Key);
            var cntr = 0;

            foreach (var goalScored in goalsOrdered)
            {
                if (cntr > 2)
                {
                    return;
                }
                cntr++;
                Console.WriteLine($"- {goalScored.Key} -> {goalScored.Value}");
            }


        }
    }
}
