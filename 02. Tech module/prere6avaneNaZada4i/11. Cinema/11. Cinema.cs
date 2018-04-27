using System;


namespace _11.Cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            string projection = Console.ReadLine();
            int rows = int.Parse(Console.ReadLine());
            int columns = int.Parse(Console.ReadLine());
            double ticketPrice = 0;

            switch (projection)
            {
                case "Premiere":
                    ticketPrice = 12;
                    break;
                case "Normal":
                    ticketPrice = 7.5;
                    break;
                case "Discount":
                    ticketPrice = 5;
                    break;
            }
            Console.WriteLine("{0:f2}", columns * rows * ticketPrice);
        }
    }
}
