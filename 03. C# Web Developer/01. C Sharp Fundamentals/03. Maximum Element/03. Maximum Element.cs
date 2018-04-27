namespace _03.Maximum_Element
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Problem03
    {
        public static Stack<byte> maxNum; 
        public static void Main()
        {
            var commandsNum = byte.Parse(Console.ReadLine());
            var stack = new Stack<byte>();
            maxNum = new Stack<byte>();

            for (byte i = 0; i < commandsNum; i++)
            {
                ExecuteCommand(stack);
            }
        }

        private static void ExecuteCommand(Stack<byte> stack)
        {
            var inputLine = Console.ReadLine()
                   .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                   .Select(byte.Parse)
                   .ToArray();

            switch (inputLine[0])
            {
                case 1:
                    stack.Push(inputLine[1]);
                    var maxEll = maxNum.Count == 0 ? byte.MinValue : maxNum.Peek();
                    if (inputLine[1] > maxEll)
                    {
                        maxNum.Push(inputLine[1]);
                    }
                    break;
                case 2:
                    if (maxNum.Peek() == stack.Peek())
                    {
                        maxNum.Pop();
                    }
                    stack.Pop();
                    break;
                case 3:
                    Console.WriteLine(maxNum.Peek());
                    break;
            }
        }
    }
}
