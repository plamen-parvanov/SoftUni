namespace _04.Rotate_Array_of_Strings
{

    using System;
    using System.Linq;


    public class Arrays
    {

        public static void Main()
        {
            var strArr = Console.ReadLine().Split();
            var len = strArr.Length - 1;
            var temp = strArr[len];

            for (int i = len; i > 0; i--)
            {

                strArr[i] = strArr[i - 1];
            }

            strArr[0] = temp;

            Console.WriteLine(string.Join(" ", strArr));

        }
    }
}
