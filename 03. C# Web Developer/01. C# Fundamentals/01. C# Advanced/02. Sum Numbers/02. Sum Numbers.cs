namespace _02.Sum_Numbers
{
    using System;
    using System.Linq;

    public class Problem02
    {
        public static void Main()
        {
            var nums = Console.ReadLine()
                .Split(new[] { ", " }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            Console.WriteLine(nums.Length);
            Console.WriteLine(nums.Sum());

        }
    }
}
