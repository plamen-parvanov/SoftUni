namespace _08.Multiply_Evens_by_Odds
{
    using System;


    class MethodsDebugging
    {

        static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            number = Math.Abs(number);
            int result = MultyplyOddEvenSums(number);
            Console.WriteLine(result);
                
        }

        static int MultyplyOddEvenSums(int num)
        {
            int sumEvenDigit = sumDigits(num, 0);
            int sumOddDigit = sumDigits(num, 1);

            return sumEvenDigit * sumOddDigit;
        }

        static int sumDigits(int num, int evenOdd)
        {
            int sumDigits = 0;

            while (num > 0)
            {
                int currDigit = num % 10;

                if ( currDigit % 2 == evenOdd)
                {   
                    sumDigits += currDigit;
                }

                num /= 10;
            }

            return sumDigits;
        }
    }
}
