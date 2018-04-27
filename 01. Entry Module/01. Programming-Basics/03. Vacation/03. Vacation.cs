using System;


namespace _03.Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            var adults = int.Parse(Console.ReadLine());
            var students = int.Parse(Console.ReadLine());
            var nights = int.Parse(Console.ReadLine());
            var transport = Console.ReadLine();
            var transportMoney = 0.0;
            var hotelMoney = 0.0;
            var totalMoney = 0.0;

            if (transport == "train")
            {
                transportMoney = 2 * (adults * 24.99 + students * 14.99);

                if (adults + students >= 50)
                {
                    transportMoney *= 0.5;
                }
            }
            else if (transport == "bus")
            {
                transportMoney = 2 * (adults * 32.5 + students * 28.5);
            }

            else if (transport == "boat")
            {
                transportMoney = 2 * (adults * 42.99 + students * 39.99);
            }

            else if (transport == "airplane")
            {
                transportMoney = 2 * (adults * 70.0 + students * 50.0);
            }

            hotelMoney = nights * 82.99;
            totalMoney = (transportMoney + hotelMoney) + 0.1 * (transportMoney + hotelMoney);

            Console.WriteLine("{0:f2}", totalMoney);
        }
    }
}
