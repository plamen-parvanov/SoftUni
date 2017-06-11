using System;


namespace _10.Triangle_of_Numbers
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                PrintLine(i);
            }
        }

        private static void PrintLine(int i)
        {
            for (int j = 0; j < i; j++)
            {
                Console.Write("{0} ", i);
            }
            Console.WriteLine();
        }
    }
}
