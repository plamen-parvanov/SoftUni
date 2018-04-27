namespace _02.Average_Character_Delimiter
{

    using System;
    using System.Collections.Generic;

    public class Problem02
    {

        public static void Main()
        {
            var inputLine = Console.ReadLine();
            var strArr = inputLine.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            var sum = 0;

            foreach (var str in strArr)
            {
                var currSum = CalculateSumOfCharsInStr(str);

                sum += currSum;
            }

            var charCntr = CalculateAllLettersInArr(strArr);

            var delimiter = ((char)(sum / charCntr)).ToString().ToUpper();
            

            Console.WriteLine(string.Join(delimiter, strArr));
        }

        public static int CalculateSumOfCharsInStr(string str)
        {
            var sum = 0;

            foreach (var letter in str)
            {
                sum += letter;
            }
            return sum;
        }

        public static int CalculateAllLettersInArr(string[] arr)
        {
            var sum = 0;

            foreach (var word in arr)
            {
                sum += word.Length;
            }

            return sum;
        }
    }
}
