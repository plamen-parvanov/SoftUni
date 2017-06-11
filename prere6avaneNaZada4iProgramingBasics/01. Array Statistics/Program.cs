namespace _01.Array_Statistics
{
    using System;
    using System.Linq;

    public class Arrays
    {

        public static void Main()
        {
            var numberArr = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int minNumber = GetMinElementInArray(numberArr);

            int maxNumber = GetMaxElementInArray(numberArr);

            int sumAllNumbers = GetNumbersSumInArr(numberArr);

            double averageValue = GetAverageValueInArr(numberArr);

            Console.WriteLine($"Min = {minNumber}");
            Console.WriteLine($"Max = {maxNumber}");
            Console.WriteLine($"Sum = {sumAllNumbers}");
            Console.WriteLine($"Average = {averageValue}");
                 

        }

        public static int GetMinElementInArray(int[] arr)
        {
            int minNumber = int.MaxValue;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < minNumber)
                {
                    minNumber = arr[i];
                }
            }

            return minNumber;
        }

        public static int GetMaxElementInArray(int[] arr)
        {
            int maxNumber = int.MinValue;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > maxNumber)
                {
                    maxNumber = arr[i];
                }
            }

            return maxNumber;

        }

        public static int GetNumbersSumInArr(int[] arr)
        {
            int sum = 0;

            foreach (var number in arr)
            {
                sum += number;
            }

            return sum;
        }

        public static double GetAverageValueInArr(int[] arr)
        {
            double average = GetNumbersSumInArr(arr) / (double)arr.Length;
            return average;
        }
    }
}
