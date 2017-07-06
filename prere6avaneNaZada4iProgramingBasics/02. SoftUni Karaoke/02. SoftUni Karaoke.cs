namespace _02.SoftUni_Karaoke
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {

        public static void Main()
        {
            var candidatList = Console.ReadLine()
                .Split(new[] { ", " }, StringSplitOptions.RemoveEmptyEntries)
                .ToList();
            var songList = Console.ReadLine()
                .Split(new[] { ", "}, StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            var cntr = 0;      

            var namesAndAwards = new Dictionary<string, HashSet<string>>();

            var inputLine = Console.ReadLine();

            while (!inputLine.Equals("dawn"))
            {
                var candidateInfo = inputLine
                    .Split(new[] { ", " }, StringSplitOptions.RemoveEmptyEntries)
                    .ToList();

                AddingCandidatesAwards(ref cntr, candidateInfo, namesAndAwards,
                    candidatList, songList);

                inputLine = Console.ReadLine();

            }

            var ordered = namesAndAwards.OrderByDescending(a => a.Value.Count)
                .ThenBy(n => n.Key);

            foreach (var candidate in ordered)
            {
                Console.WriteLine("{0}: {1} awards", candidate.Key, candidate.Value.Count);
                var awards = candidate.Value.OrderBy(n => n);
                foreach (var songAward in awards)
                {
                     
                    Console.WriteLine("--{0}", songAward);
                }
            }

            if (cntr == 0)
            {
                Console.WriteLine("No awards");
            }
        }

        public static void AddingCandidatesAwards(ref int cntr, List<string> candidateInfo,
            Dictionary<string, HashSet<string>> namesAndAwards,
             List<string> candidatList, List<string> songList)
        {
            var name = candidateInfo[0];
            var song = candidateInfo[1];
            var award = candidateInfo[2];

            if (candidatList.Contains(name) && songList.Contains(song))
            {
                if (!namesAndAwards.ContainsKey(name))
                {
                    namesAndAwards[name] = new HashSet<string>();
                    cntr++;
                }

                namesAndAwards[name].Add(award);
            }

        }
    }
}
