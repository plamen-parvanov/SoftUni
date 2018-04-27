using System;


namespace _05.Evening
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            char leftRightDots = '.';
            int a = 3 * n / 2 - 1;
           
            int i = 0;

            for ( i = 0; i < n; i++)
            {
                Console.WriteLine("{0}/{1}\\{0}",new string(leftRightDots, a - i), new string(' ', 2 * i));
            }
            i--;
            Console.WriteLine("{0}{1}{0}", new string(leftRightDots, a - i), new string('*', 2 * i + 2));

            for (int j = 0; j < 2 * n; j++)
            {
                Console.WriteLine("{0}|{1}|{0}", new string(leftRightDots, a - i ), new string('\\', 2 * i));
            }

            for (int k = 0; k < n / 2; k++)
            {
                Console.WriteLine("{0}/{1}\\{0}", new string(leftRightDots, a - i - k), new string('*', 2 * (i + k)));
            }
        }
    }
}
