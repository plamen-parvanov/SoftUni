using System;


namespace _09.Perfect_Diamond
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.Write("{0}*", new string(' ', n - 1 - i));
                for (int j = 0; j < i; j++)
                {
                    Console.Write("-*");
                }
                Console.WriteLine();
            }
            for (int i = 1; i < n; i++)
            {
                Console.Write("{0}*", new string(' ',i));
                for (int j = 0; j < n - 1 - i; j++)
                {
                    Console.Write("-*");
                }
                Console.WriteLine();
            }
        }
    }
}
