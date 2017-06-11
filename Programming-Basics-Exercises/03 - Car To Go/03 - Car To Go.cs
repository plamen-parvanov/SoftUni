using System;


namespace _03___Car_To_Go
{
    class Program
    {
        static void Main(string[] args)
        {
            var budget = double.Parse(Console.ReadLine());
            var season = Console.ReadLine().ToLower();
            string classs;
            string car = "";

            if (budget > 500)
            {
                classs = "Luxury class";
                car = "Jeep";
                budget *= 0.9;
            }
            else if (budget > 100)
            {
                classs = "Compact class";
                if (season == "summer")
                {
                    car = "Cabrio";
                    budget *= 0.45;
                }
                else if (season == "winter")
                {
                    car = "Jeep";
                    budget *= 0.8;
                }

            }
            else
            {
                classs = "Economy class";
                if (season == "summer")
                {
                    car = "Cabrio";
                    budget *= 0.35;
                }
                else if (season == "winter")
                {
                    car = "Jeep";
                    budget *= 0.65;
                }
            }

            Console.WriteLine(classs);
            Console.Write(car);
            Console.WriteLine(" - {0:f2}", budget);

        }
    }
}
