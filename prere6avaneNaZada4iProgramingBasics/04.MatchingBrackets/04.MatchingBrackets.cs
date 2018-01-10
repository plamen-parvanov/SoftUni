namespace _04.MatchingBrackets
{

    using System;
    using System.Collections.Generic;


    public class StackAndQueues
    {

        public static void Main()
        {
            var input = Console.ReadLine();
            var stack = new Stack<int>();

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i].Equals('('))
                {
                    stack.Push(i);
                }

                if (input[i].Equals(')'))
                {                 
                    Console.WriteLine(input.Substring(stack.Peek(), i - stack.Pop() + 1 ));
                }
            }

        }
    }
}
