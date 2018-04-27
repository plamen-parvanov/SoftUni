using System;


namespace Problem_05___Hourglass
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                char symbol = '@';
                if (i == 0)
                {
                    symbol = '*';
                }
                else if (i == 1)
                {
                    symbol = ' ';
                }
                Console.WriteLine("{0}*{1}*{0}", new string('.', i), new string(symbol, 2 * n - 1 - 2 * i));
            }
            Console.WriteLine("{0}*{0}", new string('.', n));

            for (int i = 0; i < n; i++)
            {
                char alfa = '@';
                char symbol = ' ';
                if (i == n - 2)
                {
                    symbol = '@';
                }
                else if (i == n - 1)
                {
                    symbol = '*';
                    alfa = '*';
                }
                
                Console.WriteLine("{0}*{1}{2}{1}*{0}", new string('.', n - 1 - i), new string(symbol, i), alfa);
            }
        }
    }
}
