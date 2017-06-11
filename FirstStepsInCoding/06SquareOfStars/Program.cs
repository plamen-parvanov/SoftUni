using System;


namespace 06SquareOfStars
{
    class Program
    {
        static void Main(string[] args)
        {
            byte n = byte.Parse(Console.ReadLine());

            for (byte FirstRow = 1; FirstRow <= n; FirstRow++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
            for (byte row = 1; row <= n - 2; row++)
            {
                Console.Write("*");

                for (byte col = 1; col <= n - 2; col++)
                {
                    Console.Write(" ");
                }
                Console.WriteLine("*");
            }
            for (byte LastRow = 1; LastRow <= n; LastRow++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }
}
