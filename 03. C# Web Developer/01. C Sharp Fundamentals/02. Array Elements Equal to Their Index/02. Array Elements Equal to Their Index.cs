namespace _02.Array_Elements_Equal_to_Their_Index
{

    using System;

    public class Problem02
    {

        public static void Main()
        {
            var input = Console.ReadLine();
            var intArr = InitializeIntArr(input);

            for (int i = 0; i < intArr.Length; i++)
            {
                var currNum = intArr[i];
                var index = i;

                if (currNum == index)
                {
                    Console.Write($"{currNum} ");
                }
            }
            Console.WriteLine();
        }

        public static int[] InitializeIntArr(string input)
        {
            var strArr = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            var intArr = new int[strArr.Length];

            for (int i = 0; i < strArr.Length; i++)
            {
                intArr[i] = int.Parse(strArr[i]);
            }

            return intArr;
        }
    }
}
