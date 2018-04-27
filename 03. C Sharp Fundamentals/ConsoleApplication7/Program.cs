
namespace ConsoleApplication7
{
    using System;
    using System.Linq;

    public class Problem
    {
        public static void Main()
        {
            var input = "abc";

            var result = string.Join(string.Empty, input.Reverse());
           
           // Console.WriteLine(result);


            var arr = new int[] { 1, 2, 3, 1, 7};
            var input2 = "";
            var reminder = input == "odd" ? 1 : 0;
            var arr1 = arr.Where(x => x % 2 == reminder).ToArray();

            Array.LastIndexOf(arr, 1);

            var arr2 = arr.Skip(1).Take(3);
            var arr3 = arr.Concat(arr2);

            //Console.WriteLine(string.Join(", ", arr3));


            var newArr = (int[])arr.Clone();
            arr[0] = 100;
            newArr[0] = 111;

           // Console.WriteLine(arr[0]);
          //  Console.WriteLine(newArr[0]);

            var matrix = new int [5, 5];
            var matrix2 = (int[,])matrix.Clone();
            matrix[0, 0] = 100;
            matrix2[0, 0] = 111;

            Console.WriteLine(matrix[0,0]);
            Console.WriteLine(matrix2[0,0]);
        }
        
    }
}
