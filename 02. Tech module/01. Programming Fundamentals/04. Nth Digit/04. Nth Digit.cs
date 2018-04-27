namespace _04.Nth_Digit
{

    using System;


    public class Arrays
    {

        public static void Main()
        {
            var num = long.Parse(Console.ReadLine());
            var n = long.Parse(Console.ReadLine());

            var result = FindNthDigit(num, n);

            Console.WriteLine(result);

        }

        public static byte FindNthDigit(long num, long n)
        {
            byte nThDigit = 0;

            for (int i = 0; i < n; i++)
            {
                nThDigit = (byte)(num % 10);
                num /= 10;
            }

            return nThDigit;

        }
    }
}
