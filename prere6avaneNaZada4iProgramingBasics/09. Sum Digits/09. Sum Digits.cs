using System;


namespace _09.Sum_Digits
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sumDigits = 0;
            while (n != 0)
            {
                int lastDigit = n % 10;
                sumDigits += lastDigit;
                n /= 10;
            }
            Console.WriteLine(sumDigits);
        }
    }
}
