using System;


namespace _14_Time___15_Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            int min = int.Parse(Console.ReadLine());
            min += 15;

            if (min >= 60)
            {
                hours += 1;
                min -= 60;
            }
            if (hours > 23)
            {
                hours = 0;
            }

            Console.WriteLine("{0}:{1:d2}", hours, min);
        }
    }
}
