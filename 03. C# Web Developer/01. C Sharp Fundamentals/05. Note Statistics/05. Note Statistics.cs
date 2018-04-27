namespace _05.Note_Statistics
{

    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Problem05
    {

        public static void Main()
        {
            var noteList = new List<string>()
                {
                     "C", "C#", "D", "D#", "E", "F", "F#", "G", "G#", "A", "A#", "B"
                };

            var frqncList = new List<double>()
            {
                261.63, 277.18, 293.66, 311.13, 329.63, 349.23, 369.99, 392.00, 415.30, 440.00, 466.16, 493.88
            };

            var inputList = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse)
                .ToList();

            var notes = new List<string>();
            var naturals = new List<string>();
            var sharps = new List<string>();
            var sumNaturals = 0d;
            var sumSharps = 0.0;

            foreach (var freqnc in inputList)
            {
                var currNote = noteList[frqncList.IndexOf(freqnc)];
                notes.Add(currNote);

                if (currNote.Length == 1 )
                {
                    naturals.Add(currNote);
                    sumNaturals += freqnc;
                }
                else
                {
                    sharps.Add(currNote);
                    sumSharps += freqnc;
                }
            }

            Console.WriteLine("Notes: {0}", string.Join(" ", notes));
            Console.WriteLine("Naturals: {0}", string.Join(", ", naturals));
            Console.WriteLine("Sharps: {0}", string.Join(", ", sharps));
            Console.WriteLine("Naturals sum: {0}", Math.Round(sumNaturals, 2));
            Console.WriteLine("Sharps sum: {0}", Math.Round(sumSharps, 2));
        }
    }
}
