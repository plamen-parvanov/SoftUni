namespace _01.Sino_The_Walker
{
    using System;
    using System.Text.RegularExpressions;

    public class Problem01
    {
        public static void Main()
        {
            var tickets = Console.ReadLine()
                               .Split(new[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);

            PrintWinningTickets(tickets);
        }

        private static void PrintWinningTickets(string[] tickets)
        {
            foreach (var ticket in tickets)
            {
                if (ticket.Length != 20)
                {
                    Console.WriteLine("invalid ticket");
                    continue;
                }

                var pattern = @"[^@#$^]*(@{6,10}|#{6,10}|\${6,10}|\^{6,10})[^@#$^]*\1[^@#$^]*";

                if (Regex.IsMatch(ticket, pattern))
                {
                    var winning = Regex.Match(ticket, pattern).Groups[1].Length;
                    var symbol = Regex.Match(ticket, pattern).Groups[1].Value[1];
                    Console.Write($"ticket \"{ticket}\" - {winning}{symbol}");
                    Console.WriteLine(winning == 10 ? " Jackpot!" : ""); 
                }
                else
                {
                    Console.WriteLine($"ticket \"{ticket}\" - no match");
                }
            }
        }
    }
}
