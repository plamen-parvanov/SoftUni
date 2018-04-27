namespace _11.Odd_Number
{

    using System;


    public class Problem11
    {

        public static void Main()
        {

            for (int i = 0; i < 10; i++)
            {
                var inputNum = int.Parse(Console.ReadLine());

                if (inputNum % 2 == 0)
                {
                    Console.WriteLine("Please write an odd number.");
                }
                else
                {
                    Console.WriteLine($"The number is: {Math.Abs(inputNum)}");
                    break;
                }
            }

        }
    }
}
