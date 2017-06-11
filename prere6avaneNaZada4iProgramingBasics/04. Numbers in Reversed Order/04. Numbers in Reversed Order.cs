using System;


namespace _04.Numbers_in_Reversed_Order
{
    class Program
    {
        static void Main()
        {
            double number = double.Parse(Console.ReadLine());

            string reversedString = ReverseTheString(number);
            double reversedNumber = double.Parse(reversedString);

            Console.WriteLine(reversedNumber);

        }

        static string ReverseTheString(double number)
        {
            string numberToString = number.ToString();
            string reversedNumber = string.Empty;

            for (int i = numberToString.Length - 1; i >= 0; i--)
            {
                reversedNumber += numberToString[i];
            }

            return reversedNumber;
        }
    }
}
