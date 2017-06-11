using System;


namespace _08.Condense_Array_to_Number
{
    class Program
    {
        static void Main()
        {
            string numbersStr = Console.ReadLine();
            string[] numbStrArr = numbersStr.Split(' ');

            int[] numbersArr = new int[numbStrArr.Length];
            CopyNumbSrtArrInNumberArr(numbStrArr, numbersArr);

            numbersArr = CondenseArrayToNumber(numbersArr);

            Console.WriteLine(numbersArr[0]);


        }

        private static void CopyNumbSrtArrInNumberArr(string[] numbStrArr, int[] numbersArr)
        {
            for (int i = 0; i < numbStrArr.Length; i++)
            {
                numbersArr[i] = int.Parse(numbStrArr[i]);
            }
        }

        private static int[] CondenseArrayToNumber(int[] numbersArr)
        {
            while (numbersArr.Length > 1)
            {
                int[] newNumbArr = new int[numbersArr.Length - 1];

                for (int i = 0; i < newNumbArr.Length; i++)
                {
                    newNumbArr[i] = numbersArr[i] + numbersArr[i + 1];
                }

                numbersArr = newNumbArr;

            }

            return numbersArr;
        }
    }
}
