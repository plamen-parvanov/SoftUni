using System;


namespace _03.Back_in_30_Minutes
{
    class Program
    {
        static void Main()
        {
            byte hours = byte.Parse(Console.ReadLine());
            byte minutes = byte.Parse(Console.ReadLine());

            minutes += 30;

            if (minutes >= 60)
            {
                hours++;
                minutes %= 60;
            }
            if (hours > 23)
            {
                hours -= 24;
            }

            Console.WriteLine($"{hours}:{minutes:D2}");
        }
    }
}
