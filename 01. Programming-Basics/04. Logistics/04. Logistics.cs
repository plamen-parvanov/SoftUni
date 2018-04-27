using System;


namespace _04.Logistics
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var pricePerTon = 0.0;
            var train = 0.0;
            var truck = 0.0;
            var microbus = 0.0;
            var totalTons = 0.0;

            for (int i = 0; i < n; i++)
            {
                var tons = int.Parse(Console.ReadLine());

                if (tons >= 12)
                {
                    train += tons;
                }
                else if (tons > 3)
                {
                    truck+= tons;
                }
                else
                {
                    microbus+= tons;
                }
            }
            totalTons = train + truck + microbus;
            pricePerTon = (train * 120 + truck * 175 + microbus * 200)/ totalTons;
            train = train / totalTons * 100;
            truck = truck / totalTons * 100;
            microbus = microbus / totalTons * 100;

           
            Console.WriteLine("{0:F2}\n{1:f2}%\n{2:f2}%\n{3:f2}%",pricePerTon, microbus, truck, train);
        }
    }
}
