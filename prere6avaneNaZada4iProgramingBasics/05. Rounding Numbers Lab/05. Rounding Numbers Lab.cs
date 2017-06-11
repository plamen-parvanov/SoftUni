namespace _05.Rounding_Numbers_Lab
{
    using System;


    public class Arrays
    {

        public static void Main()
        {
            string input = Console.ReadLine();
            string[] inputArr = input.Split(' ');
            double[] numbersArr = new double[inputArr.Length];
            InitNumbArr(inputArr, numbersArr);

            int[] roundedArr = new int[numbersArr.Length];
            InitRoundedArr(numbersArr, roundedArr);
            PrintRoundedNumbs(numbersArr, roundedArr);
        }

        public static void PrintRoundedNumbs(double[] numbersArr, int[] roundedArr)
        {
            for (int i = 0; i < roundedArr.Length; i++)
            {
                Console.WriteLine("{0} => {1}",
                    numbersArr[i], roundedArr[i]);
            }
        }

        public static void InitRoundedArr(double[] numbersArr, int[] roundedArr)
        {
            for (int i = 0; i < roundedArr.Length; i++)
            {
                roundedArr[i] = (int)Math.Round(numbersArr[i], MidpointRounding.AwayFromZero);
            }
        }

        public static void InitNumbArr(string[] inputArr, double[] numbersArr)
        {
            for (int i = 0; i < numbersArr.Length; i++)
            {
                numbersArr[i] = double.Parse(inputArr[i]);
            }
        }
    }
}
