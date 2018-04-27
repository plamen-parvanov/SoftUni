namespace _10.Triangle_of_Numbers
{
    using System;

    public class Problem10
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());

            for (int i = 1; i < n + 1; i++)
            {
                PrintLine(i);
            }
        }

        public static void PrintLine(int num)
        {
            for (int i = 1; i < num; i++)
            {
                Console.Write($"{num} ");
            }

            Console.WriteLine($"{num}");
        }
    }
}
