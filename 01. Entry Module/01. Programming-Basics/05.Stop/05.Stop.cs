using System;


namespace _05.Stop
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("{0}{1}{0}", new string('.', n +1), new string('_', 2 * (n + 1) - 1) );

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("{0}//{1}\\\\{0}", new string('.', n - i), new string('_', (n + i) * 2 - 1));
            }
            Console.WriteLine("//{0}STOP!{0}\\\\", new string('_', 2 * n - 3));

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("{0}\\\\{1}//{0}",new string('.', i), new string('_', 2 * (2 * n - i) - 1) );
            }
        }
    }
}
