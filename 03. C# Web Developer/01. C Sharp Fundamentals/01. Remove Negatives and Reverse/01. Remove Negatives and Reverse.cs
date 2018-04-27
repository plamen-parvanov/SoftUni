namespace _01.Remove_Negatives_and_Reverse
{
    using System;
    using System.Collections.Generic;

    public class Problem01
    {

        public static void Main()
        {
            var input = Console.ReadLine();
            var intArr = InitializeIntArr(input);
            var intList = new List<int>();

            foreach (var num in intArr)
            {
                if (num >= 0)
                {
                    intList.Add(num);
                }
            }

            intList.Reverse();
            if (intList.Count > 0)
            {
                Console.WriteLine(string.Join(" ", intList));
            }
            else
            {
                Console.WriteLine("empty");
            }
            
        }

        public static int[] InitializeIntArr(string input)
        {
            var inputArr = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            var intArr = new int[inputArr.Length];

            for (int i = 0; i < inputArr.Length; i++)
            {
                intArr[i] = int.Parse(inputArr[i]);
            }

            return intArr;
        }
    }
}
