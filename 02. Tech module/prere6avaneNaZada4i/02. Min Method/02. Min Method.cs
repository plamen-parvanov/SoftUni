using System;


namespace _02.Min_Method
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());
            int thirdNum = int.Parse(Console.ReadLine());

            int smallestNum = GetMinOfThree(firstNum, secondNum, thirdNum);
            Console.WriteLine(smallestNum);
        }

        static int GetMinOfThree(int num1, int num2, int num3)
        {
            int result = GetMin(GetMin(num1, num2), num3);
            return result;
        }

        static int GetMin(int num1, int num2)
        {
            int smaller = num2;
            if (num1 < num2)
            {
                smaller = num1;
            }
            return smaller;
        }
    }
}
