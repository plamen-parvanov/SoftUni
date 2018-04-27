using System;

namespace newRomb
{
    class newRomb
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            //First Half
            for (int i = 0; i < n; i++)
            {
                Console.Write( new string (' ' ,  n -1 - i));
                Console.Write("* ");

                for (int j = 0; j < i; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
            // Second Half
            for (int i = 0; i < n - 1; i++)
            {
                Console.Write( new string(' ', 1 + i));
                Console.Write("* ");

                for (int j = 0; j < n - 2 - i; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
        }
    }
}
