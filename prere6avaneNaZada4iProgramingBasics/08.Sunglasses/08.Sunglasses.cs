using System;


namespace _08.Sunglasses
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                char symbol1 = '/';
                char symbol2 = ' ';
                if (i == 1 || i == n)
                {
                    symbol1 = '*';
                }
                if (i == (n + 1) / 2)
                {
                    symbol2 = '|';
                }
                Console.WriteLine("*{0}*{1}*{0}*", new string(symbol1, 2 * n - 2),
                    new string(symbol2, n));
            }

        }
    }
}
