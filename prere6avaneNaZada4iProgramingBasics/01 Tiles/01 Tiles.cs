using System;


namespace _01_Tiles
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            double W = double.Parse(Console.ReadLine());
            double L = double.Parse(Console.ReadLine());
            int M = int.Parse(Console.ReadLine());
            int O = int.Parse(Console.ReadLine());

            double tiles = (N * N - M * O) / (W * L);
            double time = tiles * 0.2;

            Console.WriteLine(tiles);
            Console.WriteLine(time);

        }
    }
}
