namespace _01.ReverseStrings
{

    using System;
    using System.Collections.Generic;

    public class StackAndQueues
    {

        public static void Main()
        {
            var textInput = Console.ReadLine();

            var stack = new Stack<char>();

            for (int i = 0; i < textInput.Length; i++)
            {
                stack.Push(textInput[i]);
            }

            //Console.WriteLine(string.Join("", stack));  // po bavno e s join

            while (stack.Count > 0)
            {
                Console.Write(stack.Pop());   
            }
            Console.WriteLine();
        }
    }
}
