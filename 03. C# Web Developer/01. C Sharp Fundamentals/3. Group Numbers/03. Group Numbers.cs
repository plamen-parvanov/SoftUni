namespace _3.Group_Numbers
{
    using System;
    using System.Linq;

    public class Problem02
    {
        public static int[][] jagged = new int[3][];
        public static void Main()
        {
            var input = ReadInputNumbers();

            GroupNumbersByReminder(input);

            PrintJagged();
        }

        private static int[] ReadInputNumbers()
        {
            return Console.ReadLine()
               .Split(new[] { ", " }, StringSplitOptions.RemoveEmptyEntries)
               .Select(int.Parse)
               .ToArray();
        }

        private static void GroupNumbersByReminder(int[] numbers)
        {
            jagged[0] = AddNumsWithReminder(0, numbers);

            jagged[1] = AddNumsWithReminder(1, numbers);

            jagged[2] = AddNumsWithReminder(2, numbers);
        }

        private static int[] AddNumsWithReminder(int rem, int[] nums)
        {
            return nums.Where(x => Math.Abs(x % 3) == rem).ToArray();
        }

        private static void PrintJagged()
        {
            foreach (var row in jagged)
            {
                Console.WriteLine(string.Join(" ", row));
            }
        }
    }
}
