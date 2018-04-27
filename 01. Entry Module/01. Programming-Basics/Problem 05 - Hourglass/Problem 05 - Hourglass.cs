using System;


namespace Problem_05___Hourglass
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n ; i++)
            {
                char special = '@';
                    if (i == 0)
                {
                    special = '*';
                }
                else if (i == 1)
                {
                    special = ' ';
                }
                Console.WriteLine("{0}*{1}*{0}", new string('.', i), new string(special, 2 * n - 1 - 2 * i));
            }
            Console.WriteLine("{0}*{0}", new string('.', n));
            for (int i = 0; i < n; i++)
            {
                char special = ' ';
                char alfa = '@';
              
                if (i == n - 2)
                {
                    special = '@';
                }
                else if (i == n - 1)
                {
                    special = '*';
                    alfa = '*';
                }
                Console.WriteLine("{0}*{1}{2}{1}*{0}", new string('.', n - 1 - i), new string(special, i), alfa);

            }
        }
    }
}
