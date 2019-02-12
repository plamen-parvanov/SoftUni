namespace _05.Mordor_sCruelPlan
{
    using _05.Mordor_sCruelPlan.Factories;
    using System;

    public class StartUp
    {
        public static void Main()
        {
            var inputLine = Console.ReadLine();

            var mood = MoodFactory.CreateMood(inputLine);

            Console.WriteLine(mood.ToString());
        }
    }
}
