using System;


namespace _05.Square_Frame
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            
            for (int i = 0; i < n; i++)
            {
                var symbol = "| ";
                if (i == 0 || i == n - 1)
                {
                    symbol = "+ ";
                }
                Console.Write(symbol);
                for (int j = 0; j < n - 2; j++)
                {
                    Console.Write("- ");
                }
                Console.WriteLine(symbol);
                symbol = "| ";
            
            }

        }
    }
}
