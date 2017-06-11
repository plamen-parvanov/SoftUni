using System;


namespace _06.Square_of_Stars
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                char a = ' ';
                if (i == 0 || i == n - 1)
                {
                    a = '*';
                }
                Console.WriteLine("*{0}*", new string(a, n - 2));
            }
        }
    }
}
