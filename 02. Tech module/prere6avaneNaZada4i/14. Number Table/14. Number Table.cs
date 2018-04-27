using System;


namespace _14.Number_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                for (int j = i; j <= n; j++)
                {
                    Console.Write("{0} ", j);
                }
                for (int j = 1; j < i; j++)
                {
                    Console.Write("{0} ", n - j);
                }
                Console.WriteLine();
            }

           
        }
    }
}
