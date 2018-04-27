namespace _03.Sum_Adjacent_Equal_Numbers
{

    using System;
    using System.Collections.Generic;

    public class Problem03
    {

        public static void Main()
        {
            var input = Console.ReadLine();

            var intList = InitializeIntList(input);

            for (int i = 0; i < intList.Count - 1; i++)
            {
                var currNum = intList[i];
                var nextNum = intList[i + 1];

                if (currNum == nextNum)
                {
                    intList[i] = intList[i] * 2;
                    intList.RemoveAt(i + 1);

                    if (i > 0)
                    {
                        i -= 2;
                    }
                    else
                    {
                        i--;
                    }
                }
            }

            Console.WriteLine(string.Join(" ", intList));
        }

        public static List<double> InitializeIntList(string input)
        {
            var inputArr = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            var intArr = new double[inputArr.Length];
            var intList = new List<double>();

            for (int i = 0; i < inputArr.Length; i++)
            {
                intArr[i] = double.Parse(inputArr[i]);
                intList.Add(intArr[i]);
            }

            return intList;
        }
    }
}
