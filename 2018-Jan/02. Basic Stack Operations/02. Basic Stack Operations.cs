namespace _02.Basic_Stack_Operations
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Problem02
    {
        static void Main(string[] args)
        {
            var inputLine = Console.ReadLine().
                Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            var ellNum = inputLine[0];
            var ellToPop = inputLine[1];
            var ellToFind = inputLine[2];

            var nums = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            var stack = new Stack<int>(ellNum);

            for (int i = 0; i < ellNum; i++)
            {
                stack.Push(nums[i]);
            }

            for (int i = 0; i < ellToPop; i++)
            {
                stack.Pop();
            }

            if (stack. Count == 0)
            {
                Console.WriteLine(0);
            }
            else if (stack.Contains(ellToFind))
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine(stack.Min());
            }
        }
    }
}
