namespace _03.Fold_and_Summ
{
    using System;


    public class Program
    {

        public static void Main()
        {
            string input = Console.ReadLine();

            int[] numberArr = ParseInputToIntArr(input);

            int[] sumArr = new int[numberArr.Length / 2];
            int n = numberArr.Length / 4;

            FillFirstHalfOfSumArr(sumArr, numberArr, n);

            FillSecondHalfOfSumArr(sumArr, numberArr, n);

            Console.WriteLine(string.Join(" ", sumArr));


        }

        public static int[] ParseInputToIntArr(string input)
        {
            string[] inputArr = input.Split(' ');
            int[] numberArr = new int[inputArr.Length];

            for (int i = 0; i < numberArr.Length; i++)
            {
                numberArr[i] = int.Parse(inputArr[i]);
            }

            return numberArr;
        }

        public static void FillFirstHalfOfSumArr(int[] sumArr, int[] numberArr, int n)
        {


            for (int i = 0; i < sumArr.Length / 2; i++)
            {
                sumArr[i] = numberArr[n - 1 - i] + numberArr[n + i];
            }
        }

        public static void FillSecondHalfOfSumArr(int[] sumArr, int[] numberArr, int n)
        {
            for (int i = 0; i < n; i++)
            {
                sumArr[n + i] = numberArr[n * 2 + i] + numberArr[numberArr.Length - 1 - i];
            }
        }
    }
}
