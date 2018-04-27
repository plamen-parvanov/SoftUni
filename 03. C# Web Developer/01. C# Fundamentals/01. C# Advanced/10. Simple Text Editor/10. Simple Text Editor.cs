namespace _10.Simple_Text_Editor
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Problem10
    {
        private static Stack<String> stack;
        public static void Main()
        {
            ExecuteAllCommands();
        }

        private static void ExecuteAllCommands()
        {
            stack = new Stack<String>();
            var commandsNum = int.Parse(Console.ReadLine());

            for (int i = 0; i < commandsNum; i++)
            {
                ExecuteCommandLine();
            }
        }

        private static void ExecuteCommandLine()
        {
            var inputLine = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            var command = inputLine[0];

            switch (command)
            {
                case "1":
                    AppendsText(inputLine);
                    break;
                case "2":
                    ErasesLastCountOfElements(inputLine);
                    break;
                case "3":
                    var index = int.Parse(inputLine[1]) - 1;
                    Console.WriteLine(stack.Peek()[index]);
                    break;
                case "4":
                    stack.Pop();
                    break;
            }

        }

        private static void ErasesLastCountOfElements(string[] inputLine)
        {
            var currStr = stack.Peek();
            var count = int.Parse(inputLine[1]);
            var startIndex = currStr.Length - count;
            stack.Push(currStr.Remove(startIndex, count));
        }

        private static void AppendsText(string[] inputLine)
        {
            if (stack.Count > 0)
            {
                stack.Push(stack.Peek() + inputLine[1]);
            }
            else
            {
                stack.Push(inputLine[1]);
            }   
        }
    }
}
