namespace _08.Traveling_At_Light_Speed
{

    using System;


    public class Problem08
    {

        public static void Main()
        {
            // 1 light year == 9 450 000 000 000 km
            // speed of light == 300 000 km / second
            // S = V * t
            // 1 week = 7 days = 168 hours = 10 080 min = 604 800 sec (1 * 7 * 24 * 60 * 60)

            var lightYearsInKm = double.Parse(Console.ReadLine()) * 9450000000000;
            var timeInSec = (long)lightYearsInKm / 300000;

            var min = timeInSec / 60;
            var hours = min / 60;
            var days = hours / 24;
            var weeks = days / 7;

            Console.WriteLine("{0} weeks", weeks);
            Console.WriteLine("{0} days", days % 7);
            Console.WriteLine("{0} hours", hours % 24);           
            Console.WriteLine("{0} minutes", min % 60);
            Console.WriteLine("{0} seconds", timeInSec % 60);

            //var weeks = timeInSec / secInOneWeek;
            //Console.WriteLine($"{weeks} weeks");

            //timeInSec -= weeks * secInOneWeek;
            //var days = timeInSec / secInOneDay;
            //Console.WriteLine($"{days} days");

            //timeInSec -= days * secInOneDay;
            //var hours = timeInSec / secInOneHour;
            //Console.WriteLine($"{hours} hours");

            //timeInSec -= hours * secInOneHour;
            //var min = timeInSec / secInOneMin;
            //Console.WriteLine($"{min} minutes");

            //var sec = timeInSec % 60;
            //Console.WriteLine($"{sec} seconds");



        }
    }
}
