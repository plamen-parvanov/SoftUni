namespace _01.Sino_The_Walker
{
    using System;
    using System.Globalization;


    public class Program
    {

        public static void Main()
        {
            var inputLine = Console.ReadLine();
            var timeLeave = DateTime.ParseExact(inputLine, "HH:mm:ss", CultureInfo.InvariantCulture);
            var stepsTaken = long.Parse(Console.ReadLine());
            var secondsPerStep = long.Parse(Console.ReadLine());

            var secToArrive = secondsPerStep * stepsTaken % (24 * 60 * 60);
            var arriveTime = timeLeave.AddSeconds((double)secToArrive);

            Console.WriteLine("Time Arrival: {0}", arriveTime.ToString("HH:mm:ss")); 

        }
    }
}
