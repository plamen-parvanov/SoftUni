namespace _07.Balanced_Parenthesis
{
    using System;
    using System.Collections.Generic;

    public class Problem07
    {
        public static void Main()
        {
            var input = Console.ReadLine();

            if (InputIsBalanced(input))
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
        }

        private static bool InputIsBalanced(string input)
        {
            var stack = new Stack<char>();

            for (int i = 0; i < input.Length; i++)
            {
                var currSymbol = input[i];

                switch (currSymbol)
                {
                    case '(':
                    case '{':
                    case '[':
                        stack.Push(currSymbol);
                        break;

                    case ')':
                        if (stack.Count == 0 || stack.Pop() != '(')
                        {
                            return false;
                        }
                        break;
                    case '}':
                        if (stack.Count == 0 || stack.Pop() != '{')
                        {
                            return false;
                        }
                        break;
                    case ']':
                        if (stack.Count == 0 || stack.Pop() != '[')
                        {
                            return false;
                        }
                        break;
                }

            }

            return true;
        }
    }
}
