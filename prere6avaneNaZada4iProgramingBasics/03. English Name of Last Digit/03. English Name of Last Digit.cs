using System;


namespace _03.English_Name_of_Last_Digit
{
    class Program
    {
        static void Main()
        {
            long number = long.Parse(Console.ReadLine());

            int lastDigit = GetLastDigit(number);

            string lastDigitWithWords = GetNameOfLastDigit(lastDigit);

            Console.WriteLine(lastDigitWithWords);
        }

        static string GetNameOfLastDigit(long digit)
        {
            string lastDigit = string.Empty;
            switch (digit)
            {
                case 0:
                    lastDigit = "zero";
                    break;
                case 1:
                    lastDigit = "one";
                    break;
                case 2:
                    lastDigit = "two";
                    break;
                case 3:
                    lastDigit = "three";
                    break;
                case 4:
                    lastDigit = "four";
                    break;
                case 5:
                    lastDigit = "five";
                    break;
                case 6:
                    lastDigit = "six";
                    break;
                case 7:
                    lastDigit = "seven";
                    break;
                case 8:
                    lastDigit = "eight";
                    break;
                case 9:
                    lastDigit = "nine";
                    break;
            }
            return lastDigit;
        }

        static int GetLastDigit(long number)
        {
            int lastDigit = (int)Math.Abs(number % 10);
            return lastDigit;
        }
    }
}
