using System;

namespace _10.Rectangle_with_Stars
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i <= n + n % 2; i++)
            {
                char symbol = ' ';
                if (i == 0 || i == n + n % 2)
                {
                    symbol = '%';
                }
                else if (i == (n + 1) / 2)
                {
                    Console.WriteLine("%{0}**{0}%", new string(' ',n - 2));
                    continue;
                }
                Console.WriteLine("%{0}%", new string(symbol, 2 * n - 2));
            }

        }
    }
}
