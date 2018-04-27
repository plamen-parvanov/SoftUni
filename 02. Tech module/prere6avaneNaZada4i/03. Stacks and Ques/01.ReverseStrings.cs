namespace _03.Stacks_and_Ques
{

    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StacksAndQueues
    {

        public static void Main()
        {
            var numbersArr = Console.ReadLine()
                            .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                            .Select(int.Parse)
                            .ToArray();

            var numbersStack = new Stack<int>();

            foreach (var number in numbersArr)
            {
                numbersStack.Push(number);
            }

            //Console.WriteLine(string.Join(" ", numbersStack));

            foreach (var item in numbersArr)
            {
                Console.WriteLine(numbersStack.Pop());
               
            }

        }
    }
}
