using System;


namespace _07_Sum_Seconds
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstTime = int.Parse(Console.ReadLine());
            int secondTime = int.Parse(Console.ReadLine());
            int thirdime = int.Parse(Console.ReadLine());
            int seconds = firstTime + secondTime + thirdime;
            int minutes = 0;

            if (seconds >= 120)
            {
                minutes += 2;
                seconds -= 120; 
            }
            else if (seconds >= 60)
            {
                minutes += 1;
                seconds -= 60;
            }
            Console.WriteLine("{0}:{1:d2}", minutes, seconds);
        }
    }
}
