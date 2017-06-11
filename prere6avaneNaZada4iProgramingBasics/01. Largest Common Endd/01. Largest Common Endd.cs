namespace _01.Largest_Common_Endd
{
    using System;


    public class Arrays
    {
        public static void Main()
        {
            string firstInput = Console.ReadLine();
            string[] firstArr = firstInput.Split(' ');

            string secondInput = Console.ReadLine();
            string[] secondArr = secondInput.Split(' ');

            int minLength = Math.Min(firstArr.Length, secondArr.Length);

            int cntrFromLeft = CountEqualsFromLeft(firstArr, secondArr, minLength);

            int cntrFromRight = CountEqualsFromRight(firstArr, secondArr, minLength);

            Console.WriteLine(Math.Max(cntrFromLeft, cntrFromRight));


        }

        public static int CountEqualsFromLeft(string[] firstArr, string[] secondArr, int length)
        {
            int cntrFromLeft = 0;

            for (int i = 0; i < length; i++)
            {
                if (firstArr[i] == secondArr[i])
                {
                    cntrFromLeft++;
                }
                else
                {
                    break;
                }
            }

            return cntrFromLeft;
        }

        public static int CountEqualsFromRight(string[] firstArr, string[] secondArr, int length)
        {
            int cntr = 0;

            for (int i = 0; i < length; i++)
            {
                if (firstArr[firstArr.Length - 1 - i] == secondArr[secondArr.Length - 1 - i])
                {
                    cntr++;
                }
                else
                {
                    break;
                }
            }

            return cntr;
        }
    }
}
