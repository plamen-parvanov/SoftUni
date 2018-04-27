namespace _01.Debit_Card_Number
{

    using System;


    public class Problem01
    {

        public static void Main()
        {

            var firstNum = short.Parse(Console.ReadLine());
            var secondNum = short.Parse(Console.ReadLine());
            var thirdNum = short.Parse(Console.ReadLine());
            var forthNum = short.Parse(Console.ReadLine());

            Console.WriteLine($"{firstNum:d4} {secondNum:d4} {thirdNum:d4} {forthNum:d4}");


        }
    }
}
