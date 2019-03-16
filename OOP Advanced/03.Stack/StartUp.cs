namespace _03.StackWithNode
{
    using System;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            var stack = new MyStack<int>();

            string inputLine;
            while ((inputLine = Console.ReadLine()) != "END")
            {
                try
                {
                    ExecuteCommand(inputLine, stack);
                }
                catch (InvalidOperationException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            Print(stack);
            Print(stack);
        }

        private static void Print(MyStack<int> stack)
        {
            foreach (var element in stack)
            {
                Console.WriteLine(element);
            }
        }

        private static void ExecuteCommand(string inputLine, MyStack<int> stack)
        {
            if (inputLine == "Pop")
            {
                stack.Pop();
            }
            else
            {
                inputLine.Split(new[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries)
                         .Skip(1)
                         .Select(int.Parse)
                         .ToList()
                         .ForEach(e => stack.Push(e));       
            }
        }
    }
}
