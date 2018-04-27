namespace _02.SimpleCalculator
{

    using System;
    using System.Collections.Generic;

    public class StacksAndQueues
    {

        public static void Main()
        {
            var inputString = Console.ReadLine().Split();

            var stack = new Stack<string>();

            for (int i = inputString.Length - 1; i >= 0; i--)
            {
                stack.Push(inputString[i]);
            }

            var sum = SumNumbersInStack(stack);

            Console.WriteLine(sum);


        }

        public static int SumNumbersInStack(Stack<string> stack)
        {
            var number = 0;
            var sum = 0;

            while (stack.Count > 0)
            {
                var currSymbol = stack.Pop();


                switch (currSymbol)
                {
                    case "+":
                        number = int.Parse(stack.Pop());
                        sum += number;
                        break;
                    case "-":
                        number = int.Parse(stack.Pop());
                        sum -= number;
                        break;
                    default:
                        number = int.Parse(currSymbol);
                        sum += number;
                        break;
                }
            }

            return sum;
        }
    }
}
