namespace _09.Largest_Element_in_Array
{

    using System;

    public class Problem09
    {

        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var intArr = new int[n];

            for (int i = 0; i < n; i++)
            {
                intArr[i] = int.Parse(Console.ReadLine());
            }

            var maxNumInArr = GetMaxNumInArr(intArr);

            Console.WriteLine(maxNumInArr);
        }

        public static int GetMaxNumInArr(int[] arr)
        {
            var maxNum = int.MinValue;

            foreach (var num in arr)
            {
                if (num > maxNum)
                {
                    maxNum = num;
                }
            }

            return maxNum;
        }
    }
}
