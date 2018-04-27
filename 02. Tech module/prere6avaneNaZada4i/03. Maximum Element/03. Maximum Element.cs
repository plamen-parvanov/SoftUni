namespace _03.Maximum_Element
{

    using System;
    using System.Collections.Generic;
    using System.Linq;


    public class StacksAndQueues
    {

        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var stack = new Stack<int>();
            var maxNumberStack = new Stack<int>();

            for (int i = 0; i < n; i++)
            {
                var inputLine = Console.ReadLine()
                    .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                ExecuteCommand(inputLine, stack, maxNumberStack);
            }
        }

        public static void ExecuteCommand(int[] inputLine, Stack<int> stack, Stack<int> max)
        {
            var command = inputLine[0];

            switch (command)
            {
                case 1:
                    stack.Push(inputLine[1]);
                    AddMaxEl(inputLine[1], max);
                    break;

                case 2:
                    if (max.Peek() == stack.Peek())
                    {
                        max.Pop();
                    }

                    stack.Pop();
                    break;

                case 3:
                    Console.WriteLine(max.Peek());
                    break;

            }
        }

        public static void AddMaxEl(int currentNum, Stack<int> max)
        {
            var currentMax = (max.Count > 0) ? max.Peek() : int.MinValue;


            if (currentNum > currentMax)
            {
                max.Push(currentNum);
            }
        }

    }
}
