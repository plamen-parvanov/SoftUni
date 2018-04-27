using System;


namespace _05.Diamond
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i <= n; i++)
            {
                char dotsInside = '.';
                if (i == 0 || i == n)
                {
                    dotsInside = '*';
                }
                Console.WriteLine("{0}*{1}*{0}", new string('.', n - i), new string(dotsInside, 3 * n - 2 + 2 * i));
            }

            for (int i = 0; i <= 2 * n; i++)
            {
                char dotsInside = '.';
                if (i == 2 * n)
                {
                    dotsInside = '*';
                }
                Console.WriteLine("{0}*{1}*{0}", new string('.', 1 + i), new string(dotsInside, 5 * n - 4 - 2 * i));
            }
        }
    }
}
