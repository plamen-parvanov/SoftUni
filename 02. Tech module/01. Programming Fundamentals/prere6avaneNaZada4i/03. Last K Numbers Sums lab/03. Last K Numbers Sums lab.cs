namespace _03.Last_K_Numbers_Sums_lab
{
    using System;


    public class Program
    {

        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());

            long[] Arr = new long[n];
            Arr[0] = 1;

            for (int i = 1; i < n; i++)
            {
                Arr[i] = SumPreviousKelements(k, n, Arr, i);
            }

            Console.WriteLine(string.Join(" ", Arr));
        }

        public static long SumPreviousKelements(int k, int n, long[] Arr, int i)
        {
            long number = 0;

            for (int j = i - 1;  j >= 0 && k > 0; j--)
            {
                number += Arr[j];
                k--;
            }
            return number;
        }
    }
}
