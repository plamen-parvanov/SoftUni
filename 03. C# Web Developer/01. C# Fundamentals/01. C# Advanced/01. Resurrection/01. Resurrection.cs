namespace _01.Resurrection
{
    using System;

    public class Problem01
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                var length = decimal.Parse(Console.ReadLine());
                var width = decimal.Parse(Console.ReadLine());
                var wing = decimal.Parse(Console.ReadLine());

                var years = length * length * (width + 2 * wing);
                Console.WriteLine(years);
            }

        }
    }
}
