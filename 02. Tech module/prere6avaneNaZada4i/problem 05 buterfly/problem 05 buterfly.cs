using System;


namespace problem_05_buterfly
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i < n - 1; i++)
            {
                char symbol = '*';
                if (i % 2 == 0)
                {
                    symbol = '-';
                }
                Console.WriteLine("{0}\\ /{0}", new string(symbol, n - 2));
            }

            Console.WriteLine("{0}@{0}", new string(' ', n - 1));

            for (int i = 1; i < n - 1; i++)
            {
                char symbol = '*';
                if (i % 2 == 0)
                {
                    symbol = '-';
                }
                Console.WriteLine("{0}/ \\{0}", new string(symbol, n - 2));
            }
        }
    }
}
