using System;


namespace _12.Master_Number
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            PrintAllMasterNumbers(n);
        }

        static void PrintAllMasterNumbers(int n)
        {
            
            for (int i = 1; i <= n; i++)
            {
                string numberStr = i.ToString();

                if (IsPalindrome(numberStr) && IsSumOfDigitsDivisibleBy7(i) && IsHoldOneEvenDigit(i))
                {
                    Console.WriteLine(i);
                }
            }
        }

        //static bool IsNumberPalindrom(int number)
        //{
        //    int reverseNumber = ReverseNumber(number);

        //    if (number == reverseNumber)
        //    {
        //        return true;
        //    }
        //    return false;
        //}

        public static bool IsPalindrome(string value)
        {
            int min = 0;
            int max = value.Length - 1;
            while (true)
            {
                if (min > max)
                {
                    return true;
                }
                char a = value[min];
                char b = value[max];
                if (char.ToLower(a) != char.ToLower(b))
                {
                    return false;
                }
                min++;
                max--;
            }
        }


        static int ReverseNumber(int number)
        {
            string reverseNumber = string.Empty;
            for (int i = number; i > 0; i /= 10)
            {
                reverseNumber += i % 10;
            }
            return int.Parse(reverseNumber);
        }

        static bool IsSumOfDigitsDivisibleBy7(int number)
        {
            int sumOfDigits = GetSumOfDigits(number);

            if (sumOfDigits % 7 == 0)
            {
                return true;
            }
            return false;
        }

        static int GetSumOfDigits(int number)
        {
            int sumOfDigits = 0;

            for (int i = number; i > 0; i /= 10)
            {
                sumOfDigits += i % 10;
            }
            return sumOfDigits;
        }

        static bool IsHoldOneEvenDigit(int number)
        {
            for (int i = number; i > 0; i /= 10)
            {
                int digit = i % 10;

                if (digit % 2 == 0)
                {
                    return true;
                }
            }
            return false;

        }





    }
}
