using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.SleepyCatTom
{
    class Program
    {
        static void Main(string[] args)
        {
           

            var holydays = int.Parse(Console.ReadLine());
            var workingDays = 365 - holydays;
            var minutesPalyForYear = holydays * 127 + workingDays * 63;

            if (minutesPalyForYear < 30000)
            {
                Console.WriteLine("Tom sleeps well");
                Console.WriteLine("{0} hours and {1} minutes less for play",
                (30000 - minutesPalyForYear) / 60,
                (30000 - minutesPalyForYear) % 60);
            }

            else if (minutesPalyForYear > 30000)
            {
                Console.WriteLine("Tom will run away");
                Console.WriteLine("{0} hours and {1} minutes more for play",
                (minutesPalyForYear - 30000) / 60,
                (minutesPalyForYear - 30000) % 60);
            }
        }
    }
}
