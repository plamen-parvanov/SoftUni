namespace _03.Printing_Triangle
{

    using System;


    public class Problem03
    {

        public static void Main()
        {

            var n = int.Parse(Console.ReadLine());

            PrintTirangleTop(n);
            PrintTriamgleBottom(n);

        }

        public static void PrintTirangleTop(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                PrintLine(i);
                Console.WriteLine();
            }

        }

        public static void PrintTriamgleBottom(int n)
        {
            for (int i = n - 1; i > 0; i--)
            {
                PrintLine(i);
                Console.WriteLine();
            }

        }

        public static void PrintLine(int i)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write(j);

                if (j != i)
                {
                    Console.Write(" ");
                }
            }

        }
    }
}
