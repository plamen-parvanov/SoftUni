namespace _02.Rotate_and_Summ
{
    using System;


    public class Arraws
    {
        public static void Main()
        {
            string input = Console.ReadLine();

            int[] numberArr = ConvertInputToIntArr(input);
            int[] sumRotatedArr = new int[numberArr.Length]; 

            int rotateNumb = int.Parse(Console.ReadLine());

            for (int i = 0; i < rotateNumb; i++)
            {
                numberArr = RotateNumberArr(numberArr);

                sumRotatedArr = SumRotatedArr(numberArr, sumRotatedArr);
            }

            Console.WriteLine(string.Join(" ", sumRotatedArr));

        }

        public static int[] ConvertInputToIntArr(string input)
        {
            string[] inputArr = input.Split(' ');
            int[] numbersArr = new int[inputArr.Length];

            for (int i = 0; i < numbersArr.Length; i++)
            {
                numbersArr[i] = int.Parse(inputArr[i]);
            }

            return numbersArr;
        }

        public static int[] RotateNumberArr(int[] arr)
        {
            int temp = arr[arr.Length - 1];

            for (int i = arr.Length - 1; i > 0; i--)
            {
                arr[i] = arr[i - 1];
            }

            arr[0] = temp;

            return arr;

        }

        public static int[] SumRotatedArr(int[] arr, int[] sumArr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                sumArr[i] += arr[i];
            }

            return sumArr;

        }
    }
}
