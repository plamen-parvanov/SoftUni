using System;


namespace _05.Axe
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int i = 0;
            int leftDashes = 3 * n;
            int rightDashes = 5 * n -leftDashes - 2;
            for ( i = 0; i < n; i++)
            {
                Console.WriteLine("{0}*{1}*{2}", new string('-', leftDashes),
                    new string('-', i), new string('-', rightDashes - i));
            }
            for (int j = 0; j < n / 2; j++)
            {
                Console.WriteLine("{0}*{1}*{2}", new string('*', leftDashes),
                    new string('-', i - 1), new string('-', rightDashes - i + 1));
            }
            for (int j = 0; j < n / 2; j++)
            {
                char special = '-';
                if (j == n / 2 - 1)
                {
                    special = '*';
                }
                Console.WriteLine("{0}*{1}*{2}", new string('-', leftDashes - j),
                    new string(special, i - 1 + 2 * j), new string('-', rightDashes - i + 1 - j));
            }
        }
    }
}
