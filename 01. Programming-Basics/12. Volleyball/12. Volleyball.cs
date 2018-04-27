using System;


namespace _12.Volleyball
{
    class Program
    {
        static void Main(string[] args)
        {
            var year = Console.ReadLine();
            var p = int.Parse(Console.ReadLine());
            var h = int.Parse(Console.ReadLine());

            double gamesInSofia = (48 - h) * 3.0 / 4;
            double gamesOnHolydays = p * 2.0 / 3;
            double gamesPerYear = h + gamesInSofia + gamesOnHolydays;

            switch (year)
            {
                case "leap":
                    Console.WriteLine(Math.Floor(gamesPerYear + 0.15 * gamesPerYear));
                    break;

                case "normal":
                    Console.WriteLine(Math.Floor(gamesPerYear));
                    break;
            }
        }
    }
}
