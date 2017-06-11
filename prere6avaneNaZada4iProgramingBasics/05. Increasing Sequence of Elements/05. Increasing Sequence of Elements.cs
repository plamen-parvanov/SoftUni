using System;


namespace _05.Increasing_Sequence_of_Elements
{
    class Program
    {
        static void Main()
        {
            string lineSplited = Console.ReadLine();

            string[] numbersStrArr = lineSplited.Split(' ');
            int[] numbersIntArr = new int[numbersStrArr.Length];

            CopyStrArrToIntArr(numbersStrArr, numbersIntArr);

            PrintsIsArrIncreasing(numbersIntArr);

        }

        private static void CopyStrArrToIntArr(string[] numbersStrArr, int[] numbersIntArr)
        {
            for (int i = 0; i < numbersStrArr.Length; i++)
            {
                numbersIntArr[i] = int.Parse(numbersStrArr[i]);
            }
        }

        private static void PrintsIsArrIncreasing(int[] numbersIntArr)
        {
            if (IsArrIncreasing(numbersIntArr))
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }

        private static bool IsArrIncreasing(int[] numbersIntArr)
        {
            int lastNumber = int.MinValue;
            bool isArrIncreasing = true;

            foreach (var number in numbersIntArr)
            {
                if (number < lastNumber)
                {
                    isArrIncreasing = false;
                    break;
                }
                lastNumber = number;
            }
            return isArrIncreasing;
        }
    }
}
