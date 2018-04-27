using System;


namespace _01.Training_Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            double weight = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            double workPlaces = Math.Floor((height - 1) / 0.7) * Math.Floor(weight / 1.2) - 3;
            Console.WriteLine(workPlaces);

        }
    }
}
