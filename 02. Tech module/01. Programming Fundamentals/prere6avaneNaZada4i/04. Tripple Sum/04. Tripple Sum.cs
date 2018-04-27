using System;


namespace _04.Tripple_Sum
{
    class Program
    {
        static void Main()
        {
            string text = Console.ReadLine();

            string[] splitedTextArr = text.Split(' ');
            int[] numbersArr = new int[splitedTextArr.Length];
            CopyTextArrToNubmersArr(splitedTextArr, numbersArr);
            bool isTripleSum = false;

            for (int i = 0; i < numbersArr.Length; i++)
            {
                int a = numbersArr[i];

                for (int j = i + 1; j < numbersArr.Length; j++)
                {
                    int b = numbersArr[j];
                    PrintIfThereIsTripleSum(numbersArr,  ref isTripleSum, a, b);
                }
            }

            if (!isTripleSum)
            {
                Console.WriteLine("No");
            }

        }

        private static void PrintIfThereIsTripleSum(int[] numbersArr,  ref bool isTripleSum, int a, int b)
        {
            foreach (var number in numbersArr)
            {
                int c = number;

                if (a + b == c)
                {
                    Console.WriteLine($"{a} + {b} == {c}");
                    isTripleSum = true;
                    break;
                }
            }

        }

        private static void CopyTextArrToNubmersArr(string[] splitedTextArr, int[] numbersArr)
        {
            for (int i = 0; i < numbersArr.Length; i++)
            {
                numbersArr[i] = int.Parse(splitedTextArr[i]);
            }
        }
    }
}
