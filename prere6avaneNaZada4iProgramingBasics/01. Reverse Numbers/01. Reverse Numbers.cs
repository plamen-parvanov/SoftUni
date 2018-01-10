namespace _01.Reverse_Numbers
{

    using System;
    using System.Collections.Generic;


    public class StacksAndQueues
    {

        public static void Main()
        {
            var inputLine = Console.ReadLine()
                .Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries);
            var stack = new Stack<string>(inputLine);

            for (int i = 0; i < inputLine.Length - 1; i++)
            {
                Console.Write($"{stack.Pop()} ");
            }

            Console.WriteLine(stack.Pop());
        }
    }
}
