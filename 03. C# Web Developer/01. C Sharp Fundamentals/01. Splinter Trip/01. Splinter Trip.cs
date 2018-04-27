namespace _01.Splinter_Trip
{
    using System;

    public class Problem01
    {
        public static void Main()
        {
            var distance = double.Parse(Console.ReadLine());
            var tank = double.Parse(Console.ReadLine());
            var milesInWind = double.Parse(Console.ReadLine());

            var literInNonWind = (distance - milesInWind) * 25;
            var litersInWind = milesInWind * 25 * 1.5;
            var neededFuel = (litersInWind + literInNonWind) * 1.05;

            Console.WriteLine($"Fuel needed: {Math.Round(neededFuel, 2, MidpointRounding.AwayFromZero):F2}L");

            if (tank >= neededFuel)
            {
                var remainingFuel = Math.Round(tank - neededFuel, 2, MidpointRounding.AwayFromZero);
                Console.WriteLine($"Enough with {remainingFuel:F2}L to spare!");
            }
            else
            {
                var fuelNeeded = Math.Round(neededFuel - tank, 2, MidpointRounding.AwayFromZero);
                Console.WriteLine($"We need {fuelNeeded:F2}L more fuel.");
            }
        }
    }
}
