using System;


namespace Problem_03___Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            string location = "";
            string place;

            if (budget > 3000)
            {
                switch (season)
                {
                    case "Summer":
                        location = "Alaska";
                        break;
                    case "Winter":
                        location = "Morocco";
                        break;
                }
                budget *= 0.9;
                place = "Hotel";
            }
            else if (budget > 1000)
            {
                place = "Hut";
                switch (season)
                {
                    case "Summer":
                        location = "Alaska";
                        budget *= 0.8;
                        break;
                    case "Winter":
                        location = "Morocco";
                        budget *= 0.6;
                        break;
                }
            }
            else
            {
                place = "Camp";
                switch (season)
                {
                    case "Summer":
                        location = "Alaska";
                        budget *= 0.65;
                        break;
                    case "Winter":
                        location = "Morocco";
                        budget *= 0.45;
                        break;
                }
            }
            Console.WriteLine("{0} - {1} - {2:f2}", location, place, budget);
        }
    }
}
