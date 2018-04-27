using System;


namespace _05.SoftUniLogo
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            int leftRightDots = 6 * n - 3;
            int i = 0;
            for (i = 0; i < 2 * n; i++)
            {
                Console.WriteLine("{0}{1}#{1}{0}", new string('.',leftRightDots - 3 * i), new string('#', 3 * i));
            }

            for (i = 0; i < n - 1; i++)
            {
                Console.WriteLine("|{0}{1}{2}", new string('.', 2 + 3 * i), new string('#', 12 * n - 11 - 6 * i),
                    new string('.', 3 + 3 * i));
            }
            i--;
            for (int j = 0; j < n - 1; j++)
            {
                char special = '|';
                if (j == n - 2)
                {
                    special = '@';
                }
                Console.WriteLine("{0}{1}{2}{3}", special, new string('.', 2 + 3 * i), new string('#', 12 * n - 11 - 6 * i),
                    new string('.', 3 + 3 * i));
            }

        }
    }
}
