using System;


namespace _01.Distance
{
    class Program
    {
        static void Main(string[] args)
        {
            var V1 = int.Parse(Console.ReadLine());
            var t1 = int.Parse(Console.ReadLine());
            var t2 = int.Parse(Console.ReadLine());
            var t3 = int.Parse(Console.ReadLine());
            var S1 = 0.0;
            var S2 = 0.0;
            var S3 = 0.0;

            S1 = V1 * t1 / 60d;
            S2 = 1.1 * V1 * t2 / 60d;
            S3 = 1.1 * V1 * 0.95 * t3 / 60d;

            Console.WriteLine("{0:F2}", S1 + S2 + S3);

       
        }
    }
}
