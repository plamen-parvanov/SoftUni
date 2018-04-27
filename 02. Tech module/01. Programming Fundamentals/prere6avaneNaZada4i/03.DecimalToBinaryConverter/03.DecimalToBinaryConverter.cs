namespace _03.DecimalToBinaryConverter
{

    using System;
    using System.Collections.Generic;


    public class StacksAndQueues
    {

        public static void Main()
        {
            var num = int.Parse(Console.ReadLine());
            var stack = new Stack<int>();

            if (num == 0)
            {
                stack.Push(num);
            }

            while (num > 0)
            {
                stack.Push(num % 2);
                num /= 2;
            }

            Console.WriteLine(string.Join("", stack));
        }
    }
}
