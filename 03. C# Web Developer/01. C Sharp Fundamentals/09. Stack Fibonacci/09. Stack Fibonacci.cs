namespace _09.Stack_Fibonacci
{
    using System;
    using System.Collections.Generic;

    public class Problem09
    {
        public static void Main()
        {
            var stack = new Stack<long>();
            stack.Push(0);
            stack.Push(1);

            var n = int.Parse(Console.ReadLine());

            for (int i = 1; i < n; i++)
            {
                var prevOne = stack.Pop();
                var prevTwo = stack.Pop();
                var currEll = prevOne + prevTwo;
                stack.Push(prevOne);
                stack.Push(currEll);
            }

            Console.WriteLine(stack.Pop());
        }
    }
}
