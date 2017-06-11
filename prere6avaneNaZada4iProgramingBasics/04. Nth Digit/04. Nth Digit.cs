using System;


namespace _04.Nth_Digit
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int indexN = int.Parse(Console.ReadLine());

            int nThdigit = FindNthDigit(number, indexN);
            Console.WriteLine(nThdigit);  
        }

        static int FindNthDigit(int num, int n)
        {
            int digit = 0;

            for (int i = 0; i < n; i++, num /= 10)
            {
                digit = num % 10;
            }

            return digit;
        }
    }
}
