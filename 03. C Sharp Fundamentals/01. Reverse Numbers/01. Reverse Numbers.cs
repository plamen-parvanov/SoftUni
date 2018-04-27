namespace _01.Reverse_Numbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Problem01
    {
        public static void Main()
        {
            var numArr = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            var stack = new Stack<int>(numArr);

            while (stack.Count > 0)
            {
                Console.Write(stack.Pop());

                if (stack.Count != 0)
                {
                    Console.Write(" ");
                }
            }

            Console.WriteLine();
        }
    }
}
