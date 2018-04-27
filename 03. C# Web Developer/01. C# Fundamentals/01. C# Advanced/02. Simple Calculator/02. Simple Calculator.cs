namespace _02.Simple_Calculator
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Problem02
    {
        public static void Main()
        {
            var inputArr = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            var inputStack = new Stack<string>(inputArr.Reverse());

            var result = MakeCalculations(inputStack);

            Console.WriteLine(result);
        }

        private static string MakeCalculations(Stack<string> input)
        {
            while (input.Count > 2)
            {
                var first = int.Parse(input.Pop());
                var operation = input.Pop();
                var second = int.Parse(input.Pop());

                if (operation == "-")
                {
                    second *= -1;
                }

                input.Push((first + second).ToString());
            }

            return input.Pop();
        }
    }
}
