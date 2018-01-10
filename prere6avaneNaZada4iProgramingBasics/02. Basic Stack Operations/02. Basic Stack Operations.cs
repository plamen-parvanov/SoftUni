namespace _02.Basic_Stack_Operations
{

    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StacksAndQues
    {

        public static void Main()
        {
            var text = Console.ReadLine()
                .Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries);

            if (int.Parse(text[0]) <= int.Parse(text[1]))
            {
                Console.WriteLine("0");
            }
            else
            {
                var contains = int.Parse(text[2]);
                var smallest = new Stack<int>();
                var stack = new Stack<int>();

                PushNumbers(stack, text, smallest);

                PopNumbers(stack, text, smallest);

                if (stack.Contains(contains))
                {
                    Console.WriteLine("true");
                }
                else
                {
                    Console.WriteLine(smallest.Peek());
                }
                
            }
           

        }


        public static void PushNumbers(Stack<int> stack, string[] text, Stack<int> smallest)
        {
            var push = int.Parse(text[0]);
            var numbers = Console.ReadLine()
               .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
               .Select(int.Parse)
               .ToArray();

            var currSmallest = int.MaxValue;

            for (int i = 0; i < push; i++)
            {
                stack.Push(numbers[i]);

                if (numbers[i] < currSmallest)
                {
                    smallest.Push(numbers[i]);
                    currSmallest = numbers[i];
                }

            }

        }

        public static void PopNumbers(Stack<int> stack, string[] text, Stack<int> smallest)
        {
            var pop = int.Parse(text[1]);

            for (int i = 0; i < pop; i++)
            {
                var remove = stack.Pop();
                if (smallest.Contains(remove))
                {
                    smallest.Pop();


                }
            }
        }
    }
}
