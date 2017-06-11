using System;


namespace _05.Butterfly
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n - 2; i++)
            {
                char stars = '*';
                if (i % 2 != 0)         // moga da go napravq i taka: new string(i % 2 ==0 ? '*' : '-')
                {
                    stars = '-';
                }
                Console.WriteLine("{0}\\ /{0}", new string (stars, n - 2) );
            }
            Console.WriteLine("{0}@{0}", new string(' ', n - 1) );

            for (int i = 0; i < n - 2; i++)
            {
                char stars = '*';
                if (i % 2 != 0)
                {
                    stars = '-';
                }
                Console.WriteLine("{0}/ \\{0}", new string(stars, n - 2) );
            }
        }
    }
}
