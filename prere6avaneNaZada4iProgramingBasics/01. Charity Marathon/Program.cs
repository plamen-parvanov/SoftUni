namespace _01.Charity_Marathon
{
    using System;
    using System.Numerics;

    public class ExamPreparationII
    {

        public static void Main()
        {
            var days = short.Parse(Console.ReadLine());
            var runners = int.Parse(Console.ReadLine());
            var averageLaps = byte.Parse(Console.ReadLine());
            var trackLength = int.Parse(Console.ReadLine());
            var trackCapacity = short.Parse(Console.ReadLine());
            var moneyPerKm = double.Parse(Console.ReadLine());

            int maxRunners = days * trackCapacity;
            if (runners > maxRunners)
            {
                runners = maxRunners;
            }

            long totalKm = (long)runners * averageLaps * trackLength / 1000;
            //BigInteger totalKm = totalMeters / 1000;

            double moneyRaised = totalKm * moneyPerKm;

            Console.WriteLine($"Money raised: {moneyRaised:F2}");
        }
    }
}
