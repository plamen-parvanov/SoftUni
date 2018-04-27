using System;


namespace _05.Square_Frame
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    string symbol = "- ";
                    if ((i == 0 || i == n - 1) && (j == 0 || j == n - 1))
                    {
                        symbol = "+ ";
                    }
                    else if ((i > 0 && i < n - 1) && (j == 0 || j == n - 1))
                    {
                        symbol = "| ";
                    }
                    Console.Write(symbol);
                }
                Console.WriteLine();
            }
        }
    }
}
