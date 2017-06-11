namespace _07.Max_Sequence_of_Increasing_Elementss
{
    using System;


    public class Arrays
    {

        public static void Main()
        {
            string input = Console.ReadLine();
            int[] numberArr = InitNumberArrFromInput(input);

            int maxCntr = 0;
            int bestStart = 0;

            FindMaxIncreasingSeqInArr(numberArr, ref maxCntr, ref bestStart);

            PrintsMaxIncresingSeqInArr(numberArr, maxCntr, bestStart);

        }

        public static void PrintsMaxIncresingSeqInArr(int[] numberArr, int maxCntr, int bestStart)
        {

            for (int i = bestStart; maxCntr > 0; maxCntr--, i++)
            {
                Console.Write(numberArr[i] + " ");
            }
            Console.WriteLine();

        }

        public static void FindMaxIncreasingSeqInArr(int[] numberArr, ref int maxCntr, ref int bestStart)
        {
            int cntr = 1;
            int start = 0;

            for (int i = 0; i < numberArr.Length - 1; i++)
            {

                if (numberArr[i] < numberArr[i + 1])
                {
                    cntr++;
                    if (cntr > maxCntr)
                    {
                        maxCntr = cntr;
                        bestStart = start;
                    }
                }
                else
                {
                    cntr = 1;
                    start = i + 1;
                }

            }
        }

        public static int[] InitNumberArrFromInput(string text)
        {
            string[] textSplited = text.Split(' ');
            int[] numbersArr = new int[textSplited.Length];

            for (int i = 0; i < numbersArr.Length; i++)
            {
                numbersArr[i] = int.Parse(textSplited[i]);
            }

            return numbersArr;
        }
    }
}
