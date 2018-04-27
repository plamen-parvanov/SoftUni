namespace _06.Heists
{
    using System;
   // using System.Collections.Generic;
    using System.Linq;

    public class Arrays
    {

        public static void Main()
        {
            var priceArr = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int jewelsPrice = priceArr[0];
            int goldPrice = priceArr[1];
            long earnings = 0;
            long expenses = 0;

            for (int i = 0; i < 100; i++)
            {
                var input = Console.ReadLine();

                if (input == "Jail Time")
                {
                    break;
                }

                var heistArr = input.Split().ToArray();

                expenses += long.Parse(heistArr[1]);
                earnings += GetEarningsFromLoop(heistArr[0], jewelsPrice, goldPrice);

            }

            PrintResult(earnings, expenses);

        }

        public static void PrintResult(long earnings, long expenses)
        {
            if (earnings >= expenses)
            {
                Console.WriteLine("Heists will continue. Total earnings: {0}.", earnings - expenses);
            }
            else
            {
                Console.WriteLine("Have to find another job. Lost: {0}.", expenses - earnings);
            }
        }

        public static long GetEarningsFromLoop(string heist, int jewelsPrice, int goldPrice)
        {
           var arr = heist.ToArray();
            long earn = 0;

            foreach (var item in arr)
            {
                if (item == '%')
                {
                    earn += jewelsPrice;
                }
                else if (item == '$')
                {
                    earn += goldPrice;
                }
            }

            return earn;
        }
    }
}
