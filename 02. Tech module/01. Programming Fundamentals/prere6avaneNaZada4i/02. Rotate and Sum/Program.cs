namespace _02.Rotate_and_Sum
{
    using System;


    public class Array
    {

        public static void Main()
        {
            string input = Console.ReadLine();

            string[] inputSplited = input.Split(' ');
            int[] numbersArr = new int[inputSplited.Length];

            AssigningValue(inputSplited, numbersArr);

            int[] sumArr = new int[numbersArr.Length];

            int k = int.Parse(Console.ReadLine());

            for (int i = 0; i < k; i++)
            {
                RotateNumbersArr(numbersArr);

                SumRotatedArr(numbersArr, sumArr);
            }

            Console.WriteLine(string.Join(" ", sumArr));
           

        }

        public static void SumRotatedArr(int[] numbersArr, int[] sumArr)
        {
            for (int i = 0; i < numbersArr.Length; i++)
            {
                sumArr[i] += numbersArr[i];
            }
        }

        public static void AssigningValue(string[] inputSplited, int[] numbersArr)
        {
            for (int i = 0; i < inputSplited.Length; i++)
            {
                numbersArr[i] = int.Parse(inputSplited[i]);
            }
        }

        public static void RotateNumbersArr(int[] numbersArr)
        {
            int temp = numbersArr[numbersArr.Length - 1];

            for (int i = numbersArr.Length - 1; i > 0; i--)
            {
                numbersArr[i] = numbersArr[i - 1];
            }

            numbersArr[0] = temp;
        }

    }
}
