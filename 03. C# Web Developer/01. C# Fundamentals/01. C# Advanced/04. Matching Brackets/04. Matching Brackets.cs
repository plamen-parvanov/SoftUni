namespace _04.Matching_Brackets
{
    using System;
    using System.Collections.Generic;

    public class Problem04
    {
        
        public static void Main()
        {
            var indexes = new Stack<int>();
            var input = Console.ReadLine();

            for (int i = 0; i < input.Length; i++)
            {
                var currSymbol = input[i];

                if (currSymbol == '(')
                {
                    indexes.Push(i);
                }
                else if (currSymbol == ')')
                {
                    var openBrecketIndex = indexes.Pop();
                    var length = i - openBrecketIndex + 1;

                    Console.WriteLine(input.Substring(openBrecketIndex, length));
                }
            }
        }
    }
}
