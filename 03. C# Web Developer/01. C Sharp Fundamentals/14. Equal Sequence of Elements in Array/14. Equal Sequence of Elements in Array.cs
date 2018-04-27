namespace _14.Equal_Sequence_of_Elements_in_Array
{

    using System;

    public class Problem14
    {

        public static void Main()
        {
            var input = Console.ReadLine();

            var intArr = InitializeIntArr(input);

            bool areAllEllEqual = ChecksAreAllEllEqual(intArr);

            if (areAllEllEqual)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
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

        public static bool ChecksAreAllEllEqual(int[] intArr)
        {
            var areEqual = true;
            var currNum = intArr[0];

            foreach (var num in intArr)
            {
                if (currNum != num)
                {
                    areEqual = false;
                }

                currNum = num;
            }

            return areEqual;
        }
    }
}
