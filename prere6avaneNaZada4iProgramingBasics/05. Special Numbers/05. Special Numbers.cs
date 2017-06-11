using System;


namespace _05.Special_Numbers
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i < n + 1; i++)
            {
                int sumOfDigits = SumDititsOfNumber(i);
                bool isNumberSpecial = false;

                if (sumOfDigits == 5 || sumOfDigits == 7 || sumOfDigits == 11)
                {
                    isNumberSpecial = true;
                }

                Console.WriteLine($"{i} -> {isNumberSpecial}");

            }
        }

        static int SumDititsOfNumber(int i)
        {
            int sum = 0;
            while (i > 0)
            {
                sum += i % 10;
                i /= 10;
            }
            return sum;
        }
    }
}
