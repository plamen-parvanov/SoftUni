using System;


namespace _03.Water_Overflow
{
    class WaterOverflow

    {
        static void Main()
        {
            short waterInTank = 0;
            byte n = byte.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                short quantityWater = short.Parse(Console.ReadLine());

                if (waterInTank + quantityWater <= 255)
                {
                    waterInTank += quantityWater;
                }
                else
                {
                    Console.WriteLine("Insufficient capacity!");
                }
            }
            Console.WriteLine(waterInTank);


        }
    }
}
