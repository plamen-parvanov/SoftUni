using System;


namespace Problem_02___Cups
{
    class Program
    {
        static void Main(string[] args)
        {
            int cupsNeeded = int.Parse(Console.ReadLine());
            int workers = int.Parse(Console.ReadLine());
            int workDays = int.Parse(Console.ReadLine());

            int cupsProdused = workers * workDays * 8 / 5;
            int diff = Math.Abs(cupsNeeded - cupsProdused);

            if (cupsProdused >= cupsNeeded)
            {
                Console.WriteLine("{0:f2} extra money", diff * 4.2);
            }
            else
            {
                Console.WriteLine("Losses: {0:f2}", diff * 4.2);
            }
        }
    }
}
