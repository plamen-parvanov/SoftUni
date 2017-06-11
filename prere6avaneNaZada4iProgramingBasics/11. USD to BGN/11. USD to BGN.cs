using System;


namespace _11.USD_to_BGN
{
    class Program
    {
        static void Main(string[] args)
        {
            double USD = double.Parse(Console.ReadLine());
            double BGN = USD * 1.79549;
            Console.WriteLine("{0} BGN", Math.Round(BGN, 2));

        }
    }
}
