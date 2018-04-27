namespace _01.Raindrops
{
    using System;
    using System.Linq;

    public class Problem01
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var density = double.Parse(Console.ReadLine());
            var sum = 0d;

            for (int i = 0; i < n; i++)
            {
                var arr = Console.ReadLine()
                    .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(long.Parse)
                    .ToArray();

                sum += arr[0] / (double)arr[1];
            }

            PrintResult(sum, density);
        }

        private static void PrintResult(double sum, double density)
        {
            if (density == 0)
            {
                Console.WriteLine("{0:F3}", sum);
            }
            else
            {
                Console.WriteLine("{0:F3}", sum / density);
            }
        }
    }
}
