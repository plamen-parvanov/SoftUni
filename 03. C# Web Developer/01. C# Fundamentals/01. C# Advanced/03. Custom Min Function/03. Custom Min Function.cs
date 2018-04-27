namespace _03.Custom_Min_Function
{
    using System;
    using System.Linq;

    public class Problem02
    {
        public static void Main()
        {
            var nums = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            Func<int[], int> findsMinNum = arr => arr.Min();

            Console.WriteLine(findsMinNum(nums));
        }
    }
}
