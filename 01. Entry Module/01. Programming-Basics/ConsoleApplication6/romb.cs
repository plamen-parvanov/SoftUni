using System;


namespace romb
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
           
            // First half

            for (int i = 1; i <= n; i++)
            {
                for (int j = 0; j < n - i; j++)
                {
                    Console.Write(" ");
                }

                for (int k = 0; k < i; k++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }

            // Second Half

            for (int i = 1; i < n; i++)
            {
                for (int j = 0; j < i ; j++)
                {
                    Console.Write(" ");
                }

                for (int k = 0; k < n - i; k++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }


        }
    }
}
