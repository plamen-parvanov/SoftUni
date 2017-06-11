using System;

namespace _02___Cups
{
    class Program
    {
        static void Main(string[] args)
        {
            var cupsNeeded = int.Parse(Console.ReadLine());
            var workers = int.Parse(Console.ReadLine());
            var workDays = int.Parse(Console.ReadLine());

            var workHours = workers * workDays * 8;
            var numberCups = Math.Floor(workHours / 5d);

            if (numberCups > cupsNeeded)
            {
                Console.WriteLine("{0:f2} extra money", (numberCups - cupsNeeded) * 4.2);
            }
            else if (cupsNeeded > numberCups)
            {
                Console.WriteLine("Losses: {0:f2}", (cupsNeeded - numberCups) * 4.2);

            }
        }
    }
}
