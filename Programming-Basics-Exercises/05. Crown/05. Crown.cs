using System;


namespace _05.Crown
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("@{0}@{0}@", new string(' ', n - 2));
            Console.WriteLine("**{0}*{0}**", new string(' ', n - 3));

            for (int i = 0; i < n / 2 - 2; i++)
            {
                int a = n - 5 - 2 * i;
                if ( a < 0)
                {
                    a = 0;
                }
               
                Console.WriteLine("*{0}*{1}{2}{3}{2}{1}*{0}*", new string('.', 1 +i),
                    new string(' ', a), new string('*', 1), new string('.', 1 + 2 * i));
            }
            Console.WriteLine("*{0}*{1}*{0}*", new string('.', n / 2 - 1), new string('.', n - 3));
            Console.WriteLine("*{0}*{1}.{1}*{0}*", new string('.', n/ 2), new string('*', n - 3 - n / 2));
            Console.WriteLine("{0}", new string('*', 2 * n - 1));
            Console.WriteLine("{0}", new string('*', 2 * n - 1));
        }
    }
}
