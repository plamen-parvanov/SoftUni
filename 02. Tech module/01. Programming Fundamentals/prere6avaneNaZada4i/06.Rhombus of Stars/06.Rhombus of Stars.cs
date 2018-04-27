using System;


namespace _06.Rhombus_of_Stars
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.Write(new string(' ', n - 1 - i) +"*");
                for (int j = 0; j < i; j++)
                {
                    Console.Write(" *");
                }
                Console.WriteLine();
            }
            for (int i = 0; i < n - 1; i++)
            {
                Console.Write(new string(' ', 1 + i) + "*");
                for (int j = 0; j < n - 2 - i; j++)
                {
                    Console.Write(" *");
                }
                Console.WriteLine();
            }

        }
    }
}
