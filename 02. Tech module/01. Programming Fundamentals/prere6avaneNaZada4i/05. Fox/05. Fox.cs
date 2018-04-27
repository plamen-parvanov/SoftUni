using System;


namespace _05.Fox
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int tireta = 2 * n - 1;
            int zvezdi4ki = 2 * n - 1;

            for (int i = 0; i < n; i++, tireta -= 2)
            {        
                Console.WriteLine("{0}\\{1}/{0}", new string('*', 1 + i), new string('-', tireta));
            }
            for (int i = 0; i < n / 3; i++)
            {
                Console.WriteLine("|{0}\\{1}/{0}|", new string('*', n / 2 + i), new string('*', n - 2 * i));
            }
            for (int i = 0; i < n; i++, zvezdi4ki -= 2)
            {
                Console.WriteLine("{0}\\{1}/{0}", new string('-', 1 + i), new string('*', zvezdi4ki));
            }
        }
    }
}
