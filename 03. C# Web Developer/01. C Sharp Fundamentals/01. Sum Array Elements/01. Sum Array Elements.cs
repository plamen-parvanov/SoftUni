namespace _01.Sum_Array_Elements
{

    using System;


    public class Problem01
    {

        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var arr = new int[n];

            for (int i = 0; i < n; i++)
            {
                var currNum = int.Parse(Console.ReadLine());
                arr[i] = currNum;
            }

            var sum = 0;

            foreach (var num in arr)
            {
                sum += num;
            }

            Console.WriteLine(sum);
        }
    }
}
