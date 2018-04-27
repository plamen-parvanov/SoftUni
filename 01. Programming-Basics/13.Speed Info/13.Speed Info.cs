using System;

namespace _13.Speed_Info
{
    class Program
    {
        static void Main(string[] args)
        {
            var value = decimal.Parse(Console.ReadLine());

            if (value <= 10m)
                Console.WriteLine("slow");

            else if (value <= 50m)
                Console.WriteLine("average");

            else if (value <= 150m)
                Console.WriteLine("fast");

            else if (value <= 1000m)
                Console.WriteLine("ultra fast");

            else
                Console.WriteLine("extremely fast");
        }
    }
}
