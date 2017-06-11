namespace _02.Manipulate_Array
{
    using System;
    using System.Linq;

    public class Arrays
    {

        public static void Main()
        {
            var arr = Console.ReadLine().Split().ToArray();

            ReplaceEqualElementsWithEmptyString(arr);

            int cntr = CountElementsDiffrentFromEmpty(arr);

            var distinctArr = new string[cntr];
            int j = 0;

            for (int i = 0; i < distinctArr.Length; i++)
            {
                for (; j < arr.Length; j++)
                {
                    if (arr[j] != string.Empty)
                    {
                        distinctArr[i] = arr[j];
                        break;
                    }
                }
            }

            Console.WriteLine(string.Join("-", distinctArr));

        }

        public static int CountElementsDiffrentFromEmpty(string[] arr)
        {
            int cntr = 0;

            foreach (var item in arr)
            {
                if (item != "")
                {
                    cntr++;
                }
            }

            return cntr;
        }

        public static void ReplaceEqualElementsWithEmptyString(string[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        arr[i] = string.Empty;
                    }
                }
            }
        }
    }
}
