using System;


namespace _10.Diamond
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int a = (n - 1) / 2;
            for (int i = 0; i < (n + 1) / 2; i++)
            {
                if (i == 0)
                {
                    Console.WriteLine("{0}{1}{0}", new string('-', a),
                        new string('*', 2 - n % 2));
                }
                else
                {
                    Console.WriteLine("{0}*{1}*{0}", new string('-', a - i),
                        new string('-', 2 * i - n % 2));
                }
            }
            for (int i = 0; i < a; i++)
            {
                if (i != a - 1)
                {
                    Console.WriteLine("{0}*{1}*{0}", new string('-', i + 1),
                        new string('-', n - 4 - 2 * i));
                }
                else
                {
                    Console.WriteLine("{0}{1}{0}", new string('-', a),
                        new string('*', 2 - n % 2));
                }
            }

        }
    }
}
