namespace _01.RhombusOfStars
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            PrintRhombus();
        }

        private static void PrintRhombus()
        {
            var n = int.Parse(Console.ReadLine());

            PrintTop(n);

            PrintBottom(n);
        }

        private static void PrintBottom(int n)
        {
            for (int i = 1; i < n; i++)
            {
                PrintRow(i, n - 1 -i);
            }
        }

        private static void PrintTop(int n)
        {
            for (int i = 0; i < n; i++)
            {
                PrintRow(n - 1 - i, i);
            }
        }

        private static void PrintRow(int spaces, int stars)
        {
            PrintSpaces(spaces);
            
            PrintStars(stars);

        }

        private static void PrintSpaces(int spaces)
        {
            Console.Write(new string(' ', spaces));
        }

        private static void PrintStars(int stars)
        {
            Console.Write('*');

            for (int i = 0; i < stars; i++)
            {
                Console.Write(" *");
            }

            Console.WriteLine();
        }
    }
}
