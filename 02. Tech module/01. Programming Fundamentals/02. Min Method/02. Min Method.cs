namespace _02.Min_Method
{

    using System;


    public class Arrays
    {

        public static void Main()
        {
            var firstNum = double.Parse(Console.ReadLine());
            var secondNum = double.Parse(Console.ReadLine());
            var thirdNum = double.Parse(Console.ReadLine());

            var smallerNum = FindSmallerNum(firstNum, secondNum);
            var smallestNum = FindSmallerNum(smallerNum, thirdNum);

            Console.WriteLine(smallestNum);



        }

        public static double FindSmallerNum(double firstNum, double secondNum)
        {
            var smaller = firstNum < secondNum ? firstNum : secondNum;
            return smaller;
        }
    }
}
