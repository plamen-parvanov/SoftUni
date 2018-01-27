namespace _04.Draw_a_Filled_Square
{

    using System;


    public class Problem04
    {

        public static void Main()
        {

            var n = int.Parse(Console.ReadLine());

            for (int row = 1; row <= n; row++)
            {
                PrintLine(row, n);
            }

        }

        public static void PrintLine(int row, int n)
        {
            Console.Write("-");

            var symbols = "\\/";

            for (int j = 0; j < n - 1; j++)
            {
                if (row == 1 || row == n)
                {
                    symbols = "--";
                }

                Console.Write(symbols);
            }

            Console.WriteLine("-");

        }
    }
}
