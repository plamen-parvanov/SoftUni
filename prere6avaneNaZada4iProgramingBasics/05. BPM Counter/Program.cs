using System;


namespace _05.BPM_Counter
{
    class Program
    {
        static void Main()
        {
            int beatsPerMinutes = int.Parse(Console.ReadLine());
            int beatsMade = int.Parse(Console.ReadLine());

            double bars = Math.Round(beatsMade / 4d, 1);

            int seconds = beatsMade * 60 / beatsPerMinutes;
            int minutes = 0;
            while (seconds >= 60)
            {
                seconds -= 60;
                minutes++;
            }
            Console.WriteLine("{0} bars - {1}m {2}s", bars, minutes, seconds);

        }
    }
}
