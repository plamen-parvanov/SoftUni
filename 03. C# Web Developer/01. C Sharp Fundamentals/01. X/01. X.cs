namespace _01.X
{

    using System;


    public class Problem01
    {

        public static void Main()
        {
           
            var n = int.Parse(Console.ReadLine());

            for (int row = 0; row < n; row++)
            {
                PrintLine(row, n);

                Console.WriteLine();
            }

        }

        public static void PrintLine(int row, int n)
        {
            for (int col = 0; col < n; col++)
            {
                var symbol = ' ';

                if (col == row || col == n - row - 1)
                {
                    symbol = 'x';
                }

                Console.Write(symbol);
            }

        }
    }
}
