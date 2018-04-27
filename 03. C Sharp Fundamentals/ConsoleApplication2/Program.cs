namespace ConsoleApplication2
{

    using System;

    public class Program
    {

        static void Main()
        {
            var arr1 = new int[] { 1, 1, 1, 1 };
            Console.WriteLine(string.Join(", ", arr1));
            ChangeArr(arr1);

            Console.WriteLine(string.Join("-", arr1));
            // za6to izkarva 1111, a ne 1-2 ???


        }

        public static void ChangeArr(int[] arr1)
        {
            var arr2 = new int[] { 1, 2 };

            arr1[0] = 9;
            arr1 = arr2;
        }
    }
}
