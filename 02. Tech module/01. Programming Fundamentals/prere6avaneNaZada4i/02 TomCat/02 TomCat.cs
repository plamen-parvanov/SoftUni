using System;


namespace _02_TomCat
{
    class Program
    {
        static void Main(string[] args)
        {
            int holidays = int.Parse(Console.ReadLine());

            int minutesPlay = (365 - holidays) * 63 + holidays * 127;

            if (minutesPlay > 30000)
            {
                Console.WriteLine("Tom will run away\n{0} hours and {1} minutes more for play",
                    (minutesPlay - 30000)/ 60, (minutesPlay - 30000) % 60);
            }
            else
            {
                Console.WriteLine("Tom sleeps well\n{0} hours and {1} minutes less for play",
                    (30000 - minutesPlay) / 60, (30000 - minutesPlay) % 60);
            }
        }
    }
}
