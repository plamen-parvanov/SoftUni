using System;


namespace _07.Christmas_Tree
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i <= n; i++)
            {
                Console.WriteLine("{0}{1} | {1}{0}",
                    new string(' ', n - i), new string('*', i));
            }
        }
    }
}
