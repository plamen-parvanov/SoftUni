using System;


namespace _02.Transport_Price
{
    class Program
    {
        static void Main(string[] args)
        {
            int kilometers = int.Parse(Console.ReadLine());
            string dayOrNight = Console.ReadLine();
            double bill = 0;

            if (kilometers >= 100)
            {
                bill = kilometers * 0.06;
            }
            else if (kilometers >= 20)
            {
                bill = kilometers * 0.09;
            }
            else if (dayOrNight == "day")
            {
                bill = 0.7 + kilometers * 0.79;
            }
            else if (dayOrNight == "night")
            {
                bill = 0.7 + kilometers * 0.9;
            }
            Console.WriteLine(bill);
        }
    }
}
