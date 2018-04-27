using System;


namespace _02.Max_Method
{
    class Program
    {
        static void Main()
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int thirdNumber = int.Parse(Console.ReadLine());

            int maxNumber = MaxNumber(firstNumber, secondNumber, thirdNumber);

            Console.WriteLine(maxNumber);
        }

        static int MaxNumber(int firstNumber, int secondNumber, int thirdNumber)
        {
            int biggerFromFirstAndSecond = GetBigger(firstNumber, secondNumber);
            int maxNumber = GetBigger(biggerFromFirstAndSecond, thirdNumber);
            return maxNumber;
        }

        static int GetBigger(int firstNumber, int secondNumber)
        {
            int bigger = secondNumber;
            if (firstNumber > secondNumber)
            {
                bigger = firstNumber;
            }
            return bigger;
        }
    }
}
