using System;


namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int FirstRow = 1; FirstRow <= n; FirstRow++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
                for (int row = 1; row <= n - 2; row++)
                 {
                     Console.Write("*");

                     for (int col = 1; col <= n - 2; col++)
                     {
                            Console.Write(" ");
                     }
                      Console.WriteLine("*");
                }
            for (int LastRow = 1; LastRow <= n; LastRow++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }
}
