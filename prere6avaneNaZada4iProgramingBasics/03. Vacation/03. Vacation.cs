using System;


namespace _03.Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            int adults = int.Parse(Console.ReadLine());
            int students = int.Parse(Console.ReadLine());
            int nights = int.Parse(Console.ReadLine());
            string transport = Console.ReadLine();

            double ticketPriceAdults = 0;
            double ticketPriceStudents = 0;

            switch (transport)
            {
                case "train":
                    ticketPriceAdults = 24.99;
                    ticketPriceStudents = 14.99;
                    if (adults + students >= 50)
                    {
                        ticketPriceAdults *= 0.5;
                        ticketPriceStudents *= 0.5;
                    }
                    break;

                case "bus":
                    ticketPriceAdults = 32.5;
                    ticketPriceStudents = 28.5;
                    break;

                case "boat":
                    ticketPriceAdults = 42.99;
                    ticketPriceStudents = 39.99;
                    break;

                case "airplane":
                    ticketPriceAdults = 70;
                    ticketPriceStudents = 50;
                    break;
            }
            double transportMoney = 2 * (ticketPriceAdults * adults + ticketPriceStudents * students);
            double hotelMoney = nights * 82.99;
            double bill = (transportMoney + hotelMoney) * 1.1;

            Console.WriteLine("{0:f2}", bill); 
        }
    }
}
