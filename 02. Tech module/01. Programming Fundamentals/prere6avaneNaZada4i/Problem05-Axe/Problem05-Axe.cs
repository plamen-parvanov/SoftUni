using System;


namespace Problem05_Axe
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int j = 0;

            for (int i = 0; i < n + n / 2; i++)
            {
                char tireta = '-';
                if (i >= n)
                {
                    tireta = '*';
                    j ++;
                }
                Console.WriteLine("{0}*{1}*{2}", new string(tireta, 3 * n), 
                    new string('-', i - j), new string('-', 2 * n - 2 - i + j));
            }

            for (int i = 0; i < n / 2; i++)
            {
                char tireta = '-';
                if (i == n / 2 - 1)
                {
                    tireta = '*';
                }
                Console.WriteLine("{0}*{1}*{2}", new string('-', 3 * n - i),
                     new string(tireta, n - 1 + 2 * i), new string('-', n - 1 - i));
            }
        }
    }
}
