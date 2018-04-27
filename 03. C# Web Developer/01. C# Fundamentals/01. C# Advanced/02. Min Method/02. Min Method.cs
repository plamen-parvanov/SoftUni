namespace _02.Min_Method
{

    using System;

    public class Problem02
    {

        public static void Main()
        {
            var firstNum = int.Parse(Console.ReadLine());
            var secondNum = int.Parse(Console.ReadLine());
            var thirdNum = int.Parse(Console.ReadLine());

            var min = GetMin(firstNum, secondNum);
            min = GetMin(min, thirdNum);

            Console.WriteLine(min);
        }

        public static int GetMin(int a, int b)
        {
            var min = b;

            if (a < b)
            {
                min = a;
            }

            return min;
        }
    }
}
