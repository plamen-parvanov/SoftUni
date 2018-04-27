namespace _01.Sort_Even_Numbers
{
    using System;
    using System.Linq;

    public class Problem01
    {
        public static void Main()
        {
            var nums = Console.ReadLine()
                .Split(new[] { ", " }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .Where(n => n % 2 == 0)
                .OrderBy(n => n)
                .ToArray();

            Console.WriteLine(string.Join(", ", nums));
        }
    }
}
