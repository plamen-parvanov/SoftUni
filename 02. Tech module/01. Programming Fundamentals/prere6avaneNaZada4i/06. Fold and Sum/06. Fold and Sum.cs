namespace _06.Fold_and_Sum
{

    using System;
    using System.Collections.Generic;
    using System.Linq;
 

    public class Dictionaries
    {

        public static void Main()
        {
            var numArr = Console.ReadLine().Split().Select(int.Parse).ToArray();

            var len = numArr.Length / 4;

            var leftKelementsArr = numArr.Take(len).Reverse().ToArray();
            var rightKelementsArr = numArr.Reverse().Take(len).ToArray();
            var leftAndRightArr = leftKelementsArr.Concat(rightKelementsArr).ToArray();

            var middleKelemntsArr = numArr.Skip(len).Take(2 * len).ToArray();

            var resultArr = SumAllArr(len, leftAndRightArr, middleKelemntsArr);

            Console.WriteLine(string.Join(" ", resultArr));

        }

        public static int[] SumAllArr(int len, int[] leftAndRightArr, int[] middleKelemntsArr)
        {
            var resultArr = new int[2 * len];

            for (int i = 0; i < resultArr.Length; i++)
            {
                resultArr[i] = leftAndRightArr[i] + middleKelemntsArr[i];
            }

            return resultArr;
        }
    }
}
