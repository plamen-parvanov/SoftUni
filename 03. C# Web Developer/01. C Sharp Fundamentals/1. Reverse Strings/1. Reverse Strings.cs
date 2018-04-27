namespace _1.Reverse_Strings
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Problem01
    {
        public static void Main()
        {
            var str = new Stack<char>(Console.ReadLine().ToArray());

            PrintReversed(str);
        }

        private static void PrintReversed(Stack<char> str)
        {
            var lenght = str.Count;
            for (int i = 0; i < lenght; i++)
            {
                Console.Write(str.Pop());
            }
            Console.WriteLine();
        }
    }
}
