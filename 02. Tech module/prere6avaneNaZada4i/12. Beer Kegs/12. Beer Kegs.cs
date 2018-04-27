using System;


namespace _12.Beer_Kegs
{
    class BeerKegs

    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            double biggestVolume = double.MinValue;
            string biggestKegName = string.Empty;

            for (int i = 0; i < n; i++)
            {
                string model = Console.ReadLine();
                double radius = double.Parse(Console.ReadLine());
                int height = int.Parse(Console.ReadLine());

                double volume = Math.PI * height * Math.Pow(radius, 2);

                if (volume > biggestVolume)
                {
                    biggestVolume = volume;
                    biggestKegName = model;
                }
            }

            Console.WriteLine(biggestKegName);
        }
    }
}
