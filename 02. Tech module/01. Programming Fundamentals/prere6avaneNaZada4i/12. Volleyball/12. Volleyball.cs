using System;


namespace _12.Volleyball
{
    class Program
    {
        static void Main(string[] args)
        {
            string year = Console.ReadLine();
            int holidays = int.Parse(Console.ReadLine());
            int weekendsHome = int.Parse(Console.ReadLine());
            double games = (48 - weekendsHome) * 3 / 4d + holidays * 2 / 3d + weekendsHome;
            games = year == "leap" ? games * 1.15 : games;
            Console.WriteLine("{0}", Math.Floor(games));
        }
    }
}
