using System;


namespace _03.Miles_to_Kilometers
{
    class Program
    {
        static void Main(string[] args)
        {
            double miles = double.Parse(Console.ReadLine());

            double kmToMiles = miles * 1.60934;

            Console.WriteLine("{0:F2}", kmToMiles);
        }
    }
}
