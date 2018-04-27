namespace _03.Decimal_to_Binary_Converter
{
    using System;
    using System.Collections.Generic;

    public class Problem03
    {
        public static void Main()
        {
            var decimalNum = int.Parse(Console.ReadLine());
            if (decimalNum == 0)
            {
                Console.WriteLine(0);
                return;
            }

            var binaryNum = new Stack<int>();

            while (decimalNum > 0)
            {
                binaryNum.Push(decimalNum % 2);
                decimalNum /= 2;
            }

            Print(binaryNum);
        }

        private static void Print(Stack<int> binaryNum)
        {
            while (binaryNum.Count > 0)
            {
                Console.Write(binaryNum.Pop());
            }

            Console.WriteLine();
        }
    }
}
