using System;

namespace _05.Diamond
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            //top
            for (int i = 0; i <= n; i++)
            {
                char midDots = '.';
                if (i == 0 || i == n)
                {
                    midDots = '*';
                }
                Console.WriteLine("{0}*{1}*{0}", new string('.', n - i), new string(midDots, 3 * n - 2 * (1 - i)));
            }
            //bottom
            for (int i = 0; i <= 2 * n; i++)
            {
                char midDots = '.';
                if (i == 2 * n)
                {
                    midDots = '*';
                }
                Console.WriteLine("{0}*{1}*{0}", new string('.', 1 + i), new string(midDots, 5 * n - 4 - 2 * i));
            }
        }
    }
}
